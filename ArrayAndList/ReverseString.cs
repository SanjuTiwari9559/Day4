using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndList
{
    internal class ReverseString
    {
        public static void reverse(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine(" you have enter Empty string so please enter the string");
            }
                string reverse = "";
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    reverse += s[i];
                }
                Console.WriteLine(reverse);
            }

        }
    }

