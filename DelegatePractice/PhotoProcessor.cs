using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegatePractice
{
    public class PhotoProcessor
    {
        public void Process(string path)
        {
            var photo = Photo.load(path);
            var filter = new PhotoFilter();
            //filter.applyBrightness(photo);
            //filter.applyContrast(photo);
            //filter.applyResize(photo);
        }
    

       
    }
}
