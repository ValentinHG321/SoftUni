using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double coinCount = 0;
            string start = Console.ReadLine();
            while (start != "Start")
            {

                double coins = double.Parse(start);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    coinCount += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                start = Console.ReadLine();
            }

            string end = Console.ReadLine();
            double cost = 0;
            bool check = true;
            while (end != "End")
            {
                switch (end)
                {
                    case "Nuts":    cost = 2.0; break;
                    case "Water":   cost = 0.7; break;
                    case "Crisps":  cost = 1.5; break;
                    case "Soda":    cost = 0.8; break;
                    case "Coke":    cost = 1.0; break;
                        default:
                        Console.WriteLine("Invalid product");
                        check = false;
                        break;
                }
                if (coinCount < cost)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    coinCount -= cost;
                    if (check)
                    {
                        Console.WriteLine($"Purchased {end.ToLower()}");
                    }
                    
                }
                end = Console.ReadLine();
                check = true;
                cost = 0;
            }
            Console.WriteLine($"Change: {coinCount:F2}");
        }
    }
}
