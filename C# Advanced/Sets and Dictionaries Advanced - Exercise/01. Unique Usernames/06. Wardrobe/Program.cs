﻿using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main()
        {

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string color = input.Split(" -> ")[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                Dictionary<string, int> clothes = wardrobe[color];
                string[] inputClothes = input.Split(" -> ")[1].Split(',');

                foreach (string cloth in inputClothes)
                {
                    if (!clothes.ContainsKey(cloth))
                    {
                        clothes.Add(cloth, 1);
                    }
                    else
                    {
                        clothes[cloth]++;
                    }
                }
            }

            string searchedItem = Console.ReadLine();
            string searchedColor = searchedItem.Split(' ')[0];
            string searchedCloth = searchedItem.Split(' ')[1];


            foreach (var colorEntry in wardrobe)
            {
                Console.WriteLine($"{colorEntry.Key} clothes:");
                Dictionary<string, int> clothes = colorEntry.Value;
                

                foreach (var cloth in clothes)
                {
                    if (cloth.Key == searchedCloth && colorEntry.Key == searchedColor)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
