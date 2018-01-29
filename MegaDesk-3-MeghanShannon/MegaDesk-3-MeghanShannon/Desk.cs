using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_MeghanShannon
{
    class Desk
    {
        /*
         * This class will define the attributes of the desk object with width, depth, 
         * number of drawers, and the surface material may contain validation of those attribute values.
         */
        public decimal width { get; set; }
        public decimal depth { get; set; }
        public int numDrawers { get; set; }
        //public enum desktopMaterial { get; set; }
        public string desktopMaterial { get; set; }

    }
}
