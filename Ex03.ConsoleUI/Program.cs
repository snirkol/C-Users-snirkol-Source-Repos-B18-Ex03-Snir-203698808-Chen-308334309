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
                Console.WriteLine("1. Enter Vehicle to the garage");
                Console.WriteLine("2. Get List of all vehicle by type");
                Console.WriteLine("3. Chenge exist vehicle status");
                Console.WriteLine("4. Refule vehicle");
                Console.WriteLine("5. Charge electrice vehicle");
                Console.WriteLine("6. Vehicle detail");

                string lisenceNumber = Console.ReadLine();
                try
                {
                    garage.AddNewVehicle(lisenceNumber);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine("Vehicle already exist in the Garage!");
                }
                catch(Exception e)
                {
                    Console.WriteLine("error!");
                }
            }
        }
    }
}
