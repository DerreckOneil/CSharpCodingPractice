using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    internal class StructPractice
    {
        /*
        public static void Main(string[]args)
        {
            Coords coords = new Coords(3, 4);
            Console.WriteLine(coords.ToString());
            Console.WriteLine(coords.DoubleIt(coords).ToString());

            Coords coords2 = new Coords(2, 2);
            coords2.DoubleIt2(coords2);
            Console.WriteLine(coords2.ToString());
        }
        */

        
    }

    public struct Coords
    {

        private int X, Y;

        public int XCoodinate => X;
        public int YCoodinate => Y;

        public Coords(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// This method will interally change the params within the object itself. 
        /// </summary>
        /// <param name="coords"></param>
        public void DoubleIt2(Coords coords)
        {
            this.X = coords.X *2;
            this.Y = coords.Y *2;

        }
        /// <summary>
        /// This method will return new params without applying said params to the object itself.
        /// </summary>
        /// <param name="coords"></param>
        /// <returns></returns>
        public Coords DoubleIt(Coords coords)
        {
            int newX = coords.X *2;
            int newY = coords.Y *2;

            return new Coords(newX, newY);
        }
        public override string ToString() => $"[{X},{Y}]";
    }
}
