using System;

namespace MiserPiggy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int NameValuePig1 = 0;
            int NameValuePig2 = 0;
            int NameValuePig3 = 0;

            Console.WriteLine("Enter the names of the piglets:");
            Console.WriteLine("Name of the first piglet:");
            string Pig1 = Console.ReadLine();
            Console.WriteLine("Name of the second piglet:");
            string Pig2 = Console.ReadLine();
            Console.WriteLine("Name of the third piglet:");
            string Pig3 = Console.ReadLine();

            foreach (char x in Pig1)
            {
                NameValuePig1 += x;
            }


            foreach (char y in Pig2)
            {
                NameValuePig2 += y;
            }

            foreach (char z in Pig3)
            {
                NameValuePig3 += z;
            }

            Console.WriteLine(NameValuePig1);
            Console.WriteLine(NameValuePig2);
            Console.WriteLine(NameValuePig3);

            if ((NameValuePig1 > NameValuePig2) && (NameValuePig1 > NameValuePig3))
            {
                if (NameValuePig2 > NameValuePig3)
                {
                    Console.WriteLine($"The name-wealthiest pig is {Pig1} ({NameValuePig1}) followed by " +
                        $"{Pig2} ({NameValuePig2}) and last is {Pig3} ({NameValuePig3}).");
                }
                else
                {
                    Console.WriteLine($"The name-wealthiest pig is {Pig1} ({NameValuePig1}) followed by " +
                        $"{Pig3} ({NameValuePig3}) and last is {Pig2} ({NameValuePig2}).");
                }
            }
            else if ((NameValuePig2 > NameValuePig1) && (NameValuePig2 > NameValuePig3))
            {
                if (NameValuePig3 > NameValuePig1)
                {
                    Console.WriteLine($"The name-wealthiest pig is {Pig2} ({NameValuePig2}) followed by " +
                        $"{Pig3} ({NameValuePig3}) and last is {Pig1} ({NameValuePig1}).");
                }
                else
                {
                    Console.WriteLine($"The name-wealthiest pig is {Pig2} ({NameValuePig2}) followed by " +
                        $"{Pig1} ({NameValuePig1}) and last is {Pig3} ({NameValuePig3}).");
                }
            }
            else if ((NameValuePig3 > NameValuePig1) && (NameValuePig3 > NameValuePig2))
            {
                if (NameValuePig2 > NameValuePig1)
                {
                    Console.WriteLine($"The name-wealthiest pig is {Pig3} ({NameValuePig3}) followed by " +
                        $"{Pig2} ({NameValuePig2}) and last is {Pig1} ({NameValuePig1}).");
                }
                else
                {
                    Console.WriteLine($"The name-wealthiest pig is {Pig3} ({NameValuePig3}) followed by " +
                        $"{Pig1} ({NameValuePig1}) and last is {Pig2} ({NameValuePig2}).");
                }
            }
        }
    }
}
