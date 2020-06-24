 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CodewithMosh
{
    class Program
    {
        public class Person
        {
            public string Name;
            public void Introduce(string to)
            {
                Console.WriteLine("Hi {0} I am {1}", to, Name);
            }
            public static Person Parse(string str)
            {
                var p = new Person();
                p.Name = str;
                return p;
            }
        }
        static void Main(string[] args)
        {
            var p = Person.Parse("Vasanth");
            p.Introduce("Hema");
           
            Console.ReadKey();
        }
    }
}
