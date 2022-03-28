using System;
using System.Collections.Generic;
using System.Text;

namespace KalkulatorBudowlany
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
            Name = "Kolo";
        }

        public override double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2.0));
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Promien kola wynosi {Radius}");
        }
    }
}
