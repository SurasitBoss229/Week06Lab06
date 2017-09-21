using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06Lab06
{
    class Program
    {
        static void trapezoid(double A, double B, double C)
        {
            double D;
            D = (0.5 * (A + B) * C);
            Console.Write("Area of the trapezoid is : {0}" , D);
        }

        static void Main(string[] args)
        {
            double A, B, C;
            Console.Write("Enter the Parallel 1 : ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Enter the Parallel 2 : ");
            B = double.Parse(Console.ReadLine());
            Console.Write("Enter the High : ");
            C = double.Parse(Console.ReadLine());
            trapezoid(A, B, C);
            Console.ReadLine();
        }
    }
}
