using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public Car ( string brand , string model , int horsePower)
        {
            this.Brand = brand;
            this.Model= model;
            this.HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }

        public int HorsePower { get; set; }
    }
    class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalogObject = new Catalog();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] splitParams = command.Split('/',StringSplitOptions.RemoveEmptyEntries);

                string type = splitParams[0];
                string brand = splitParams[1];
                string model = splitParams[2];
                int powerOrWeight = int.Parse(splitParams[3]);

                if (type == "Car")
                {
                    Car newCar = new Car(brand , model , powerOrWeight);
                    catalogObject.Cars.Add(newCar);
                }
                if (type == "Truck")
                {
                    Truck newTruck = new Truck(brand , model , powerOrWeight);
                    catalogObject.Trucks.Add(newTruck);
                }
                command = Console.ReadLine();

            }

            if (catalogObject.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                List<Car> orderedCars = catalogObject.Cars.OrderBy(car => car.Brand).ToList();
                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }

            }

            if (catalogObject.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                List<Truck> orederedTrucks = catalogObject.Trucks.OrderBy(truck => truck.Model).ToList();
                foreach (Truck truck in orederedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
