using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToObjects
{
    public class User
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
    }

    public class Bill
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
    }
    public class Alumno
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Nota { get; set; }
        public Alumno(string nombre, int edad, double nota)
        {
            Nombre = nombre;
            Edad = edad;
            Nota = nota;
        }
        public override string ToString()
        {
            return Nombre + " - " + Edad + " - " + Nota;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int>();
            values.Add(1);
            values.Add(2);

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            // LINQ: Language Integrated Query
            // 1. Query Syntax
            // 2. Method Syntax

            var users = new List<User>(){
                        new User(){ Id = 1, Active = true,  Name = "Andres"},
                        new User(){ Id = 2, Active = true,  Name = "Arturo"},
                        new User(){ Id = 3, Active = true,  Name = "Andrea"},
                        new User(){ Id = 4, Active = false, Name = "Ivan"}
                    };

            var bills = new List<Bill>(){
                            new Bill(){ Id = 1, UserId = 1, Amount = 100 },
                            new Bill(){ Id = 2, UserId = 2, Amount = 10 },
                            new Bill(){ Id = 3, UserId = 3, Amount = 1000 },
                            new Bill(){ Id = 4, UserId = 4, Amount = 5 },
                            new Bill(){ Id = 5, UserId = 1, Amount = 1000 },
                            new Bill(){ Id = 6, UserId = 1, Amount = 10 },
                            new Bill(){ Id = 7, UserId = 1, Amount = 10000 },
                            new Bill(){ Id = 8, UserId = 2, Amount = 1 },
                            new Bill(){ Id = 9, UserId = 2, Amount = 100 },
                            new Bill(){ Id = 10, UserId = 3, Amount = 10 }
            };

            // deferred execution
            //var usersActive = (from u in users
            //                   join b in bills
            //                   on u.Id equals b.UserId
            //                   where u.Active != false && b.Amount < 10
            //                   orderby u.Name, b.Amount descending
            //                   select new
            //                   {
            //                       u.Id,
            //                       u.Name,
            //                       b.Amount
            //                   });

            // immediate execution
            var usersActive = (from u in users
                               join b in bills
                               on u.Id equals b.UserId
                               where u.Active != false && b.Amount < 10
                               orderby u.Name, b.Amount descending
                               select new
                               {
                                   u.Id,
                                   u.Name,
                                   b.Amount
                               }).ToList();

            Console.WriteLine("Id    Name    Amount");

            foreach (var user in usersActive)
            {
                Console.WriteLine("{0}   {1}  {2}", user.Id, user.Name, user.Amount);
            }
        }
    }
}
