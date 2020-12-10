using System;
using System.Collections.Generic;
using System.Text;

namespace Forest_collab
{
    class Maple : TREE
    {
        public int AmountMapleTapped { get; set; }
        public Maple(bool _dove, bool _river, int _AmountMapleTapped, bool _diseased) : base(_dove, _river, _diseased)
        {
            AmountMapleTapped = _AmountMapleTapped;
        }
    }
}
