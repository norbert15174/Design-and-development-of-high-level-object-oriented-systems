using ConsoleApp1.Homework;
using ConsoleApp1.HomeworkBasic;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*       List<Vehicle> myVehicles = new List<Vehicle>();
                   myVehicles.Add(new Train("Electric", 1000, "Pendolino"));
                   myVehicles.Add(new Plane("Electric", 1500, "Airbus"));
                   myVehicles.Add(new Car("Electric", 500, "Bmw"));
                   foreach(Vehicle e in myVehicles){
                       Console.WriteLine(e);
                   }
            */

            List<Crossbowman> listOfCrossbowmen = new List<Crossbowman>();
            List<Defender> listOfDefenders = new List<Defender>();
            List<Civilian> listOfCivilians = new List<Civilian>();

            listOfCrossbowmen.Add(new Crossbowman(10));
            listOfCrossbowmen.Add(new Crossbowman(15));
            listOfCrossbowmen.Add(new Crossbowman(20));

            listOfDefenders.Add(new Pikemen(30));
            listOfDefenders.Add(new Pikemen(20));
            listOfDefenders.AddRange(listOfCrossbowmen);

            listOfCivilians.Add(new Civilian(18));
            listOfCivilians.Add(new Civilian(8));

            Console.WriteLine("List of Crossbowmen: ");
            foreach(Crossbowman crossbowman in listOfCrossbowmen)
            {
                Console.WriteLine("\t" + crossbowman.ReadyToFight());
                Console.WriteLine("\t --------------------------------------------------------------------------");
            }
            Console.WriteLine("List of Defenders: ");
            foreach (Defender defender in listOfDefenders)
            {
                Console.WriteLine("\t" + defender.ReadyToFight());
                Console.WriteLine("\t --------------------------------------------------------------------------");
            }
            Console.WriteLine("List of Civilians: ");
            foreach (Civilian civil in listOfCivilians)
            {
                Console.WriteLine("\t" + civil.Eat() + "\t " + civil);
                Console.WriteLine("\t" + civil.EatSomeFood(5));
                Console.WriteLine("\t" + civil.EnoughFood());
                Console.WriteLine("\t --------------------------------------------------------------------------");
            }

        }
    }
}
