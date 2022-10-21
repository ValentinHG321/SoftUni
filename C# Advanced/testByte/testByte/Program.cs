namespace testByte
{
    using System;
    internal class Program
    {
        static void Main()
        {

            string input = "|225.23:4.54|235.23:5.54|255.23:7.54";
            char[] chars = input.ToCharArray();

            byte[] data = new byte[14];
            byte[] volts = new byte[6];
            byte[] amps = new byte[16];

            foreach (byte s in input)
            {
                byte check = s;

                if (check == 124)
                {
                    for (int count1 = 0; count1 < 14; count1++)
                    {
                        data[count1] = (byte)chars[count1];
                    }
                }

                for (int count2 = 0; count2 < 14; count2++)
                {
                    int c = 0;

                    if (count2 < 6)
                    {
                        volts[count2] = data[count2];
                    }

                    if (count2 > 6)
                    {
                        amps[c] = data[count2];
                    }

                    if (c < 6)
                    {
                        c++;
                    }

                }


                for (int count4 = 0; count4 < 6; count4++)
                {
                    Console.WriteLine(volts[count4]);
                }

                Console.WriteLine(" <=> ");

                for (int count5 = 0; count5 < 6; count5++)
                {
                    Console.WriteLine(amps[count5]);
                }

                Console.WriteLine();
            }
        }
    }
}

