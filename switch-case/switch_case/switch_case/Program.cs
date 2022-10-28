using System;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tipoEneagrama;

            Console.WriteLine("Digite o tipo do eneagrama: ");
            tipoEneagrama = int.Parse(Console.ReadLine());

            switch(tipoEneagrama)
            {
                case 8:
                case 9:
                case 1:
                    Console.WriteLine("Esse tipo é da tríade do ativos");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Esse tipo é da tríade dos emocionais");
                    Console.WriteLine("Esse tipo é da tríade dos emocionais");
                    break;
                case 5:
                case 6:
                case 7:
                    Console.WriteLine("Esse tipo é da tríade dos mentais");
                    break;
                default: 
                    Console.WriteLine("Tipo inválido");
                    break;
            } 
        }
    }
}
