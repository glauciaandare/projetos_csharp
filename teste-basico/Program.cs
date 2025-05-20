using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        int quantidade = int.Parse(Console.ReadLine());
        List<int> despesas = new List<int>();

        for (int i = 0; i < quantidade; i++)
        {
            int valor = int.Parse(Console.ReadLine());
            // TODO: Adicione o valor à lista somente se for maior que zero
            

        }

        if (despesas.Count == 0)
        {
            Console.WriteLine("Sem despesas validas");
        }
        else
        {
            // TODO: Imprima cada valor da lista de despesas válidas
            

        }
    }
}
