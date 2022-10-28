using System;

namespace ConcatenandoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Vinicius";
            string sobrenome = "Barros";
            string nomeCompleto = $"Olá {nome} {sobrenome}";

            Console.WriteLine(nomeCompleto);
        }
    }
}
