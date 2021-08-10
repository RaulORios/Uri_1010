using System;
using System.Globalization;

namespace Uri_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet1 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vet1[0]);
            int qtde1 = int.Parse(vet1[1]);
            double preco1 = double.Parse(vet1[2],CultureInfo.InvariantCulture);

            double tot1 = qtde1 * preco1;

            string[] vet2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet2[0]);
            int qtde2 = int.Parse(vet2[1]);
            double preco2 = double.Parse(vet2[2],CultureInfo.InvariantCulture);

            double tot2 = qtde2 * preco2;

            double total = tot1 + tot2;

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
                        
        }
    }
}
