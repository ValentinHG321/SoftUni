using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            if (   RuleDigits(input) == "DigitsPass" 
                && RuleLD(input)     == "LettersPass" 
                && RuleLength(input) == "LengthPass")
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (RuleLength(input) != "LengthPass")
                {
                    Console.WriteLine(RuleLength(input));
                }
                if (RuleLD(input) != "LettersPass")
                {
                    Console.WriteLine(RuleLD(input));
                }
                if (RuleDigits(input) != "DigitsPass")
                {
                    Console.WriteLine(RuleDigits(input));
                }
            }
            

        }

        static string RuleLength(string inputLenght)
        {
            inputLenght = inputLenght.ToLower();
            if (inputLenght.Length >= 6 && inputLenght.Length <= 10)
            {
                return inputLenght = "LengthPass";
            }
            else
            {
                return inputLenght = "Password must be between 6 and 10 characters";
            }
        }

        static string RuleLD(string inputLD)
        {
            inputLD = inputLD.ToLower();
            bool check = true;
            foreach (char ch in inputLD)
            {
                if (ch <= 47 || ch >= 58 && ch <= 96 || ch >= 123)
                {
                    check = false;
                    break;
                }
            }
            if (check)
            {
                return inputLD = "LettersPass";
            }
            else
            {
                return inputLD = "Password must consist only of letters and digits";
            }

        }

        static string RuleDigits(string inputDigits)
        {
            int count = 0;
            foreach (char ch in inputDigits)
            {
                if (ch >= 48 && ch <= 57)
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return inputDigits = "DigitsPass";
            }
            else
            {
                return inputDigits = "Password must have at least 2 digits";
            }
        }
    }
}
