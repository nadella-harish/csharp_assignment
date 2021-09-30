using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Circle
    {
        double radius;

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public double GetRadius()
        {
            return radius;
        }

        public double CalcDiameter()
        {
            return 2 * radius;
        }

        public double CalcArea()
        {
            return Math.PI * radius * radius;
        }

    }

    class CircleTest
    {
        public static void Main()
        {
            Circle c1 = new Circle();
            c1.SetRadius(2);

            Console.WriteLine(c1.GetRadius());
            Console.WriteLine(c1.CalcDiameter());
            Console.WriteLine(c1.CalcArea());
            Circle c2 = new Circle();
            c2.SetRadius(4);

            Console.WriteLine(c2.GetRadius());
            Console.WriteLine(c2.CalcDiameter());
            Console.WriteLine(c2.CalcArea());

        }
    }
}