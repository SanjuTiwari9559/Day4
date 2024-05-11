using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    //public delegate void filterAction(Photo photo);
    public class PhotoFilter
    {
        public  void applyBrightness(Photo photo)
        {
            Console.WriteLine("This is use to apply Brigthness");
        }
        public  void applyContrast(Photo photo)
        {
            Console.WriteLine("This is use to apply Contract");
        }
        public void applyResize(Photo photo)
        {
            Console.WriteLine("This is use to Resize the photo");
        }
    }
}
