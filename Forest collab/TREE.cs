using System;
using System.Collections.Generic;
using System.Text;

namespace Forest_collab
{
    class TREE
    {
        private bool Diseased { get; set; }
        private int GetAge
        {
            get
            {
                int age = RandomNum(1, 250);
                return age;
            }
        }
        private bool dove { get; set; }
        private bool river { get; set; }
        public TREE(bool _dove, bool _river, bool _diseased)
        {
            dove = _dove;
            river = _river;
            Diseased = _diseased;
        }
        public int RandomNum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
