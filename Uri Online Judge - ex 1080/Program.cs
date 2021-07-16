using System;

namespace Uri_Online_Judge___ex_1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int valors = int.Parse(Console.ReadLine());

            int vmaior = valors;
            int vmenor = valors;

            for (int cnt = 2; cnt <= 100; cnt++)
            {
                int vlores = int.Parse(Console.ReadLine());
                if (vlores > vmaior)
                {
                    vmaior = vlores;
                    vmenor = cnt;
                }
            }
            Console.WriteLine(vmaior);
            Console.WriteLine(vmenor);
        }
    }
}
