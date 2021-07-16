using System;

namespace Uri_Online_Judge___ex1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int cnt = 1; cnt <10000; cnt++)
            {
                if (cnt % n == 2)
                {
                    Console.WriteLine(cnt);
                }
            }
        }
    }
}
