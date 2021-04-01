using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_1.Classes
{
    public static class GlobalClass
    {
        public static string formatNumber(this object numberObject)
        {
            double result = double.NaN;
            if(double.TryParse(numberObject.ToString(), out result))
            {
                return result.ToString("N0");
            }
            return "NAN";
        }
    }
}
