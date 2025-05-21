
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string linhaDeNomes = Console.ReadLine();

        // Separa os nomes e remove espaços extras
        List<string> nomes = linhaDeNomes
            .Split(',')
            .Select(nome => nome.Trim())
            .ToList();

        char letraFiltro = char.Parse(Console.ReadLine());

        // Filtra os nomes que começam com a letra, ignorando maiúsculas/minúsculas
        List<string> filtrados = nomes
            .Where(nome => nome.StartsWith(letraFiltro.ToString(), StringComparison.OrdinalIgnoreCase))
            .ToList();

        // Verifica se encontrou nomes correspondentes
        if (filtrados.Count == 0)
        {
            Console.WriteLine("Nenhum nome encontrado");
        }
        else
        {
            foreach (var nome in filtrados)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
