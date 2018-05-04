using Ex03.GarageLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
    class Program
    {
        public static void Main()
        {
            Garage garage = new Garage();
            Console.WriteLine("Welcome to the garage");
            while (true)
            {
                Console.WriteLine("Eneter licenseNumber of car to create one!");
                string lisenceNumber = Console.ReadLine();
                try
                {
                    garage.AddNewVehicle(lisenceNumber);
                }
                catch(Exception e)
                {
                    Console.WriteLine("error!");
                }
            }
            Console.ReadLine();
        }
    }
}
