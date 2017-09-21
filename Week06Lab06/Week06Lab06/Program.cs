using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06Lab06
{
    class Program
    {
        static void Moon(double X)
        {
            double W;
            W = (X * 1.6);
            Console.WriteLine("Weight on the moon is : {0} N.", W);
        }

        static void Main(string[] args)
        {
            double X;
            Console.Write("Enter the Mass(kg) : ");
            X = double.Parse(Console.ReadLine());
            Moon(X);
            Console.ReadLine();
        }
    }
}
