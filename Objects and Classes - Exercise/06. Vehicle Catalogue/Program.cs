using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Vehicle
    {
        public Vehicle(string type, string model, string color, double hp)
        {
            Type = type;
            Model = model;
            Color = color;
            HP = hp;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HP { get; set; }

        public override string ToString()
        {
            {
                string vehicleStr = $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                                    $"Model: {this.Model}{Environment.NewLine}" +
                                    $"Color: {this.Color}{Environment.NewLine}" +
                                    $"Horsepower: {this.HP}";

                return vehicleStr;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Vehicle> listVehacle = new List<Vehicle>();
                double averageCarHp = 0;
                double averageTruckHp = 0;
                double sumCar = 0;
                double sumTruck = 0;
                int countCar = 0;
                int countTruck = 0;

                while (true)
                {
                    string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                    if (input[0] == "End")
                    {
                        break;
                    }

                    string typeOfVehicle = input[0];
                    string model = input[1];
                    string color = input[2];
                    double horsePower = double.Parse(input[3]);

                    listVehacle.Add(new Vehicle(typeOfVehicle, model, color, horsePower));
                }

                //while (true)
                //{

                //    string secontInput = Console.ReadLine();
                //    if (secontInput == "Close the Catalogue")
                //    {
                //        averageCarHp = sumCar / countCar;
                //        averageTruckHp = sumTruck / countTruck;
                //        break;
                //    }

                //    Vehicle searchedVehicle = listVehacle.FirstOrDefault(t => t.Model == secontInput);
                //    if (searchedVehicle.Type == "car")
                //    {
                //        double horsePower = searchedVehicle.HP;
                //        sumCar += horsePower;
                //        countCar++;
                //    }
                //    if (searchedVehicle.Type == "truck")
                //    {
                //        double horsePower = searchedVehicle.HP;
                //        sumTruck += horsePower;
                //        countTruck++;
                //    }

                //    Console.WriteLine(searchedVehicle);
                //}

                while (true)
                {

                    string secontInput = Console.ReadLine().Trim();

                    if (secontInput == "Close the Catalogue")
                    {
                        break;
                    }

                    Console.WriteLine(listVehacle.Find(x => x.Model == secontInput));
                }


                foreach (Vehicle vehicle in listVehacle)
                {

                    if (vehicle.Type == "car")
                    {
                        countCar++;
                        sumCar += vehicle.HP;
                    }
                    if (vehicle.Type == "truck")
                    {
                        countTruck++;
                        sumTruck += vehicle.HP;
                    }

                }
                if (sumCar == 0)
                {
                    averageCarHp = 0;
                }
                else
                {
                    averageCarHp = sumCar / countCar;
                }
                if (sumTruck == 0)
                {
                    averageTruckHp = 0;
                }
                else
                {
                    averageTruckHp = sumTruck / countTruck;
                }

                Console.WriteLine($"Cars have average horsepower of: {averageCarHp:F2}.");


                Console.WriteLine($"Trucks have average horsepower of: {averageTruckHp:F2}.");


            }
        }
    }
}
