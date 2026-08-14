using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class TwoSum
    {
        public static int[]? FindTwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }
            return null;
        }
        public static int[]? FindTwoSumHashTable(int[] nums, int target)
        {
            Dictionary<int,int> compairedValue = new Dictionary<int,int>();
            for (int i = 0;i< nums.Length;i++)
            {
                int value=target- nums[i];
                if (compairedValue.ContainsKey(value))
                {
                    return new int[] { compairedValue[value], i };
                }
                compairedValue[nums[i]] = i;
            }

            return null;
        }
            public static void Main()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int target = 15;
            int[]? twosum= FindTwoSumHashTable(nums, target);
            if(twosum is not null )
            {
                Console.WriteLine("Result= {0}, {1}", twosum[0], twosum[1]);
            }
        }
    }
}
