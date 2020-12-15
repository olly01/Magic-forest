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
            int[] RiverDisplay = new int[] { 179, 180, 181, 182, 180, 181, 182, 183, 382, 383, 384, 385, 383, 384, 385, 386, 582, 583, 584, 585, 581, 582, 583, 584, 780, 781, 782, 783, 779, 780, 781, 978, 979, 980, 978, 979, 980, 1179, 1180, 1181, 1182, 1180, 1181, 1182, 1183, 1184, 1381, 1382, 1383, 1384, 1385, 1386, 1382, 1383, 1387, 1388, 1584, 1585, 1586, 1587, 1588, 1589, 1590, 1586, 1587, 1588, 1589, 1590, 1591, 1592, 1789, 1790, 1791, 1792, 1793, 1794, 1791, 1792, 1793, 1794, 1795, 1993, 1994, 1995, 1996, 1994, 1995, 1996, 1997, 2199, 2195, 2196, 2197, 2198, 2397, 2398, 2399, 2500, 2599, 2700, 2799, 2900 }; //Makes the river
            bool Disease = false;
            string[] forest = new string[10099];
            for (int i = 0; i < 10099; i++)
            {
                int Random = RandomNum(0, 4);
                if (Random == 1)
                {
                    new NorwaySpruce(Doves(), River(i, RiverDisplay), BugHotel(Disease), Diseased(Disease));
                    forest[i] = "S";
                }
                else
                {
                    new NordmannFir(Doves(), River(i, RiverDisplay), Diseased(Disease)); //SORT OUT THE RIVER THING 
                    forest[i] = "F";
                }
            }
            for (int i = 1; i < 2500; i++)
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
                for (int k = 0; k < 9999; k++)
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
                    if (k % 200 == 0)
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
                if (RiverDisplay[k] == i - 1 || RiverDisplay[k] == i + 1 || i == 2399 || i == 2400)
                {
                    river = true;
                }
            }
            return river;
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
