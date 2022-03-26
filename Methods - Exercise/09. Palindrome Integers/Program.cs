using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main()
        {
            string input;
            string[] outputArr;
            string output = string.Empty;
            int count = 0;
            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(Palidrome(input));
            }
            //outputArr = output.Split(' ');
            //Console.WriteLine(string.Join('\n' , outputArr));
            
        }

        static string Palidrome(string input)
        {
            string isFalse = "false";
            string isTrue = "true";
            string reversed = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            if (reversed == input)
            {
               return isTrue;
            }

            return isFalse;
        }
    }
}
