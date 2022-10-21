using System;

namespace _00.Demo
{
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double number { get; set; }
        public void SayName() => Console.WriteLine(this.Name);

        public static double Sqr(double number) => number * 2;
    }
}
