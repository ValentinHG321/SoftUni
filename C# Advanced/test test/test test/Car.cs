using System;
using System.Collections.Generic;
using System.Text;

namespace test_test
{
    public abstract class Car:ICar
    {
        private string color;
        private int hp;
        private double fuel;
        private double distance;

        public Car(string color, int hp, double fuel , double distance)
        {
            this.Color = color;
            this.HP = hp;
            this.Fuel = fuel;
            this.Distance = distance;
        }

        public string Color { get; set; }
        public int HP { get; set; }
        public double Fuel { get; set; }
        public double Distance 
        {
            get 
            {
                return this.distance; 
            } 
            set 
            {

                if (this.distance < 0)
                {
                    throw new ArgumentException("Stop");

                }
                this.distance = value;

            } 
        }
        public void Drive(double distance)
        {
            this.distance += distance;
        }
       public void CheckDistance(double traveledDistance)
        {
            Drive(traveledDistance);
            if (1000 - this.Distance < 0)
            {
                Console.WriteLine("Give me FUEL");
                Console.WriteLine(1000 - this.Distance); 
            }
            else
            {
                Console.WriteLine(1000 - this.Distance);
            }
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }




}
