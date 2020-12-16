using System;
using System.Collections.Generic;
using System.Text;

namespace Forest_collab
{
    class Beavers : Animals
    {
        public int NumberEaten { get; set; }
        public Beavers(int _population, int _age) : base(_population, _age)
        {

        }
    }
}
