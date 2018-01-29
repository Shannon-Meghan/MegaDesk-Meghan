using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_MeghanShannon
{
    class DeskQuote
    {
        private decimal pwidth;
        private decimal pdepth;
        private int pnumDrawers;
        private string pmaterial;
        private int prushDays;

        public string customerName { get; set; }
        public DateTime quoteDate { get; set; }    

        public DeskQuote(decimal width, decimal depth, int numDrawers, string material, int rushDays)
        {
            /*
             * This class will define the attributes of a quote including Desk, rush days, 
             * customer name, and quote date. This class will also hold the logic in 
             * determining the line item cost.
             */
            pwidth = width;
            pdepth = depth;
            pnumDrawers = numDrawers;
            pmaterial = material;
            prushDays = rushDays;
        }

        public decimal surfaceAreaCost ()
        {
            //Determine if size of the desk is large enough for an additional charge
            
            return 1.0M;
        }
    }
}
