using System;
using System.Collections.Generic;
using System.Text;

namespace Forest_collab
{
    class TREE
    {
        private bool Diseased { get; set; }
        private int Age { get; set; }
        private bool dove { get; set; }
        private bool river { get; set; }
        public TREE(bool _dove, bool _river, bool _diseased, int _age)
        {
            dove = _dove;
            river = _river;
            Diseased = _diseased;
            Age = _age;
        }
        public int RandomNum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
