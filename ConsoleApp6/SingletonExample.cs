using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class SingletonExample
    {
        private static SingletonExample instance = null;

        public static SingletonExample Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SingletonExample();
                }
                return instance;
            }
        }

        public void DoSomethingA()
        {
            Console.WriteLine("Did something A");
        }
        private void DoSomethingB()
        {
            Console.WriteLine("Did something B");
        }
        
    }
}
