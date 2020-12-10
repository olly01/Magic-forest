using System;

namespace Forest_collab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Disease = false;
            int Random = RandomNum(0, 4);
            for (int i = 0; i < 9999; i++)
            {
                if (Random == 0)
                {
                    new NordmannFir(Doves(), River(), Diseased(Disease)); //SORT OUT THE RIVER THING 
                }
                else
                {
                    new NorwaySpruce(Doves(), River(), BugHotel(Disease), Diseased(Disease));
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
                Disease = false;
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
