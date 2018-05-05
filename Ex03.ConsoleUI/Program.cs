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
            Console.WriteLine("Welcome to the garage!");
            while (true)
            {
                Console.WriteLine("1. Enter Vehicle to the garage");
                Console.WriteLine("2. Get List of all vehicle's license number by status");
                Console.WriteLine("3. Change exist vehicle status");
                Console.WriteLine("4. blowup all tires to max");
                Console.WriteLine("5. Refule vehicle");
                Console.WriteLine("6. Charge electrice vehicle");
                Console.WriteLine("7. Vehicle detail");
                Console.WriteLine("8. To exit");

                Console.Write("Select your option: ");

                int selectedOption;
                bool resultOfParse = int.TryParse(Console.ReadLine(), out selectedOption);
                while(!resultOfParse)
                {
                    Console.WriteLine("Invalid input\nSelect your option: ");
                    resultOfParse = int.TryParse(Console.ReadLine(), out selectedOption);
                }
                switch(selectedOption)
                {
                    case 1:
                        {
                            Console.Write("LisenceNumber: ");
                            string lisenceNumber = Console.ReadLine();
                            bool isVehicleExist = garage.IsVehicleExist(lisenceNumber);
                            if(!isVehicleExist)
                            {
                                Console.Write("Type: ");
                                string vehicleType = Console.ReadLine();
                                Console.Write("Model Name: ");
                                string modelName = Console.ReadLine();
                                Console.Write("Percentage Of Energy Remaining: ");
                                float percentageOfEnergyRemaining;
                                bool result = float.TryParse(Console.ReadLine(), out percentageOfEnergyRemaining);
                                while (!result)
                                {
                                    Console.Write("Invalid! percentage Of Energy Remaining: ");
                                    result = float.TryParse(Console.ReadLine(), out percentageOfEnergyRemaining);
                                }

                                Console.Write("Manufacturer Name: ");
                                string manufacturerName = Console.ReadLine();
                                Console.Write("Current Air Pressure: ");
                                float currentAirPressure;
                                result = float.TryParse(Console.ReadLine(), out currentAirPressure);

                                while (!result)
                                {
                                    Console.Write("Invalid! Current Air Pressure: ");
                                    result = float.TryParse(Console.ReadLine(), out currentAirPressure);
                                }

                                Console.Write("Owner Name: ");
                                string ownerName = Console.ReadLine();

                                Console.Write("Owner telephone: ");
                                string ownerTelephone = Console.ReadLine();

                                Console.Write("enter more details (split with space): ");
                                string moreDetails = Console.ReadLine();

                                garage.AddNewVehicle(vehicleType, lisenceNumber, modelName, percentageOfEnergyRemaining, currentAirPressure,
                                    manufacturerName, ownerName, ownerTelephone, moreDetails);
                            }

                            else
                            {
                                garage.ChangeVehicleRepairStatus(lisenceNumber, eRepairStatus.InProcess);
                            }

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
                                allVehiclesInGarage = garage.GetAllVehiclesLisenceNumber();
                            }
                            else
                            {
                                allVehiclesInGarage = garage.GetAllVehiclesLisenceNumber((eRepairStatus)repairStatus);
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
                            Console.Write("Lisence number:");
                            string lisenceNumber = Console.ReadLine();
                            Console.Write("New status:");
                            string newStatusString = Console.ReadLine();
                            eRepairStatus? newStatus = castStatus(newStatusString);
                            bool isVehicleExist = garage.IsVehicleExist(lisenceNumber);

                            while (!isVehicleExist)
                            {
                                Console.WriteLine("The license number is not exist in the garage, please enter again");
                                lisenceNumber = Console.ReadLine();
                                isVehicleExist = garage.IsVehicleExist(lisenceNumber);
                            }

                            while (newStatus == null)
                            {
                                Console.Write("Invalid status\nplease enter InProgress/Fixed/Paid: ");
                                newStatusString = Console.ReadLine();
                                newStatus = castStatus(newStatusString);

                            }

                            garage.ChangeVehicleRepairStatus(lisenceNumber, (eRepairStatus)newStatus);

                            break;
                        }

                    case 4:
                        {
                            Console.Write("Lisence number: ");
                            string lisenceNumber = Console.ReadLine();
                            bool isVehicleExist = garage.IsVehicleExist(lisenceNumber);

                            while (!isVehicleExist)
                            {
                                Console.Write("The license number is not exist in the garage\nLisence number:");
                                lisenceNumber = Console.ReadLine();
                                isVehicleExist = garage.IsVehicleExist(lisenceNumber);
                            }

                            garage.BlowUpAllTireToMax(lisenceNumber);

                            break;
                        }

                    case 5:
                        {
                            Console.Write("Lisence number: ");
                            string lisenceNumber = Console.ReadLine();
                            Console.Write("Type of fuel (Octan95/Octan96/Octan98/Soler): ");
                            string typeFuelString = Console.ReadLine();
                            eTypeFuel? typeFuel = caseTypeFuel(typeFuelString);
                            Console.Write("Quantity to fill in liters:");
                            float quantityOfFuel;
                            bool result = float.TryParse(Console.ReadLine(), out quantityOfFuel);

                            bool isExistVehicle = garage.IsVehicleExist(lisenceNumber);
                            while (!isExistVehicle)
                            {
                                Console.Write("The license number is not exist in the garage\nLisence number:");
                                lisenceNumber = Console.ReadLine();
                                isExistVehicle = garage.IsVehicleExist(lisenceNumber);
                            }

                            while (!result)
                            {
                                Console.Write("Invalid quantity to fill, Quantity to fill in liters: ");
                                result = float.TryParse(Console.ReadLine(), out quantityOfFuel);
                            }

                            while (typeFuel == null)
                            {
                                Console.Write("Invalid type fuel, Type of fuel (Octan95/Octan96/Octan98/Soler): ");
                                typeFuelString = Console.ReadLine();
                                typeFuel = caseTypeFuel(typeFuelString);
                            }

                            garage.RefuleVehicle(lisenceNumber, (eTypeFuel)typeFuel, quantityOfFuel);

                            break;

                        }


                    case 6:
                        {
                            Console.Write("Lisence number: ");
                            string lisenceNumber = Console.ReadLine();
                            Console.Write("Time to charging: ");
                            float timeToCharging;
                            bool result = float.TryParse(Console.ReadLine(), out timeToCharging);

                            bool isExistVehicle = garage.IsVehicleExist(lisenceNumber);
                            while(!isExistVehicle)
                            {
                                Console.Write("The license number is not exist in the garage\nLisence number:");
                                lisenceNumber = Console.ReadLine();
                                isExistVehicle = garage.IsVehicleExist(lisenceNumber);
                            }

                            while (!result)
                            {
                                Console.Write("Invalid quantity to fill, please enter again: ");
                                result = float.TryParse(Console.ReadLine(), out timeToCharging);
                            }

                            garage.ChargeVehicle(lisenceNumber, timeToCharging);

                            break;
                        }

                    case 7:
                        {
                            Console.Write("Lisence number: ");
                            string lisenceNumber = Console.ReadLine();
                            bool isExistVehicle = garage.IsVehicleExist(lisenceNumber);
                            while (!isExistVehicle)
                            {
                                Console.Write("The license number is not exist in the garage\nLisence number:");
                                lisenceNumber = Console.ReadLine();
                                isExistVehicle = garage.IsVehicleExist(lisenceNumber);
                            }

                            string vehicleDetails = garage.GetVehicleDetail(lisenceNumber);
                            Console.WriteLine(vehicleDetails);
                            break;
                        }

                    case 8:
                        {
                            break;
                        }
                }
                Console.WriteLine("");
            }

        }

        private static eRepairStatus? castStatus(string i_status)
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

        private static eTypeFuel? caseTypeFuel(string i_TypeFuel)
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
