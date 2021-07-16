using System;

namespace URI_Online_Judge___ex_1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int x, y, imp = 0;

            for (int cnt = 1; cnt <= N; cnt++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
                
                if (x > y)
                {
                    int aux = x;
                    x = y;
                    y = aux;
                }

                int soma = 0;

                for (int cnt2 = x +1; cnt2 < y; cnt2++)
                {
                    if (cnt2 % 2 != 0)
                    {
                        soma = soma + cnt2;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}
