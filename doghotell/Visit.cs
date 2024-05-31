using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doghotell
{
    internal class Visit
    {
        public DateTime dropoffTime;
        public DateTime pickupTime;

        public Visit(DateTime dropoffTime, DateTime pickupTime)
        {
            this.dropoffTime = dropoffTime;
            this.pickupTime = pickupTime;
        }
    }
}
