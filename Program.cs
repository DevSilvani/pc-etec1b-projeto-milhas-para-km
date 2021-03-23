using System;

namespace pc_etec1b_projeto_milhas_para_km
{
    class Program
    {
        static void Main(string[] args)
        {
            double milha = 0.0, km = 0.0;

            Console.Write("digite quantas milhas quer converter: ");
            milha = Convert.ToDouble(Console.ReadLine());

            km = milha * 1.60934;

            Console.WriteLine(milha+" Milhas são "+km+" KM");
            Console.ReadKey();
        }
    }
}
