using System;
using System.Collections.Generic;
using System.Text;

namespace Forest_collab
{
    class TREE
    {
        private string GetType
        {
            get
            {
                int ratio = RandomNum(0, 4);
                if (ratio == 0)
                {
                    return "Norway Spruce";
                }
                else
                {
                    return "Nordmann Fir";
                }
            }
        }

        private int GetAge
        {
            get
            {
                int age = RandomNum(1, 250);
                return age;
            }
        }
        private bool GetDiseased
        {
            get
            {
                int ratio = RandomNum(1, 200);
                if (ratio == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private bool dove { get; set; }
        private bool river { get; set; }
        public TREE(bool _dove, bool _river)
        {
            dove = _dove;
            river = _river;

        }
        public int RandomNum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
