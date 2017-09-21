using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06Lab06
{
    class Program
    {
        static void EvenOddNumber(double N)
        {
            string x;
            if ((N % 2) > 0)
            {
                x = ("This is Odd Number");
            }
            else
            {
                x = ("This is Even Number");  
            }
            Console.WriteLine("{0}", x);
            return;
        }

        static void Main(string[] args)
        {
            double N;
            Console.Write("Enter a number : ");
            N = double.Parse(Console.ReadLine());
            EvenOddNumber(N);
            Console.ReadLine();
        }
    }
}
