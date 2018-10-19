using System;

namespace BusTicketLuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int LuckyTickets = 0;
            int UnluckyTickets = 0;
            for (int i = 0; i < 1000000; i++)
            {
                int a = i / 100000;
                int b = i % 100000 / 10000;
                int c = i % 100000 % 10000 / 1000;
                int d = i % 100000 % 10000 % 1000 / 100;
                int e = i % 100000 % 10000 % 1000 % 100 / 10;
                int f = i % 10;

                if ((a + b + c) == (d + e + f))
                {
                    Console.WriteLine(i);
                    LuckyTickets = LuckyTickets + 1;
                }
                else
                {
                    UnluckyTickets = UnluckyTickets + 1;
                }
            }
            Console.WriteLine("Total lucky ticket numbers are " + LuckyTickets);
            Console.WriteLine("Total not lucky ticket numbers are " + UnluckyTickets);
            Console.WriteLine("Total tickets existing are " + (LuckyTickets + UnluckyTickets)); 
        }
    }
}
