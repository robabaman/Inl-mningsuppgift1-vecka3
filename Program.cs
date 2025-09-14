using Inlämningsuppgift1_vecka3;
using System;
using static Inlämningsuppgift1_vecka3.Bil;

namespace Inlämningsuppgift1_vecka3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** OOP Projekt om två elbilar***\n");


            // Bil 1


            Tesla vehicle1 = new Tesla();
            vehicle1.Car(); // Polymorfism

            Vehicle tesla = new Vehicle();
            tesla.Fast(); // Arv

            Color teslaColor = new Color();
            teslaColor.teslaColor(); // Arv

            Bil elbil = new Elbil();
            elbil.Starta();
            elbil.Stanna(); // Abstraktion

            User user1 = new User("Robert");
            Console.WriteLine($"Användarens namn är: {user1.Name}\n"); // Inskapsling


            // Bil 2

            Tesla vehicle2 = new Opel();
            vehicle2.Car(); // Polymorfism

            Vehicle tesla2 = new Vehicle();
            tesla2.Slow(); // Arv

            Color opelColor = new Color();
            opelColor.opelColor(); // Arv

            Bil elbil2 = new Elbil();
            elbil2.Starta();
            elbil2.Stanna(); // Abstraktion

            User user2 = new User("Nemo");
            Console.WriteLine($"Användarens namn är: {user2.Name}"); // Inskapsling


        }
    }
}
