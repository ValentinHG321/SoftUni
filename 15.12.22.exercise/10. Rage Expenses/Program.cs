using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostCount = int.Parse(Console.ReadLine());
            double headsetP = double.Parse(Console.ReadLine());
            double mouseP = double.Parse(Console.ReadLine());
            double keyBP = double.Parse(Console.ReadLine());
            double displayP = double.Parse(Console.ReadLine());
            

            int brokenHeadsets = lostCount / 2;
            int brokenMouses = lostCount / 3;
            int brokenKeyB = lostCount / 6;
            int brokenDisplays = lostCount / 12;

            double expense = (headsetP * brokenHeadsets) + (mouseP * brokenMouses) + (keyBP * brokenKeyB) + (displayP * brokenDisplays);
            Console.WriteLine($"Rage expenses: {expense:F2} lv.");
        }
    }
}
