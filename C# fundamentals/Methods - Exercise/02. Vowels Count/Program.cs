namespace _02._Vowels_Count
{
    class Program
    {
        static void Main()
        {
            VowelsCount();
        }

        static void VowelsCount()
        {
            string input = System.Console.ReadLine().ToLower();
            int count = 0;
            foreach (char currentChar in input)
            {
                switch (currentChar)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        count++;
                        break;
                }
            }
            System.Console.WriteLine(count);
        }
    }
}

