using System;
using System.Collections.Generic;
using System.Linq;

class CartaoCorporativo
{
    public decimal Limite { get; }
    public List<decimal> Transacoes { get; }

    public CartaoCorporativo(decimal limite)
    {
        Limite = limite;
        Transacoes = new List<decimal>();
    }

    public void AdicionarTransacao(decimal valor)
    {
        Transacoes.Add(valor);
    }

    public decimal CalcularTotal()
    {
        return Transacoes.Sum();
    }

    public bool UltrapassouLimite()
    {
        return CalcularTotal() > Limite;
    }

    public void ExibirResumo()
    {
        decimal total = CalcularTotal();
        Console.WriteLine($"Total gasto: {total:0.00}");
        if (UltrapassouLimite())
        {
            Console.WriteLine("Limite ultrapassado");
        }
        else
        {
            Console.WriteLine("Limite OK");
        }
    }
}

class Program
{
    static void Main()
    {
        decimal limite = decimal.Parse(Console.ReadLine());
        int quantidade = int.Parse(Console.ReadLine());

        var cartao = new CartaoCorporativo(limite);

        for (int i = 0; i < quantidade; i++)
        {
            decimal valor = decimal.Parse(Console.ReadLine());
            cartao.AdicionarTransacao(valor);
        }

        cartao.ExibirResumo();
    }
}

