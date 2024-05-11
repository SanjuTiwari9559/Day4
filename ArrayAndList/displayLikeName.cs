using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArrayAndList
{
    public class displayLikeName

    {
        public static void displayName()
        {
            List<string> list = new List<string>();
            while (true)
            {
                Console.WriteLine("Type a name (or hit ENTER to quit):");
                var name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    break;
                }
                list.Add(name);

            }
            if (list.Count > 2)
            {
                //Console.WriteLine(" {0},{1} and {2} other Like your Post", list[0], list[1], list.Count - 2);
                Console.WriteLine($"{list[0]},{list[1]} and {list.Count - 2} other Like your Post");

            }
            else
            {
                if (list.Count == 2)
                {
                    //Console.WriteLine("{0},{1} like your post", list[0], list[1]);
                    Console.WriteLine($"{list[0]},{list[1]} like your post");
                }

                else
                {
                    if (list.Count == 1)
                    {
                        // Console.WriteLine("{0} like your post", list[0]);
                        Console.WriteLine($"{list[0]} like your post");
                    }
                    else
                    {
                        Console.WriteLine("No one like your post ");

                    }
                }
            }
        }
    }
}
