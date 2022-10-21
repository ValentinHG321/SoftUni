using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars = new List<Car>();
        private int capacity;


        public Parking(int capacity)
        {
            this.Capacity = capacity;
            this.Cars = new List<Car>();
        }
        public Parking(List<Car> cars, int capacity) : this(capacity)
        {
            this.Cars = new List<Car>();
            this.Cars = cars;
        }

        public string AddCar(Car Car)
        {
            string result = $"";
            Car currentCar = Car;
            bool carFound = false;
            this.Cars = cars;

            if (this.Cars.Contains(Car))
            {
                carFound = true;
                result = "Car with that registration number, already exists!";
            }
            else if (this.Cars.Count() >= this.Capacity)
            {
                result = "Parking is full!";
            }
            else
            {
                this.Cars.Add(currentCar);
                result = $"Successfully added new car {currentCar.Make} {currentCar.RegistrationNumber}";
            }
            return result;
        }
        public string RemoveCar(string RegistrationNumber)
        {
            string result = "";
            bool carFound = false;
            for (int i = 0; i < this.Cars.Count; i++)
            {
                if (this.Cars[i].RegistrationNumber == RegistrationNumber)
                {
                    carFound = true;
                    this.Cars.RemoveAt(i);
                    result = $"Successfully removed {RegistrationNumber}";
                    break;
                }
            }
            if (!carFound)
            {
                result = $"Car with that registration number, doesn't exist!";
            }
            return result;
        }
        public Car GetCar(string RegistrationNumber)
        {
            Car currentCar = new Car("", "", 0, "");
            foreach (var car in this.Cars)
            {
                if (car.RegistrationNumber == RegistrationNumber)
                {
                    currentCar = car;
                    break;
                }
            }
            return currentCar;
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                if (RegistrationNumbers.Contains(this.Cars[i].RegistrationNumber))
                {
                    this.Cars.RemoveAt(i);
                    i--;
                }
            }
        }
        public List<Car> Cars
        {
            get { return cars; }
            set { this.cars = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { this.capacity = value; }
        }
        public int Count
        {
            get { return cars.Count; }
            set { this.Count = cars.Count; }
        }
    }
}