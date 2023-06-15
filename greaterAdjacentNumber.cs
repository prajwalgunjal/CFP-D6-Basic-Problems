﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Problem_D6
{
    public class greaterAdjacentNumber
    {
        public static bool ThreeIncreasingAdjacent(int[] arr)
        {
            bool found = false;
            for (int i = 1; i <= arr.Length - 2; i++)
            {
                if (arr[i - 1] + 1 == arr[i] && arr[i + 1] - 1 == arr[i])
                {
                    found = true;
                }
            }

            return found;
        }
    }
}
