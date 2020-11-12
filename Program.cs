using System;

namespace projeto_de_console
{
    class Program
    {
        static void Main(string[] args)
        {

            //Entrada de dados
            Console.WriteLine("soma de dois números");
            Console.WriteLine("--------------------");
            Console.WriteLine("digite o primeiro valor: ");
            int valorUm = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo valor: ");
            int valorDois = int.Parse(Console.ReadLine());


            //Processamento
            int soma = valorUm + valorDois;

            //Exibir
            Console.WriteLine("A soma de "+valorUm+" + "+valorDois+" = "+soma);

        }
    }
}
