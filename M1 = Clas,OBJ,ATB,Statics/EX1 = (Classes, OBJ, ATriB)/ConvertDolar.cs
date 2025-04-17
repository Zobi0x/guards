using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1____Classes__OBJ__ATriB_
{
    class ConvertDolar
    {
        
        public static double Convert(double ct, double cp)
        {
            double IOF = 6.0;
            double total = ct * cp;
            return total + (total * (IOF / 100.00));
        }
    }
}
