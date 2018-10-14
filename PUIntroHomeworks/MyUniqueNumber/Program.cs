using System;

namespace MyUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");

            int age = int.Parse(Console.ReadLine());

            int ageAfter10Years = age + 10;

            Console.WriteLine("Enter last 4 digits of your faculty number here:");

            int digits = int.Parse(Console.ReadLine());

            const double pi = Math.PI;

            double uniqnumb = Math.Round ((ageAfter10Years * digits) / pi,4);

            Console.WriteLine("After 10 years you will be " + ageAfter10Years + " years old. And your unique number is" + uniqnumb);
            Console.ReadKey();
        }
    }
}
