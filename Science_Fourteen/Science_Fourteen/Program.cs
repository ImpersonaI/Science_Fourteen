using System;

namespace Science_Fourteen
{
    class Program
    {

        static double Getdx(double x, double y, double z)
        {

            return z * Math.Log10(x);
        }

        static double Getzdx(double x, double y, double z)
        {

            return y * Math.Pow(z, 2);
        }

        static void Euler(int N, double x, double y, double z, double h)
        {
            double y1;
            int i = 0;
            Console.WriteLine("Result:");
            while (i <= N)
            {
                y1 = y + Getdx(x, y, z) * h;
                z = z + Getzdx(x, y, z) * h;
                y = y1;
                x = x + h;
                Console.WriteLine("x = " + x + " y = " + y + " z = " + z);
                i++;     
            }
        }
        static void Main(string[] args)
        {

            double a = 1, b = 4;
            int N = 10;
            double x = a, y = 0.5, z = 1.5;
            double h = (b - a) / N;

            Euler(N, x, y, z, h);
            Console.ReadKey();
        }
    }
}
