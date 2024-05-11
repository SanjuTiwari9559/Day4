using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PhotoProcessor processor = new PhotoProcessor();
            //Photo photo= new Photo();
             var ph=   Photo.load("Samkjhgfd");
                    
           // processor.Process("fxdfcjhtdfghg");
            PhotoFilter filter = new PhotoFilter();
            Action<Photo> action = filter.applyBrightness;
            action(ph);



           


            //Console.WriteLine(filterAction);



        }
    }
}
