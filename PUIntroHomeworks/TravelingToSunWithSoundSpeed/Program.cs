using System;

namespace TravelingToSunWithSoundSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SpeedOfSound = 1235;
            const long DistanceEarthSun = 149600000;
            double Hours =  DistanceEarthSun / SpeedOfSound ;
            double Years = Math.Floor(Hours / 8760);
            double Days = Math.Floor(((Hours / 8760) - Years) * 365);
            Console.WriteLine("The time needed to travel from the Earth to the Sun is " + Hours + " hours, or " +

                Years + " years and "+Days+ "days.");

            Console.ReadKey();

        }
    }
}
