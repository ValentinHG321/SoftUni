using System;
using System.Collections.Generic;
using System.Linq;

namespace EXAM
{
    internal class Program
    {
        static void Main()
        {
            //white tiles seq

            List<int> inputWhiteTiles = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            inputWhiteTiles.Reverse();

            Queue<int> whiteTiles = new Queue<int>(inputWhiteTiles);

            //gray tiles seq
            Queue<int> grayTiles = new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            //start from first gray == last white tile AREA => if == new LARGER TILE

            int[] checkTable = new int[] { 40, 50, 60, 70 };

            Dictionary<string, int> finalTiles = new Dictionary<string, int>();
            finalTiles.Add("Sink", 0);
            finalTiles.Add("Oven", 0);
            finalTiles.Add("Countertop", 0);
            finalTiles.Add("Wall", 0);
            finalTiles.Add("Floor", 0);

            int a = Array.IndexOf(checkTable, 40);

            int count = whiteTiles.Count;

            while (whiteTiles.Count != 0 && grayTiles.Count != 0)
            {
                if (whiteTiles.Count != 0 && grayTiles.Count != 0)
                {
                    int currentWhiteTile = whiteTiles.Peek();
                    int currentGrayTile = grayTiles.Peek();
                    int newLargeTile = 0;

                    if (currentGrayTile == currentWhiteTile)
                    {
                        newLargeTile = currentWhiteTile + currentGrayTile;
                        whiteTiles.Dequeue();
                        grayTiles.Dequeue();
                        if (checkTable.Contains(newLargeTile))
                        {
                            if (newLargeTile == checkTable[0])
                            {
                                finalTiles["Sink"] += 1;
                            }
                            else if (newLargeTile == checkTable[1])
                            {
                                finalTiles["Oven"] += 1;
                            }
                            else if (newLargeTile == checkTable[2])
                            {
                                finalTiles["Countertop"] += 1;
                            }
                            else if (newLargeTile == checkTable[3])
                            {
                                finalTiles["Wall"] += 1;
                            }
                        }
                        else
                        {
                            finalTiles["Floor"] += 1;
                        }
                    }
                    else
                    {
                        whiteTiles.Dequeue();
                        grayTiles.Dequeue();
                        currentWhiteTile = currentWhiteTile / 2;
                        List<int> reverse = new List<int>(whiteTiles);
                        reverse.Reverse();
                        reverse.Add(currentWhiteTile);
                        reverse.Reverse();
                        whiteTiles = new Queue<int>(reverse);
                        grayTiles.Enqueue(currentGrayTile);
                    }
                }
            }
            string whiteTilesString = string.Empty;
            if (whiteTiles.Count > 0)
            {
                whiteTilesString = string.Join(", ", whiteTiles);
            }
            else
            {
                whiteTilesString = "none";
            }
            string grayTilesString = string.Empty;
            if (grayTiles.Count > 0)
            {
                grayTilesString = string.Join(", ", grayTiles);
            }
            else
            {
                grayTilesString = "none";
            }

            Console.WriteLine($"White tiles left: {whiteTilesString}");
            Console.WriteLine($"Grey tiles left: {grayTilesString}");

            if (finalTiles["Floor"] > 0)
            {
                Console.WriteLine($"Floor: {finalTiles["Floor"]}");
            }
            if (finalTiles["Countertop"] > 0)
            {
                Console.WriteLine($"Countertop: {finalTiles["Countertop"]}");
            }
            if (finalTiles["Oven"] > 0)
            {
                Console.WriteLine($"Oven: {finalTiles["Oven"]}");
            }
            if (finalTiles["Sink"] > 0)
            {
                Console.WriteLine($"Sink: {finalTiles["Sink"]}");
            }
            if (finalTiles["Wall"] > 0)
            {
                Console.WriteLine($"Wall: {finalTiles["Wall"]}");
            }
        }
    }
}
