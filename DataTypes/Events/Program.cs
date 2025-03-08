using System;

namespace Events
{
    // 1. Se declara un delegado
    public delegate void TemperatureChangeHandler();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Example of Events.");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            People maia = new People();
            maia.Name = "Maia";

            People genaro = new People();
            genaro.Name = "Genaro";


            Console.WriteLine("----------- Aviso Nuevo video -------------");
            maia.NotifyTemperature();


            // Instancia la clase Publisher
            WeatherForecast weatherForecast = new WeatherForecast();

            // Subscribo los event handlers, no son más que los métodos que el evento va a ejecutar
            weatherForecast.OnTemperatureChanged += maia.NotifyTemperature;
            weatherForecast.OnTemperatureChanged += genaro.NotifyTemperature;

            weatherForecast.EvaluateTemperature(35);

            weatherForecast.OnTemperatureChanged -= maia.NotifyTemperature;
            weatherForecast.OnTemperatureChanged -= genaro.NotifyTemperature;
        }
    }

    // Publisher
    public class WeatherForecast
    {
        // 2. El evento (keyword event es un modifier) se basa en el delegado TemperatureChangeHandler
        // Sugar syntax, Syntactic sugar
        public event TemperatureChangeHandler OnTemperatureChanged;

        public void EvaluateTemperature(double temperature)
        {
            if (temperature == 35)
            {
                // Significa que el evento tiene métodos asociados para ejecutarse
                if (OnTemperatureChanged != null)
                {
                    OnTemperatureChanged();
                }
            }
        }
    }

    // Clase subscriptora
    public class People
    {
        private string name;

        public string Name
        {
            get { return name; }

            set
            {
                name = value;
            }
        }

        public string LastName { get; set; }
        public int Age { get; set; }

        public void NotifyTemperature()
        {
            Console.WriteLine($"Notificando temperature del medio ambiente a {Name}");
        }
    }
}
