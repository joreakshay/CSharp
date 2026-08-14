using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class MergeSortedArrays
    {

        public static void Main()
        {
            int[] array1 = { 1, 3, 4, 7, 10, 11,  14,  16, 17, 19, 20 };
            int[] array2 = { 2, 5, 6, 8, 9, 12, 13, 15, 18,22,23,24,30};
            int[] array3 = MergeArrays(array1, array2);
            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write("{0}, ", array3[i]);
            }
            Console.WriteLine();
        }

        private static int[] MergeArrays(int[] array1, int[] array2)
        {
            int[] mergearray= new int[array1.Length+array2.Length];
            int i=0,j=0,k=0;
            while(i < array1.Length && j<array2.Length)
            {
                if (array1[i] <= array2[j])
                {
                    mergearray[k++] = array1[i];
                    i++;
                }
                else
                {
                    mergearray[k++] = array2[j];
                    j++;
                }
            }
            while (i < array1.Length)
            {
                mergearray[k++] = array1[i];
                i++;
            }
            while (j < array2.Length)
            {
                mergearray[k++] = array2[j];
                j++;
            }
            return mergearray;
        }
    }
}
