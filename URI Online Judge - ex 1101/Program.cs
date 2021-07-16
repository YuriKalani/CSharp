using System;

namespace URI_Online_Judge___ex_1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N, menor, maior;
            int cn=0;

            string[] vet = Console.ReadLine().Split(' ');
            M = int.Parse(vet[0]);
            N = int.Parse(vet[1]);

            do
            {

                menor = M;
                maior = N;
                if (M > N) // 5 2
                {
                    menor = N;
                    maior = M;
                }
                int soma = 0;
                for (int cnt = menor; cnt <= maior; cnt++)
                {
                    Console.Write(cnt + " ");
                    soma += cnt;
                }
                Console.WriteLine("Sum=" + soma);

                vet = Console.ReadLine().Split(' ');
                M = int.Parse(vet[0]);
                N = int.Parse(vet[1]);

            } while (N > 0 && M > 0);
        }
    }
}
