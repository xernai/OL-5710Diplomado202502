﻿using Microsoft.Azure.ServiceBus;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Azure.ServiceBus.ReceiveSample
{
    internal class Program
    {
        private static IQueueClient queueClient;
        private const string ServiceBusConnectionString = "";
        private const string QueueName = "leon";

        public static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        private static async Task MainAsync()
        {
            queueClient = new QueueClient(ServiceBusConnectionString, QueueName, ReceiveMode.PeekLock);

            Console.WriteLine("Press ctrl-c to stop receiving messages.");

            ReceiveMessages();

            Console.ReadKey();
            // Close the client after the ReceiveMessages method has exited. 
            await queueClient.CloseAsync();
        }

        // Receives messages from the queue in a loop 
        private static void ReceiveMessages()
        {
            try
            {
                // Register a OnMessage callback 
                queueClient.RegisterMessageHandler(
                    async (message, token) =>
                    {
                        // Process the message 
                        Console.WriteLine($"Received message: SequenceNumber:{message.SystemProperties.SequenceNumber} Body:{Encoding.UTF8.GetString(message.Body)}");

                        // Complete the message so that it is not received again. 
                        // This can be done only if the queueClient is opened in ReceiveMode.PeekLock mode. 
                        await queueClient.CompleteAsync(message.SystemProperties.LockToken);
                    },
                    new MessageHandlerOptions(exceptionReceivedEventArgs =>
                    {
                        Console.WriteLine($"Message handler encountered an exception {exceptionReceivedEventArgs.Exception}.");
                        return Task.CompletedTask;
                    })
                    { MaxConcurrentCalls = 1, AutoComplete = false });
            }
            catch (Exception exception)
            {
                Console.WriteLine($"{DateTime.Now} > Exception: {exception.Message}");
            }
        }
    }
}
