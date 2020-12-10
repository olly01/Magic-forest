using System;
using System.Collections.Generic;
using System.Text;

namespace Forest_collab
{
    class NorwaySpruce : TREE
    {
        public bool BugHotel { get; set; }
        public NorwaySpruce(bool _dove, bool _river, bool _BugHotel) : base(_dove, _river)
        {
            BugHotel = _BugHotel;
        }
    }
}
