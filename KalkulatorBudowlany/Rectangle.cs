using System;
using System.Collections.Generic;
using System.Text;

namespace KalkulatorBudowlany
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Name = "Prostokat";
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return (Length * Width);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Dlugosc obiektu wynosi {Length} a szerokosc," +
                $"wynosi {Width}");
        }
    }
}
