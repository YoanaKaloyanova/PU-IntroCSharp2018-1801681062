using System;

namespace CalculateWeightInTheSolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your weight in kgs as measured on Earth:");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter the code corresponding to the name of the desired planet:");
            Console.WriteLine("1: Mercury");
            Console.WriteLine("2: Venus");
            Console.WriteLine("3: Earth (You already know the answer)");
            Console.WriteLine("4: Mars");
            Console.WriteLine("5: Jupiter");
            Console.WriteLine("6: Saturn");
            Console.WriteLine("7: Uranus");
            Console.WriteLine("8: Neptune");
            Console.WriteLine("-------------------------------------------");

            int option = int.Parse(Console.ReadLine());
            double gravitationalRatio;
            double weightOnPlanet;
            switch (option)

            {
                case 1:

                    gravitationalRatio = 0.38;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Mercury.");
                    break;

                case 2:

                    gravitationalRatio = 0.91;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Venus.");
                    break;

                case 3:

                    gravitationalRatio = 1;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Earth.");
                    break;

                case 4:

                    gravitationalRatio = 0.38;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Mars.");
                    break;

                case 5:

                    gravitationalRatio = 2.34;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Jupiter.");
                    break;

                case 6:

                    gravitationalRatio = 1.06;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Saturn.");
                    break;

                case 7:

                    gravitationalRatio = 0.92;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Uranus.");
                    break;

                case 8:

                    gravitationalRatio = 1.19;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Neptune.");
                    break;

                default: Console.WriteLine("Enter a valid code."); break;
            }
            Console.ReadKey();

        }
    }
}
