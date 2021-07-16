using System;
using System.Globalization;

namespace Vetores___Exercício_proposto_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i=0; i<N; i++)
            {
                vet[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);

            }
            double maior = vet[0];
            int Posicao = 0;
            
            for (int j=0; j<N; j++)
            {
                if (vet[j] > maior)
                {
                    maior = vet[j];
                    Posicao = j;
                }
            }
            Console.WriteLine(maior.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(Posicao);
        }
    }
}