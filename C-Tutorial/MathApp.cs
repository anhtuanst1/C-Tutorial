using System;
using System.Collections.Generic;
using System.Text;

namespace C_Tutorial
{
    class MathApp
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
            foreach (int num in nums)
            {
                if (Max <= num)
                {
                    Max = num;
                }
            }
            return Max;
        }

        //De qui
        public int GiaiThua(int num)
        {
            Console.WriteLine("\t num = {0}", num);
            int result;
            if (num==1)
            {
                result = 1;
            }
            else
            {
                result = GiaiThua(num - 1) * num;
            }
            return result;
        }
    }
}
