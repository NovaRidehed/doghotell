using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doghotell
{
    internal class Meal
    {
        public int hourOfDay;
        public string foodType;

        public Meal (int hOD, string fT)
        {
            hourOfDay = hOD;
            foodType = fT;
        }
    }
}
