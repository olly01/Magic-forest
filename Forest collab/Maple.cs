using System;
using System.Collections.Generic;
using System.Text;

namespace Forest_collab
{
    class Maple : TREE
    {
        public int AmountMapleTapped { get; set; }
        public Maple(bool _dove, bool _river, int _AmountMapleTapped, bool _diseased, int _age) : base(_dove, _river, _diseased, _age)
        {
            AmountMapleTapped = _AmountMapleTapped;
        }
    }
}
