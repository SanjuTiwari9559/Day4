using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndList
{
    public  class UniqueNumber
    {
        public static void displayUniqueNumber()
        {
           
            List<int> list = new List<int>();
            while (list.Count <= 4)
            {
                Console.WriteLine("Enter the number");
                int number = Convert.ToInt32(Console.ReadLine());
                if(list.Count==0)
                {
                    list.Add(number);
                }
                else
                {
                    bool unique = true;
                    for (int i=0;i<list.Count; i++)
                    {

                        if (list[i]==number)
                        {
                            Console.WriteLine("Please ReEnter the Unique number");
                            unique = false;
                            break;
                        }
                     
                       
                      
                    }
                    if(unique)
                    {
                        list.Add(number);
                    }
                }
            }
             list.Sort();
            foreach (int i in list)
            {
                Console.Write(i+" ");
            }

        }
    }
}
