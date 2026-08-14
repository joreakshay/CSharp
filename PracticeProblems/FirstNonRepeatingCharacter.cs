using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class FirstNonRepeatingCharacter
    {
        public static void Main()
        {
            string str = "aabbccddeeffggghhhx";
            char ch= FindNonRepeatingCharacter(str);
            if (ch == '\0')
            {
                Console.WriteLine("No non-repeating character");
            }
            else
            {
                Console.WriteLine(ch);
            }
        }

        private static char FindNonRepeatingCharacter(string str)
        {
            Dictionary<char,int> map = new Dictionary<char,int>();
            foreach (char c in str)
            {
                if (map.ContainsKey(c))
                    map[c]++;
                else
                    map[c] = 1;
            }
            foreach (char c in str)
            {
                if (map[c] == 1)
                    return c;
            }
            return '\0';
        }
    }
}
