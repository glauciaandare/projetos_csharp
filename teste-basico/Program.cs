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
            // Adiciona à lista somente se o valor for maior que zero
            if (valor > 0)
            {
                despesas.Add(valor);
            }
        }

        if (despesas.Count == 0)
        {
            Console.WriteLine("Sem despesas validas");
        }
        else
        {
            // Imprime cada valor da lista de despesas válidas
            foreach (int despesa in despesas)
            {
                Console.WriteLine(despesa);
            }
        }
    }
}
