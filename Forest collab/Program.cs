using System;
using System.Collections.Generic;

namespace Forest_collab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Disease = false;
            for (int i = 0; i < 9999; i++)
            {
                int Random = RandomNum(0, 4);
                if (Random == 1)
                {
                    new NorwaySpruce(Doves(), River(), BugHotel(Disease), Diseased(Disease));
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("S");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    new NordmannFir(Doves(), River(), Diseased(Disease)); //SORT OUT THE RIVER THING 
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("F");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
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
        static bool River()
        {
            return true;
        }
        static int RandomNum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
