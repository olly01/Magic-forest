using System;
using System.Collections.Generic;
using System.Text;

namespace Forest_collab
{
    class TREE
    {
        private string type;
        private int age;
        private bool diseased;
        private bool dove;
        private bool river;


        public TREE(bool _diseased, bool _dove, bool _river)
        {
            type = typeb();
            age = ageb();
            diseased = diseasedb();
            dove = _dove;
            river = _river;

        }
        public string typeb()
        {
            int Blha = RandomNum(0, 4);
            bool ryftg;
            if (Blha == 0)
            {
                ryftg = true;
            }

            else
            {
                ryftg = false;
            }

            if (ryftg = true)
            {
                type = "spruce";
            }
            else
            {
                type = "north tree";
            }
            return type;
        }

        public int ageb()
        {
            age = RandomNum(1, 250);
            return age;
        }

        public int RandomNum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public bool diseasedb()
        {
            int ratio = RandomNum(1, 200);
            bool disease;
            if (ratio == 1)
            {
                disease = true;
            }
            else
            {
                disease = false;
            }
            return disease;
        }
    

    }
}
