using System;
using System.Globalization;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCompleto = "Vinicius Barros";
            int idade = 26;
            double altura = 1.67;
            bool pessoaBonita = true;

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(pessoaBonita);
        }
    }
}
