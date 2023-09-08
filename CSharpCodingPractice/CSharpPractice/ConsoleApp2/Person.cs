using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Person
    {

        private string name;
        private int age;

        private int ssn; 

        public Person()
        {

        }

        public string MyName => name;
        public int MyAge => age;
        public int Myssn => ssn;

        public virtual void Talk()
        {
            Console.WriteLine("I am a human");
        }
    }
}
