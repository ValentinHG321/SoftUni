using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carsList = new List<Car>();

            for (int i = 1; i <= n; i++)
            {
                string data = Console.ReadLine();
                string model = data.Split()[0];
                double fuelAmount = double.Parse(data.Split()[1]);
                double fuelConsumption = double.Parse(data.Split()[2]);

                Car car = new Car (model, fuelAmount, fuelConsumption);
                carsList.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string carModel = command.Split()[1];
                double amountOfKm = double.Parse(command.Split()[2]);

                Car carToDrive = carsList.First(car => car.Model == carModel);
                carToDrive.Drive(amountOfKm);

                command = Console.ReadLine();
            }

            foreach (Car car in carsList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
