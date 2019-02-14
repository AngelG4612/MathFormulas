using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormulas
{
    class Program
    {
        static void Main(string[] args)
        {
            double R;
            double Pie = Math.PI;
            double Area, Circ, Diam;




            Console.Write("what is the radius of the circle? ");
            R = double.Parse(Console.ReadLine());
            Area = Pie * R * R;
            Circ = 2 * Pie * R;
            Diam = R * R;

            Console.WriteLine("Radius: {0}, Area: {1}, Crircumference: {2}", R, Area, Circ);
            Console.ReadLine();


            

            Console.Write("What is the radius of the Hemisphere? ");
            R = double.Parse(Console.ReadLine());

            double Volume = ((2.0 / 3.0) * (Math.PI * (R * R * R)));

            Console.WriteLine("Radius: {0}, Volume: {1}", R, Volume);
            Console.ReadLine();

            double A, B, C;

            Console.Write("What is the length of 'a'? ");
            A = double.Parse(Console.ReadLine());

            Console.Write("What is the length of 'b'? ");
            B = double.Parse(Console.ReadLine());

            Console.Write("What is the length of 'c'? ");
            C = double.Parse(Console.ReadLine());

            double P = (A + B + C) / 2;


            Area = Math.Sqrt(P * (P - A) * (P - B) * (P - C));

            Console.WriteLine("length 'a': {0}, lenght 'b': {1}, length 'c': {2}, Half of the Circumference is: {3}, the Area is: {4}.", A, B, C, P, Area);


            Console.ReadLine();


            A = 1;
            B = 4;
            C = -21;
            double x = (-B + Math.Sqrt((B * B) - (4 * A * C))) / 2 * A;
            double x2 = (-B - Math.Sqrt((B * B) - (4 * A * C))) / 2 * A;


            Console.Write("the answer for the quadratic formula for given variable A=1, B=4, C=-21 is: X={0} or X={1}", x, x2);
            Console.ReadLine();
        }
    }
}
