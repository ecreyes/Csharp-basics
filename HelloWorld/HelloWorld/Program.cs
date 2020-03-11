using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write in console
            Console.WriteLine("Hello world");

            //String variables
            string firstname = "Eduardo";
            string lastname = "Reyes";
            Console.WriteLine($"firstname:{firstname} lastname: {lastname} ");
            Console.WriteLine($"firstname has {firstname.Length} letter");

            //OPERATIONS
            //Trim
            string greeting = "      Hello World!       ";
            Console.WriteLine(greeting.TrimStart());
            Console.WriteLine(greeting.TrimEnd());
            Console.WriteLine(greeting.Trim());

            //upercase lowercase
            Console.WriteLine(greeting.ToLower());
            Console.WriteLine(greeting.ToUpper());

            //searching
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

        }
    }
}
