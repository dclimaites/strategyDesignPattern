using StrategyDesignPattern.Impl;
using System;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeImposto calculadora = new CalculadorDeImposto();
            Orcamento orcamento = new Orcamento(1000);
            calculadora.CalcularImposto(orcamento, new ISS());
            calculadora.CalcularImposto(orcamento, new ICMS());
            Console.ReadKey();
        }
    }
}
