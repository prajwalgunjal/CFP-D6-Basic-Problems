using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Problem_D6
{
    public class swapTwoNos
    {
        public static string SwapTwoNumbers(int a, int b)
        {
            string before = $"Before: a = {a}, b = {b}; ";
            int temp;

            temp = b;
            b = a;
            a = temp;

            string after = $"After: a = {a}, b = {b}";
            return before + after;
        }
    }
}
