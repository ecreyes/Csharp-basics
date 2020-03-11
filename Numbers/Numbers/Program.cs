using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //operations
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            //range
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            //double
            double maxdouble = double.MaxValue;
            double mindouble = double.MinValue;
            Console.WriteLine($"The range of double is {mindouble} to {maxdouble}");
            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            //decimal
            double adoub = 1.0;
            double bdoub = 3.0;
            Console.WriteLine(adoub / bdoub);

            decimal cdec = 1.0M;
            decimal ddec = 3.0M;
            Console.WriteLine(cdec / ddec);

            // area of a circle
            double r = 2.50;
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine(area);
        }
    }
}
