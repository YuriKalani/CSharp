using System;

namespace URI_Online_Judge___ex_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string osso = Console.ReadLine();
            string ovo = Console.ReadLine();
            string carne = Console.ReadLine();

            if (osso == "vertebrado")
            {
                if (ovo == "ave")
                {
                    if (carne == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    } else if ( carne == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }else if (ovo == "mamifero")
                {
                    if (carne == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (carne == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            } else if (osso == "invertebrado")
            {
                if (ovo == "inseto")
                {
                    if (carne == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (carne == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (ovo == "anelideo")
                {
                    if (carne == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (carne == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
