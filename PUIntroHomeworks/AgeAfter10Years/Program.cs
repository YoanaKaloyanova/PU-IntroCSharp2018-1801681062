using System;

namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");

            int age = int.Parse(Console.ReadLine());

            int ageAfter10Years = age + 10;

            Console.WriteLine("You will be " + ageAfter10Years + " years old after 10 years.");
            Console.ReadKey();


        }

    }
}
