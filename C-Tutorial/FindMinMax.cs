using System;
using System.Collections.Generic;
using System.Text;

namespace C_Tutorial
{
    class FindMinMax
    {
        public int FindMin(int[] nums)
        {
            int Min = nums[0];
            foreach (int num in nums)
            {
                if (Min >= num)
                {
                    Min = num;
                }
            }
            return Min;
        }

        public int FindMax(int[] nums)
        {
            int Max = nums[0];
            foreach(int num in nums)
            {
                if (Max <= num)
                {
                    Max = num;
                }
            }
            return Max;
        }
    }
}
