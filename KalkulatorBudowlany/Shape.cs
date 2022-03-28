using System;
using System.Collections.Generic;
using System.Text;

namespace KalkulatorBudowlany
{
    abstract class Shape
    {
        public string Name { get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine($"To jest {Name}");
        }

        public abstract double Area();
    }
}
