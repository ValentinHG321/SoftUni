//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace EXAM
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            //white tiles seq



//            Stack<int> whiteTiles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

//            //gray tiles seq

//            List<int> inputGrayTiles = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

//            inputGrayTiles.Reverse();

//            Stack<int> grayTiles = new Stack<int>(inputGrayTiles);

//            //start from first gray == last white tile AREA => if == new LARGER TILE

//            int[] checkTable = new int[] { 40, 50, 60, 70 };

//            Dictionary<string, int> finalTiles = new Dictionary<string, int>();
//            finalTiles.Add("Sink", 0);
//            finalTiles.Add("Oven", 0);
//            finalTiles.Add("Countertop", 0);
//            finalTiles.Add("Wall", 0);
//            finalTiles.Add("Floor", 0);

//            int count = whiteTiles.Count;

//            for (int i = 0; i < count; i++)
//            {
//                if (whiteTiles.Count != 0 && grayTiles.Count != 0)
//                {
//                    int currentWhiteTile = whiteTiles.Peek();
//                    int currentGrayTile = grayTiles.Peek();
//                    int newLargeTile = 0;

//                    if (currentGrayTile == currentWhiteTile)
//                    {
//                        newLargeTile = currentWhiteTile + currentGrayTile;
//                        whiteTiles.Pop();
//                        grayTiles.Pop();
//                        if (checkTable.Contains(newLargeTile))
//                        {
//                            if (newLargeTile == checkTable[0])
//                            {
//                                finalTiles["Sink"] += 1;
//                            }
//                            else if (newLargeTile == checkTable[1])
//                            {
//                                finalTiles["Oven"] += 1;
//                            }
//                            else if (newLargeTile == checkTable[2])
//                            {
//                                finalTiles["Countertop"] += 1;
//                            }
//                            else if (newLargeTile == checkTable[3])
//                            {
//                                finalTiles["Wall"] += 1;
//                            }
//                        }
//                        else
//                        {
//                            finalTiles["Floor"] += 1;
//                        }
//                    }
//                    else
//                    {
//                        whiteTiles.Pop();
//                        grayTiles.Pop();
//                        currentWhiteTile = currentWhiteTile / 2;
//                        whiteTiles.Push(currentWhiteTile);
//                        grayTiles.Push(currentGrayTile);
//                    }
//                }
//            }

//            Console.WriteLine($"White tiles left: {whiteTiles.Count}");
//            Console.WriteLine($"Grey tiles left: {whiteTiles.Count}");
//            Console.WriteLine($"Floor: {finalTiles["Floor"]}");
//            Console.WriteLine($"Countertop: {finalTiles["Countertop"]}");
//            Console.WriteLine($"Oven: {finalTiles["Oven"]}");
//            Console.WriteLine($"Sink: {finalTiles["Sink"]}");
//            Console.WriteLine($"Wall: {finalTiles["Wall"]}");


//        }
//    }
//}
