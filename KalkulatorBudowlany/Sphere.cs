using System;
using System.Collections.Generic;
using System.Text;

namespace KalkulatorBudowlany
{
    class Sphere : Shape
    {
        public double Radius { get; set; }
        public Sphere(double radius)
        {
            Radius = radius;
            Name = "Kula";
        }

        public override double Area()
        {
            return 4.0 / 3 * Math.PI * (Math.Pow(Radius, 3.0));
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Promien kuli wynosi {Radius}");
        }
    }
}
