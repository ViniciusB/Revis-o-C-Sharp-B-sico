using System;

namespace EstruturaDecisaoOperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("Digite um nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite uma idade: ");
            idade = int.Parse(Console.ReadLine());

            if(nome == "Vinicius" && idade == 26)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Seu nome é {nome} e você tem {idade} anos");
                Console.WriteLine("-------------------------");
            }

            if(nome == "Vinicius" || idade == 26)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Seu nome pode ser Vinicius e sua idade pode ser 26 anos");
                Console.WriteLine("-------------------------");
            }

            bool v = false;
            bool f = false;

            if(!v)
            {
                Console.WriteLine("A primeira condição é verdadeira");
            }

            if (!f)
            {
                Console.WriteLine("A segunda condição é verdadeira");
            }
        }    
    }
}
