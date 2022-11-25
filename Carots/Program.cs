using System;


namespace Carrot
{
    class Program
    {
        static void Main(string[] args)
        {
            int carrots = 40;
            Console.Write("Tors tid ? ");
            int Ttid = int.Parse(Console.ReadLine());
            Console.Write("Mors tid ? ");
            int Mtid = int.Parse(Console.ReadLine());
            carrots = carrots - 2;
            int Tcarrots = 1;
            int Mcarrots = 1;
            for (int i = 0; carrots >= 1; i++)
            {
                if (carrots == 1 && i % Ttid == 0 && i % Mtid == 0)
                {
                    break;
                }
                if(i % Ttid == 0)
                {
                    carrots--;
                    Tcarrots++;
                }
                if (i % Mtid == 0)
                {
                    carrots--;
                    Mcarrots++;
                }
                Console.WriteLine(carrots);
            }
            Console.WriteLine("Programmet är färdigt");
            Console.WriteLine("Tor fick: " + Tcarrots + ". Mor fick: " + Mcarrots);
        }
    }
}
