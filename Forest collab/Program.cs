using System;
using System.Collections.Generic;

namespace Forest_collab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Rainfall = new int[] { 75, 55, 65, 55, 50, 55, 55, 70, 70, 100, 105, 90 };
            string[] CampingDays = new string[] { "May", "June", "September" };
            int[] RiverDisplay = new int[] { 79, 80, 81, 82, 180, 181, 182, 183, 282, 283, 284, 285, 383, 384, 385, 386, 482, 483, 484, 485, 581, 582, 583, 584, 680, 681, 682, 683, 779, 780, 781, 878, 879, 880, 978, 979, 980, 1079, 1080, 1081, 1082, 1180, 1181, 1182, 1183, 1184, 1281, 1282, 1283, 1284, 1285, 1286, 1382, 1383, 1387, 1388, 1484, 1485, 1486, 1487, 1488, 1489, 1490, 1586, 1587, 1588, 1589, 1590, 1591, 1592, 1689, 1690, 1691, 1692, 1693, 1694, 1791, 1792, 1793, 1794, 1795, 1893, 1894, 1895, 1896, 1994, 1995, 1996, 1997, 2099, 2095, 2096, 2097, 2098, 2197, 2198, 2199, 2200, 2299, 2300}; //Makes the river
            bool Disease = false;
            string[] forest = new string[10201];
            for (int i = 0; i < 10201; i++)
            {
                int Random = RandomNum(0, 4);
                if (Random == 1)
                {
                    forest[i] = "S";
                    new NorwaySpruce(Doves(), River(i, RiverDisplay), BugHotel(Disease), Diseased(Disease), 0);
                }
                else
                {
                    new NordmannFir(Doves(), River(i, RiverDisplay), Diseased(Disease), RandomNum(0, 1)); //SORT OUT THE RIVER THING 
                    forest[i] = "F";
                }
            }
            for (int i = 0; i < 3700; i++)
            {
                for (int k = 0; k < 100; k++)
                {
                    if (RiverDisplay[k] == i)
                    {
                        forest[i] = "R";
                    }
                }
            }
            Forest(forest, Rainfall, CampingDays, RiverDisplay);
        }
        static void Forest(string[] forest, int[] Rainfall, string[] CampingDays, int[] RiverDisplay) //displays the forest
        {
            for (int j = 0; j < 24; j++)
            {
                for (int k = 0; k < 10201; k++)
                {
                    if (Doves() == true)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        if (forest[k] == "R")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(forest[k]);
                        }
                        else
                        {
                            Console.Write(forest[k]);
                        }
                    }
                    else if (k == 100)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(forest[k]);
                    }
                    else if (forest[k] == "F")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(forest[k]);
                    }
                    else if (forest[k] == "S")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(forest[k]);
                    }
                    else if (forest[k] == "M")
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(forest[k]);
                    }
                    else if (forest[k] == "R")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(forest[k]);
                    }
                    if (k % 100 == 0)
                    {
                        if (k == 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine();
                        }
                    }
                }
                Console.WriteLine();
                //DataForForest(Rainfall, CampingDays);
                Console.WriteLine("Press enter for next year");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static bool River(int i, int[] RiverDisplay) //Checks if a tree is on the river bank
        {
            bool river = false;
            for (int k = 1; k < 100; k++)
            {
                if (RiverDisplay[k] == i - 1 || RiverDisplay[k] == i + 1 || i == 2399 || i == 2400 || i == 78 || RiverDisplay[k] == i + 100 || RiverDisplay[k] == i - 100) //identifies the trees 
                {
                    river = true;
                }
            }
            return river;
        }
        static void AGETREE(int[] Age, string[] forest, int i)
        {
            RandomNum(10, 175);
        }
        static bool Doves()
        {
            int Ran = RandomNum(0, 49);
            if (Ran == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Diseased(bool Disease)
        {
            int Num = RandomNum(0, 200);
            if (Num == 0)
            {
                Disease = true;
                return true;
            }
            else
            {
                Disease = false;
                return false;
            }
        }
        static bool BugHotel(bool Disease)
        {
            if (Disease == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static int RandomNum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
