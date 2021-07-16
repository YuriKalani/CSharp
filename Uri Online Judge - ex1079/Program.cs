using System;
using System.Globalization;

namespace Uri_Online_Judge___ex1079
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, v3, mp;

            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            for (int cnt = 0; cnt < n; cnt++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                v1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                v2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                v3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                mp = ((v1 * 2) + (v2 * 3) + (v3 * 5)) / 10;
                Console.WriteLine(mp.ToString("F1", CultureInfo.InvariantCulture));
            }
           
        }
    }
}
