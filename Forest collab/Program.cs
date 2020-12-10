using System;

namespace Forest_collab
{
    class Program
    {
        static void Main(string[] args)
        {
            int Random = RandomNum(0, 4);
            for (int i = 0; i < 9999; i++)
            {
                if (Random == 0)
                {
                    new NordmannFir(Doves(), River()); //SORT OUT THE RIVER THING

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
