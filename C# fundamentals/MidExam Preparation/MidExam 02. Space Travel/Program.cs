using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExam_02._Space_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int fuel = int.Parse(Console.ReadLine());
            int ammo = int.Parse(Console.ReadLine());
            string command = string.Empty;
            int number = 0;


            for (int i = 0; i < input.Count; i++)
            {


                if (i % 2 == 0)
                {
                    command = input[i];
                    number = 0;
                    if (command == "Titan")
                    {
                        Console.WriteLine("You have reached Titan, all passengers are safe.");
                        return;
                    }
                }
                else
                {
                    number = int.Parse(input[i]);
                }

                if (i % 2 != 0)
                {
                    switch (command)
                    {
                        case "Travel":
                            int travel = number;
                            if (fuel > travel)
                            {
                                fuel -= travel;
                                Console.WriteLine($"The spaceship travelled {travel} light-years.");
                            }
                            else
                            {
                                Console.WriteLine("Mission failed.");
                                return;
                            }
                            break;

                        case "Enemy":
                            int armor = number;
                            if (ammo >= armor)
                            {
                                ammo -= armor;
                                Console.WriteLine($"An enemy with {armor} armour is defeated.");
                            }
                            else if (ammo < armor)
                            {
                                fuel -= armor * 2;
                                if (fuel >= 0)
                                {
                                    Console.WriteLine($"An enemy with {armor} armour is outmaneuvered.");
                                }
                                else
                                {
                                    Console.WriteLine("Mission failed.");
                                    return;
                                }
                            }
                            break;

                        case "Repair":
                            fuel += number;
                            ammo += number * 2;
                            Console.WriteLine($"Ammunitions added: {number * 2}.");
                            Console.WriteLine($"Fuel added: {number}.");
                            break;

                    }
                }
            }

        }
    }




}
