using System;
using System.Collections.Generic;
using System.Linq;

class AnalisadorDeTransacoes
{
    public decimal Limite { get; set; }

    public List<decimal> Transacoes { get; set; }

    public AnalisadorDeTransacoes(decimal limite)
    {
        Limite = limite;
        Transacoes = new List<decimal>();
    }

    public void AdicionarTransacao(decimal valor)
    {
        Transacoes.Add(valor);
    }

    public List<decimal> ObterTransacoesSuspeitas()
    {
        return Transacoes.Where(valor => valor > Limite).ToList();
    }

    public void ExibirRelatorio()
    {
        var suspeitas = ObterTransacoesSuspeitas();

        if (suspeitas.Count == 0)
        {
            Console.WriteLine("Nenhuma transacao suspeita");
        }
        else
        {
            decimal totalSuspeitas = suspeitas.Sum();
            int numeroSuspeitas = suspeitas.Count;

            string transacaoTexto = numeroSuspeitas == 1 ? "transacao suspeita" : "transacoes suspeitas";

            Console.WriteLine($"Transacoes suspeitas: {totalSuspeitas:F2}");
            Console.WriteLine($"{numeroSuspeitas} {transacaoTexto}");
        }
    }
}

class Program
{
    static void Main()
    {
        decimal limite = decimal.Parse(Console.ReadLine());
        int quantidade = int.Parse(Console.ReadLine());

        var analisador = new AnalisadorDeTransacoes(limite);

        for (int i = 0; i < quantidade; i++)
        {
            decimal valor = decimal.Parse(Console.ReadLine());
            analisador.AdicionarTransacao(valor);
        }

        analisador.ExibirRelatorio();
    }
}
