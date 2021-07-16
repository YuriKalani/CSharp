using System;

namespace URI_Online_Judge___ex_1145
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            for (int cnt = 1; cnt <= y; cnt++)
            {
                Console.Write(cnt);
                if (cnt % x == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}