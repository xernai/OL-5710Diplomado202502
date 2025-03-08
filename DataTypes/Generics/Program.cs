using Entitities;
using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> alumnos = new List<string>();
            List<int> alumnos1 = new List<int>();
            List<FootballPlayer> foot = new List<FootballPlayer>();

            List<BaseballPlayer> baseball = new List<BaseballPlayer>();
            List<char> alumnos2 = new List<char>();

            // Compiladores:
            // Roselyn: traduce el codigo a IL (Intermediate Language)
            // RyuJit: traduce IL (Intermediate Language) a codigo nativo
            alumnos.Add("Ana");

            // Ventajas Generics
            // 1. nos permite que los tipos de datos sean seguros
            // 2. reutilizar el code

            // Structura de datos

            FootballPlayer footballPlayer = new FootballPlayer();

            footballPlayer.Name = "Juan";
            footballPlayer.Goals = 10;

            BaseballPlayer baseballPlayer = new BaseballPlayer();
            baseballPlayer.Name = "Pedro";
            baseballPlayer.GamesStarted = 5;

            // Formar equipo de Football
            //FootballTeam footballTeam = new FootballTeam(11);

            //footballTeam.CoachName = "Berizzo";
                    
            //footballTeam.Members[0] = footballPlayer;

            // Formar equipo de Baseball
            //BaseballTeam baseballTeam = new BaseballTeam(15);
            //baseballTeam.CoachName = "Manuel";
            //baseballTeam.Members[0] = baseballPlayer;


            //Console.WriteLine($"Nombre del coach de beisball: {baseballTeam.CoachName}");

            // Aplicando Generics para el equipo de football
            Team<FootballPlayer> footballTeamGen = new Team<FootballPlayer>(11);

            footballTeamGen.CoachName = "Berizzo";

            footballTeamGen.Members[0] = footballPlayer;

            Team<BaseballPlayer> baseballTeamGen = new Team<BaseballPlayer>(15);
            baseballTeamGen.CoachName = "Manuel";
            baseballTeamGen.Members[0] = baseballPlayer;

            Console.WriteLine($"Nombre del coach de beisball usando Generics: {baseballTeamGen.CoachName}");

            // Tennis
            TennisPlayer tennisPlayer = new TennisPlayer();
            tennisPlayer.Name = "Raúl Ramírez";

            // Equipo de Tennis
            Team<TennisPlayer> tennisTeamGen = new Team<TennisPlayer>(1);

            // Para evitar esto, se pone una restricción con el keyword "where" en la clase genérica llamada Team<T>
            // public class Team<T> where T : Athlete
            // Team<string> tennisTeamGen1;

            tennisTeamGen.CoachName = "José";

            tennisTeamGen.Members[0] = tennisPlayer;

            Console.WriteLine($"Nombre del coach de tennis usando Generics: {tennisTeamGen.CoachName}");
        }
    }
}
