using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2;

            valor1 = 10;
            valor2 = 5;

            double soma = valor1 + valor2;
            double multiplicacao = valor1 * valor2;
            double divisao = valor1 / valor2;
            double subtracao = valor1 - valor2;
            double media = soma / 2;

            Console.WriteLine(soma);
            Console.WriteLine(multiplicacao);
            Console.WriteLine(divisao);
            Console.WriteLine(subtracao);
            Console.WriteLine(media);
        }
    }
}
