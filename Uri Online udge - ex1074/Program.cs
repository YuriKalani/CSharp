using System;

namespace Uri_Online_udge___ex1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < n; cnt++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (num % 2 == 0)
                {
                    Console.Write("EVEN ");
                    if (num > 0)
                    {
                        Console.WriteLine("POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("NEGATIVE");
                    }
                }
                else
                {
                    Console.Write("ODD ");
                    if (num > 0)
                    {
                        Console.WriteLine("POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("NEGATIVE");
                    }
                }
            }
        }
    }
}
