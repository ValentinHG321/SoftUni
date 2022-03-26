using System;

namespace MidExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal pFlour = decimal.Parse(Console.ReadLine());
            decimal pEgg = decimal.Parse(Console.ReadLine());
            decimal pApron = decimal.Parse(Console.ReadLine());

            decimal p10Eggs = pEgg * 10;
            double moreAprons = Math.Ceiling(students * 1.2);
            decimal pMoreAprons = (decimal)moreAprons * pApron;
            int freeFlour = students / 5;
            decimal discountFloor = freeFlour * pFlour;
            decimal sum = (students * pFlour) + (p10Eggs * students) + pMoreAprons;
            sum -= discountFloor;

            if (sum <= budget)
            {
                Console.WriteLine($"Items purchased for {sum:F2}$.");
            }
            else
            {
                Console.WriteLine($"{sum - budget:F2}$ more needed.");
            }
        }
    }
}
