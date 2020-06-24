using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
        public void addhyperlink (string url)
        {
            Console.WriteLine("Hyperlink added:{0}", url);
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.width = 100;
            text.addhyperlink("www.google.com");
            Console.ReadKey();
        }

    }
}
