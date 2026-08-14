using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class ValidParentheses
    {
        public static void Main()
        {
            Console.WriteLine(IsValid("()"));      // True
            Console.WriteLine(IsValid("()[]{}"));  // True
            Console.WriteLine(IsValid("(]"));      // False
            Console.WriteLine(IsValid("([)]"));    // False
            Console.WriteLine(IsValid("{[]}"));    // True
        }
        public static bool IsValid(string text)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < text.Length; i++)
            {
                char c= text[i];
                if (c=='('|| c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if(stack.Count == 0)
                        return false;
                    char top= stack.Pop();
                    if((c==')'&&top!='(')||
                        (c == '}' && top != '{')||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return !stack.Any();
        }
    }
}
