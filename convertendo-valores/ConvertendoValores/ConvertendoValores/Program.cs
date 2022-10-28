using System;

namespace ConvertendoValores
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = null;
            int idade = 0;
            double salario = 0.0;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu salário: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"Seu nome é {nome}");
            Console.WriteLine($"Sua idade é {idade} anos");
            Console.WriteLine($"Seu salário é de R$ {salario}");
        }
    }
}
