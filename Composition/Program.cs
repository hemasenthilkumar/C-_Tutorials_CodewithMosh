using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Dbmigrator(new Logger());
            var logger = new Logger();
            var inst = new Installer(logger);
            db.migrate();
            inst.Install();
            Console.ReadKey();
        }
    }
}
