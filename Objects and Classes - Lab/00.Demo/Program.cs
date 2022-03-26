using System;

namespace _00.Demo
{
    class Program
    {
        private static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Maria";
            firstCat.Age = 5;
            firstCat.Weight = 5.4;

            Console.WriteLine($"Name: {firstCat.Name} Age: {firstCat.Age}");

            Cat secondCat = new Cat()
            {
                Name = "Maca",
                Age = 6,
                Weight = 33.2
            };
            
            secondCat.SayName();

            if (IsOverweight(secondCat.Weight))
            {
                Console.WriteLine("It's MASSIVE!!!");
            }
            else
            {
                Console.WriteLine("IT'S puny");
            }
            double n = Cat.Sqr(2);
        }
        static bool IsOverweight(double weight) => weight > 10;
    }
}
