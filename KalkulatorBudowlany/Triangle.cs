using System;
using System.Collections.Generic;
using System.Text;

namespace KalkulatorBudowlany
{
    class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sidea, double sideb, double sidec)
        {
            Name = "Trojkat";
            SideA = sidea;
            SideB = sideb;
            SideC = sidec;
        }

        public override double Area()
        {
            return (SideA + SideB + SideC);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Dlugosc boku A trojkata wynosi {SideA} " +
                $"dlugosc boku B trojkata wynosi {SideB} a dlugosc boku C trojkata wynosi {SideC}");
        }
    }
    
}
