using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area
        {
            get { return 3.14 * Radius * Radius; }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"circle area = {Area}");
        }
    }
}
