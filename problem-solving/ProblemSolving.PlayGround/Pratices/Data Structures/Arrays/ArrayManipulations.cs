using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.PlayGround
{
    public static class ArrayManipulations
    {
        public static int FindSecondLargeInArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;

            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max2 = max1;
                    max1 = i;
                }
                else if (i >= max2 && i != max1)
                {
                    max2 = i;
                }
            }
            return max2;
        }
    }
}
