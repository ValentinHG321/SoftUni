using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte century = byte.Parse(Console.ReadLine());
            short year = (short)(century * 100);
            int days = (int)(year * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            Console.WriteLine($"{century} centuries = {year} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
