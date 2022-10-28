using System;
using System.Globalization;

namespace EstruturaDecisao
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;
            double nota1, nota2, nota3, media;

            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a nota1 do aluno: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a nota2 do aluno: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a nota3 do aluno: ");
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (nota1 + nota2 + nota3) / 3;  

            Console.WriteLine("Olá, " + nome);
            Console.WriteLine("Sua media final foi " + media.ToString("F2", CultureInfo.InvariantCulture));

            if(media < 5)
            {
                Console.WriteLine($"{nome} foi Reprovado");
            }
            else if (media > 5 && media < 6)
            {
                Console.WriteLine($"{nome} foi Aprovado por pouco");
            }
            else
            {
                Console.WriteLine($"{nome} foi Aprovado");
            }
        }
    }
}
