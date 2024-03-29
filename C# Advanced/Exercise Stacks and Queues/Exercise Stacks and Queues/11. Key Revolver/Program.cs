﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    internal class Program
    {
        private static void Main()
        {
            var priceBullet = int.Parse(Console.ReadLine());
            var sizeOfGunBarrel = int.Parse(Console.ReadLine());
            var bullets = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            var locks = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            var valueOfIntelligence = int.Parse(Console.ReadLine());
            var usedBullets = 0;

            while (bullets.Any() && locks.Any())
            {
                var currentBulletSize = bullets.Pop();
                usedBullets++;

                if (currentBulletSize > locks.Peek())
                {
                    Console.WriteLine("Ping!");
                }
                else
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }

                if (usedBullets % sizeOfGunBarrel == 0 && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                }
            }

            if (locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                var profit = valueOfIntelligence - usedBullets * priceBullet;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${profit}");
            }
        }
    }
}
