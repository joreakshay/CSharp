using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class BinarySearch
    {
        public static void Main()
        {
            int[] arr = { 0, 1, 2, 3, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int index = FindBS(arr, 10);
            Console.WriteLine(index);
        }

        public static int FindBS(int[] arr,int num)
        {            
            int start=0,end=arr.Length-1;           
            while(start<=end)
            {
                int mid = (start + end) / 2;
                if (arr[mid] == num)
                {
                    return mid;
                }
                else if (num < arr[mid])
                {
                    end = mid-1;
                }
                else if(num > arr[mid])
                {
                    start = mid+1;
                }
            }

            return -1;
        }
    }
}
