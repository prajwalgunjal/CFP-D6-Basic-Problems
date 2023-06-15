using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Problem_D6
{
    public class positivenegzero
    {
        public static string PositiveNegativeOrZero(double num)
        {
            if (num > 0.0)
            {
                return "Positive";
            }
            else if (num < 0.0)
            {
                return "Negative";
            }

            return "Zero";
        }
    }
}
