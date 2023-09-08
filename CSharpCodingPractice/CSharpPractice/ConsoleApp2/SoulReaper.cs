using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SoulReaper : Person
    {

        public SoulReaper()
        {
            base.Talk();
            Console.WriteLine("But I am also a Shinigami");
        }

        public override string ToString()
        {
            return "";
        }
        /// <summary>
        /// Override example from base class
        /// </summary>
        public override void Talk()
        {
            Console.WriteLine("Bankai!!");
        }
        /// <summary>
        /// Overload example. Different Params
        /// </summary>
        /// <param name="newString"></param>
        public void Talk(string newString)
        {
            Console.WriteLine(newString);
        }
    }
}
