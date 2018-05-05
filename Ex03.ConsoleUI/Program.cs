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
                            garage.ChangeVehicleRepairStatus(lisenceNumber, eRepairStatus.InProcess);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("if you want to filter results press status(InProgress/Fixed/Paid), to show all press other input");
                            string status = Console.ReadLine();
                            eRepairStatus? repairStatus = castStatus(status);
                            List<string> allVehiclesInGarage;
                            if(repairStatus == null)
                            {
                                allVehiclesInGarage = garage.GetAllVehicles();
                            }
                            else
                            {
                                allVehiclesInGarage = garage.GetAllVehicles((eRepairStatus)repairStatus);
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
                            string newStatusString = Console.ReadLine();
                            eRepairStatus? newStatus = castStatus(newStatusString);
                            while (newStatus == null)
                            {
                                Console.WriteLine("Invalid status, please enter InProgress/Fixed/Paid");
                                newStatusString = Console.ReadLine();
                                newStatus = castStatus(newStatusString);

                            }

                            bool isVehicleExist = garage.IsVehicleExist(lisenceNumber);
                            if(isVehicleExist)
                            {
                                garage.ChangeVehicleRepairStatus(lisenceNumber, (eRepairStatus)newStatus);

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
                                garage.BlowUpAllTireToMax(lisenceNumber);
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
                            eTypeFuel? typeFuel = caseTypeFuel(typeFuelString); 
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

                                while (typeFuel == null)
                                {
                                    Console.WriteLine("Invalid type fuel, please enter Octan95/Octan96/Octan98/Soler");
                                    typeFuelString = Console.ReadLine();
                                    typeFuel = caseTypeFuel(typeFuelString);
                                }

                                 garage.RefuleVehicle(lisenceNumber, (eTypeFuel)typeFuel, quantityOfFuel);
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

                                garage.ChargeVehicle(lisenceNumber, timeToCharging);
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

        public static eRepairStatus? castStatus(string i_status)
        {
            eRepairStatus? o_repairStatus = null;

            switch (i_status)
            {
                case "InProgress":
                    {
                        o_repairStatus = eRepairStatus.InProcess;
                        break;
                    }
                case "Fixed":
                    {
                        o_repairStatus = eRepairStatus.Fixed;
                        break;
                    }

                case "Paid":
                    {
                        o_repairStatus = eRepairStatus.Paid;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            return o_repairStatus;
        }

        public static eTypeFuel? caseTypeFuel(string i_TypeFuel)
        {
            eTypeFuel? o_typeFuel;
            switch (i_TypeFuel)
            {
                case "Octan95":
                    {
                        o_typeFuel = eTypeFuel.Octan95;
                        break;
                    }
                case "Octan96":
                    {
                        o_typeFuel = eTypeFuel.Octan96;
                        break;
                    }
                case "Octan98":
                    {
                        o_typeFuel = eTypeFuel.Octan98;
                        break;
                    }
                case "Soler":
                    {
                        o_typeFuel = eTypeFuel.Soler;
                        break;
                    }
                default:
                    {
                        o_typeFuel = null;
                        break;
                    }
            }

            return o_typeFuel;

        }
    }
}
