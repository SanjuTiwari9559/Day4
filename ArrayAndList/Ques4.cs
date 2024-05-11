using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndList
{
    internal class Ques4
    {
        public static void printUnique()
        {
            List<int> list = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter the number or Quit");
                var number=Console.ReadLine();
                 if(number.ToLower()=="quit" )
                {
                    break;
                }
                else
                {
                    list.Add(Convert.ToInt32(number));
                }


            }
            list.Sort();
            for(int i=0;i<list.Count-1; i++)
            {
                if (list[i] != list[i+1])
                {
                    Console.Write(list[i]);
                }
                
            }
            Console.Write(list[list.Count-1]);

        }
    }
}
