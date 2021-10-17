using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение коэффициента k ");
            double k = Convert.ToDouble(Console.Read());
            Console.WriteLine("Введите значение коэффициента b ");
            double b = Convert.ToDouble(Console.Read());
            double x=0;
            Equation equation = new Equation(b, x);
            equation.Root();
            Console.ReadKey();
        }
    }
    public class Equation
    {
        double K;
        double B;
        double X;
        public Equation(double k, double b, double x)
        {
            B = b;
            X = x;
        }
        public void Root()
        {
            if (K<0)
            {
                X = B;
                Console.WriteLine($"Значение x = {X}");
            }
            else if (K==0)
            {
                B = 0;
                Console.WriteLine($"Значение x = {B}");
            }
            else
            {
                X = (-B) / K;
                Console.WriteLine($"Значение x = {X}");
            }
        }
    }
    }
