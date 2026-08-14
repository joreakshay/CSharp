using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{

    internal class FindDuplicate
    {
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5,5,5,5,4,2,4, };
            int[] duplicates=DuplicatesHashSet(arr);
            foreach(int i in duplicates)
            {
                Console.Write("{0}, ",i);
            }
            Console.WriteLine();
        }
        
        private static int[] DuplicatesHashSet(int[] arr)
        {
            HashSet<int> result = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();
            foreach (int item in arr)
            {
               if(! result.Add(item))
                {
                    duplicates.Add(item);
                }
            }
            return duplicates.ToArray();
        }
    }
}
