using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class ReverseString
    {
        public static string Reverse(string str)
        {
            string result = "";
            if (str != null)
            {
                for (int i = str.Length-1; i >=0; i--)
                {
                    result += str[i];
                }
            }
            return result;
        }
        public static string ReverseSwap(string str)
        {
            char[] chars = str.ToCharArray();
            int i = 0;
            int j = str.Length-1;
            while(i<j)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
                i++;
                j--;
            }
            return new string(chars);
        }
        public static void Main()
        {
            string str = Console.ReadLine();
            string rev = Reverse(str);
            Console.WriteLine(rev);
            rev = new string(str.Reverse().ToArray());
            Console.WriteLine(rev);
            rev = ReverseSwap(str);
            Console.WriteLine(rev);
        }
    }
}
