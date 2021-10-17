using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Equation_for_Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation equation = new Equation();
            Console.Write("Введите значение коэффициента k ");
            equation.K = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение коэффициента b ");
            equation.B = Convert.ToDouble(Console.ReadLine());
            equation.Root();
            Console.ReadKey();
        }
        struct Equation
        {
            public double K;
            public double B;
            public double X;
            public void Root()
            {
                if ((K<0)||(K>0))
                {
                    X = (-B) / K;
                    Console.WriteLine($"Значение x = {X:F}");
                }
                else 
                {
                    Console.WriteLine("Уравнение не имеет решения");
                }
            }
        }
    }
}
