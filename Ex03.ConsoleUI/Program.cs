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
            Console.WriteLine("Welcome to the garage\nSelect your option:");
            while (true)
            {
                Console.WriteLine("1. Enter Vehicle to the garage");
                Console.WriteLine("2. Get List of all vehicle's license number by status");
                Console.WriteLine("3. Change exist vehicle status");
                Console.WriteLine("4. blowup all tires to max");
                Console.WriteLine("5. Refule vehicle");
                Console.WriteLine("6. Charge electrice vehicle");
                Console.WriteLine("7. Vehicle detail");

                int selectedOption;
                bool resultOfParse = int.TryParse(Console.ReadLine(), out selectedOption);
                while(!resultOfParse)
                {
                    Console.WriteLine("Invalid input\nSelect your option:");
                    resultOfParse = int.TryParse(Console.ReadLine(), out selectedOption);
                }
                switch(selectedOption)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter lisenceNumber");
                            string lisenceNumber = Console.ReadLine();
                            bool isVehicleExist = garage.IsVehicleExist(lisenceNumber);
                            if(!isVehicleExist)
                            {
                                Console.WriteLine("Enter details of vehicle");
                                string vehicleDetails = Console.ReadLine();
                                garage.AddNewVehicle(lisenceNumber);
                            }
                            garage.enterVehicleToGarage(lisenceNumber);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("if you want to filter results press status(InProgress/Fixed/Paid), to show all press other input");
                            string status = Console.ReadLine();
                            eRepairStatus repairStatus;
                            List<string> allVehiclesInGarage;
                            switch(status)
                            {
                                case "InProgress":
                                    {
                                        repairStatus = eRepairStatus.InProcess;
                                        allVehiclesInGarage = garage.GetAllVehiclesInGarage(repairStatus);
                                        break;
                                    }
                                case "Fixed":
                                    {
                                        repairStatus = eRepairStatus.Fixed;
                                        allVehiclesInGarage = garage.GetAllVehiclesInGarage(repairStatus);
                                        break;
                                    }

                                case "Paid":
                                    {
                                        repairStatus = eRepairStatus.Paid;
                                        allVehiclesInGarage = garage.GetAllVehiclesInGarage(repairStatus);
                                        break;
                                    }
                                default:
                                    {
                                        allVehiclesInGarage = garage.GetAllVehiclesInGarage();
                                        break;
                                    }
                            }

                            if(allVehiclesInGarage.Count != 0)
                            {
                                Console.WriteLine("List of vehicle's lisence numbers:");
                                foreach (string number in allVehiclesInGarage)
                                {
                                    Console.WriteLine(number);
                                }
                            }

                            else
                            {
                                Console.WriteLine("There is no vehicles in the garage");
                            }

                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Enter lisence number and new status");
                            string lisenceNumber = Console.ReadLine();
                            string newStatus = Console.ReadLine();
                            bool isVehicleExist = garage.IsVehicleExist(lisenceNumber);
                            if(isVehicleExist)
                            {
                                garage.ChangeStatus(lisenceNumber, newStatus);

                            }
                            else
                            {
                                Console.WriteLine("The license number is not exist in the garage");
                            }

                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Enter vehicle's lisence number");
                            string lisenceNumber = Console.ReadLine();
                            bool isVehicleExist = garage.IsVehicleExist(lisenceNumber);

                            if(isVehicleExist)
                            {
                                garage.BlowUpAllTires(lisenceNumber);
                            }

                            else
                            {
                                Console.WriteLine("The license number is not exist in the garage");
                            }

                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Enter vehicle's lisence number, type of fuel(Octan95/Octan96/Octan98/Soler) and quantity to fill in liters");
                            string lisenceNumber = Console.ReadLine();
                            string typeFuelString = Console.ReadLine();
                            eTypeFuel typeFuel;
                            float quantityOfFuel;

                            bool isExistVehicle = garage.IsVehicleExist(lisenceNumber);
                            if (isExistVehicle)
                            {
                                bool result = float.TryParse(Console.ReadLine(), out quantityOfFuel);
                                while (!result)
                                {
                                    Console.WriteLine("Invalid quantity to fill, please enter again");
                                    result = float.TryParse(Console.ReadLine(), out quantityOfFuel);
                                }

                                bool isValidTypeFuel = false;
                                while (!isValidTypeFuel)
                                {
                                    switch (typeFuelString)
                                    {
                                        case "Octan95":
                                            {
                                                typeFuel = eTypeFuel.Octan95;
                                                isValidTypeFuel = true;
                                                break;
                                            }
                                        case "Octan96":
                                            {
                                                typeFuel = eTypeFuel.Octan96;
                                                isValidTypeFuel = true;
                                                break;
                                            }
                                        case "Octan98":
                                            {
                                                typeFuel = eTypeFuel.Octan98;
                                                isValidTypeFuel = true;
                                                break;
                                            }
                                        case "Soler":
                                            {
                                                typeFuel = eTypeFuel.Soler;
                                                isValidTypeFuel = true;
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Invalid type fuel, please enter Octan95/Octan96/Octan98/Soler");
                                                typeFuelString = Console.ReadLine();
                                                break;
                                            }
                                    }
                                }

                                garage.Refuel(lisenceNumber, typeFuel, quantityOfFuel);
                            }
                            else
                            {
                                Console.WriteLine("The license number is not exist in the garage");
                            }

                            break;
                        }

                    case 6:
                        {
                            Console.WriteLine("Enter vehicle's lisence number and time to charging");
                            string lisenceNumber = Console.ReadLine();
                            float timeToCharging;
                            bool result = float.TryParse(Console.ReadLine(), out timeToCharging);

                            bool isExistVehicle = garage.IsVehicleExist(lisenceNumber);
                            if(isExistVehicle)
                            {
                                while (!result)
                                {
                                    Console.WriteLine("Invalid quantity to fill, please enter again");
                                    result = float.TryParse(Console.ReadLine(), out timeToCharging);
                                }

                                garage.ChargeBattery(lisenceNumber, timeToCharging);
                            }

                            else
                            {
                                Console.WriteLine("The license number is not exist in the garage");
                            }

                            break;
                        }

                    case 7:
                        {
                            break;
                        }
                }
            }
        }
    }
}
