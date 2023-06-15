using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Problem_D6
{
    public class divideby2_3
    {
        public static int DivisibleBy2Or3(int a, int b)
        {
            if ((a % 2 == 0 && b % 2 == 0 || a % 3 == 0 && b % 3 == 0))
            {
                return a * b;
            }
            else
            {
                return a + b;
            }
        }

    }
}
