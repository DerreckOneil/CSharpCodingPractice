using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MainTest
    {
        public static void Main(string[]args)
        {
            Person person = new Person();
            person.Talk();

            SoulReaper ichigo = new SoulReaper();
            ichigo.Talk();
            ichigo.Talk("Tensa Zangetsu");
        }
    }
}
