using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money =double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaber = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belt = double.Parse(Console.ReadLine());

            int beltcount = (students / 6);
            double beltdisc = beltcount * belt;
            double TotalcostItems = (lightsaber * Math.Ceiling(students * 1.1)) + (belt*students) + (robes * students);
            TotalcostItems -= beltdisc;

            if (TotalcostItems <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {TotalcostItems:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {TotalcostItems - money:F2}lv more.");
            }

        }
    }
}
