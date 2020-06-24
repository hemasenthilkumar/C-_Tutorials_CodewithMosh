using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    public class PresentationObject
    {
        public int width { get; set; }
        public int Height { get; set; }
        public void Copy()
        {
            Console.WriteLine("Copied");
        }
        public void Duplicate()
        {
            Console.WriteLine("duplicated");
        }
    }
}
 