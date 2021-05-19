using System;

namespace NumerosCrescentesEDecrecentesURI1113
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            //Recorta a string com os numeros inseridos
            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            //Verifica a condicao e imprime o resultado da ordem
            //se os valores de x e y forem iguais, encerra a aplicacao
            while (x != y)
            {

                if (x < y)
                {
                    Console.WriteLine("Crescente");
                }

                else
                {
                    Console.WriteLine("Decrescente");
                }

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }

        }
    }
}