using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace KalkulatorBudowlany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Witaj w kalkulatorze budowlanym, wpisz co chcesz policzyc," +
                " Objetosc czy Pole?\n");
            string decyzja = Console.ReadLine();
            if (decyzja.ToLower() == "pole")
            {
                Console.Clear();
                Console.WriteLine("Zdecyduj, pole ktorej figury chcesz obliczyc,\n" +
                    "wpisz: PKolo, PProstokat lub PTrojkat");
                string text = Console.ReadLine();
                if (text.ToLower() == "pkolo")
                {
                    Console.Clear();
                    Console.WriteLine("Wprowadz promien kola");
                    double Wprowadz = Convert.ToDouble(Console.ReadLine());
                    Shape[] shapes = { new Circle(Wprowadz) };
                    foreach (Shape s in shapes)
                    {
                        s.GetInfo();
                        Console.WriteLine("Pole {0} wynosi : {1:f2}",
                            s.Name, s.Area());

                        Circle testCirc = s as Circle;
                        if (testCirc == null)
                        {
                            Console.WriteLine("To nie jest kolo");
                        }

                        if (s is Circle)
                        {
                            Console.WriteLine("To nie jest prostokat");
                        }
                        Console.WriteLine("Nacisnij dowolny przycisk aby wyjsc...");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }

                    Console.ReadLine();

                }
                if (text.ToLower() == "pprostokat")
                {
                    Console.Clear();
                    Console.WriteLine("Wprowadz dlugosc boku A i po Enterze dlugosc boku B");
                    double Wprowadz1 = Convert.ToDouble(Console.ReadLine());
                    double Wprowadz2 = Convert.ToDouble(Console.ReadLine());
                    Shape[] shapes = { new Rectangle(Wprowadz1, Wprowadz2) };
                    foreach (Shape s in shapes)
                    {
                        s.GetInfo();
                        Console.WriteLine("Pole {0} wynosi : {1:f2}",
                            s.Name, s.Area());

                        Circle testCirc = s as Circle;
                        if (testCirc == null)
                        {
                            Console.WriteLine("To nie jest kolo");
                        }

                        if (s is Circle)
                        {
                            Console.WriteLine("To nie jest prostokat");
                        }
                        Console.WriteLine("Nacisnij dowolny przycisk aby wyjsc...");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }

                    Console.ReadLine();
                }
                if (text.ToLower() == "ptrojkat")
                {
                    Console.Clear();
                    Console.WriteLine("Wprowadz dlugosc boku A i po Enterze dlugosc boku B oraz boku C");
                    double Wprowadz1 = Convert.ToDouble(Console.ReadLine());
                    double Wprowadz2 = Convert.ToDouble(Console.ReadLine());
                    double Wprowadz3 = Convert.ToDouble(Console.ReadLine());
                    Shape[] shapes = { new Triangle(Wprowadz1, Wprowadz2, Wprowadz3) };
                    foreach (Shape s in shapes)
                    {
                        s.GetInfo();
                        Console.WriteLine("Pole {0} wynosi : {1:f2}",
                            s.Name, s.Area());

                        Circle testCirc = s as Circle;
                        if (testCirc == null)
                        {
                            Console.WriteLine("To nie jest kolo");
                        }

                        if (s is Circle)
                        {
                            Console.WriteLine("To nie jest prostokat");
                        }
                        Console.WriteLine("Nacisnij dowolny przycisk aby wyjsc...");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\nBrak w bazie danych\n" +
                        "Press any key to exit the process...");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            if (decyzja.ToLower() == "objetosc")
            {
                Console.Clear();
                Console.WriteLine("Zdecyduj, objetosc ktorej figury " +
                    "chcesz obliczyc i wpisz: OKula\n");
                string texxt = Console.ReadLine();
                if (texxt.ToLower() == "okula")
                {
                    Console.Clear();
                    Console.WriteLine("Wprowadz promien kuli");
                    double Wprowadz1 = Convert.ToDouble(Console.ReadLine());
                    Shape[] shapes = { new Sphere(Wprowadz1) };
                    foreach (Shape s in shapes)
                    {
                        s.GetInfo();
                        Console.WriteLine("Objetosc {0} wynosi : {1:f2}",
                            s.Name, s.Area());

                        Circle testCirc = s as Circle;
                        if (testCirc == null)
                        {
                            Console.WriteLine("To nie jest kolo");
                        }

                        if (s is Circle)
                        {
                            Console.WriteLine("To nie jest prostokat");
                        }
                        Console.WriteLine("Nacisnij dowolny przycisk aby wyjsc...");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }

            }
            else
            {
                Console.WriteLine("\nBrak takiego polecenia w bazie danych\n" +
                    "Press any key to exit the process...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
