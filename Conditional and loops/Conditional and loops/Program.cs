using System;

namespace Conditional_and_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conditional
            int a = 5;
            int b = 20;
            if (a + b < 20)
            {
                Console.WriteLine("smaller than 20");
            }
            else
            {
                Console.WriteLine("greater than 20");
            }
            //Loops
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
            //For
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hello World! The counter is {i}");
            }

            //example
            int sum = 0;
            for(int i = 0; i < 21; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
