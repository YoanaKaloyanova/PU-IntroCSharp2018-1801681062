using System;

namespace DecartCoordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some calculations!");
            Console.Write("Enter Xa: ");
            double Xa = double.Parse(Console.ReadLine());
            Console.Write("Enter Ya: ");
            double Ya = double.Parse(Console.ReadLine());
            Console.Write("Enter Xb: ");
            double Xb = double.Parse(Console.ReadLine());
            Console.Write("Enter Yb: ");
            double Yb = double.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------------");
            Console.WriteLine("The points have the following coordinates:");
            Console.WriteLine("Point A("+ Xa+ ","+ Ya+ ")"); 
            Console.WriteLine("Point B("+ Xb+ ","+ Yb+ ")");
            Console.WriteLine("---------------------------------");

            double Distance = Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2));
            Console.WriteLine("The distance between the two pints is: " + Distance);

            Console.ReadKey();

        }
    }
}
