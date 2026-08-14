using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Palindrome
    {
        public static void Main()
        {
            string str = "madam";
            if(IsPalindrome(str))
            {
                Console.WriteLine(str+" is palindrome");
            }
            else
            {
                Console.WriteLine(str + " is not palindrome");
            }
        }
        static bool IsPalindrome(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);

            string reversed = new string(chars);

            return str == reversed;
        }
        private static bool CheckPalindrome(string str)
        {
            int i = 0;
            int j = str.Length-1;
            while (i < j)
            {
                if (str[i] != str[j])
                    return false;
                i++;
                j--;
            }
            return true;
        }
    }
}
