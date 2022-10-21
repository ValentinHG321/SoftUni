using System;
using System.Linq;

namespace EXAM2
{
    public class Program
    {
        static void Main()
        {
            int nSizeWall = int.Parse(Console.ReadLine());

            char[,] wall = new char[nSizeWall, nSizeWall];
            int[] idxV = FillMatrixAndFindV(wall);

            int rowV = idxV[0];
            int colV = idxV[1];



            wall[rowV, colV] = '*';

            int holeCount = 0;
            bool hit = false;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                bool check = wall[rowV, colV] != '*'
                          && wall[rowV, colV] != 'R'
                          && wall[rowV, colV] != 'C';

                int rowVpreviousPos = rowV;
                int colVpreviousPos = colV;

                switch (command)
                {
                    case "up":
                        if (rowV - 1 > -1)
                        {
                            rowV -= 1;


                            if (check)
                            {
                                holeCount++;
                                wall[rowV, colV] = '*';
                            }


                        }
                        break;

                    case "down":
                        if (rowV + 1 < wall.GetLength(0))
                        {
                            rowV += 1;

                            if (check)
                            {
                                holeCount++;
                                wall[rowV, colV] = '*';
                            }

                        }
                        break;

                    case "left":
                        if (colV - 1 > -1)
                        {
                            colV -= 1;


                            if (check)
                            {
                                holeCount++;
                                wall[rowV, colV] = '*';
                            }

                        }
                        break;

                    case "right":
                        if (colV + 1 < wall.GetLength(1))
                        {
                            colV += 1;

                            if (check)
                            {
                                holeCount++;
                                wall[rowV, colV] = '*';
                            }

                        }
                        break;

                }


                if (wall[rowV, colV] == 'R')
                {
                    rowV = rowVpreviousPos;
                    colV = colVpreviousPos;
                }
                if (wall[rowV, colV] == 'C')
                {
                    wall[rowV, colV] = 'E';
                    holeCount++;
                    hit = true;
                    break;
                }
                PrintWall(wall);

            }
            if (!hit)
            {
                wall[rowV, colV] = 'V';
            }
            for (int row = 0; row < wall.GetLength(0); row++)
            {
                for (int col = 0; col < wall.GetLength(1); col++)
                {
                    Console.Write(wall[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static void PrintWall(char[,] wall)
        {
            for (int row = 0; row < wall.GetLength(0); row++)
            {
                for (int col = 0; col < wall.GetLength(1); col++)
                {
                    Console.Write(wall[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static void PrintV(int rowV , int colV)
        {
            Console.WriteLine($"row: {rowV} ; col: {colV}");
        }

        public static int[] FillMatrixAndFindV(char[,] multiArr)
        {
            int countRow = 0;
            int countCol = 0;
            int[] output = new int[2];
            

            for (int row = 0; row < multiArr.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < multiArr.GetLength(1); col++)
                {
                    multiArr[row, col] = rowData[col];
                    if (rowData.Contains('V'))
                    {
                        countCol = Array.IndexOf(rowData, 'V');
                        countRow = row;
                    }
                }
            }
            output[0] = countRow;
            output[1] = countCol;
            return output;
        }
    }

}

