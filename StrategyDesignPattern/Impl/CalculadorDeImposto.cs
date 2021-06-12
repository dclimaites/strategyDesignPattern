using StrategyDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Impl
{
    public class CalculadorDeImposto
    {
        public void CalcularImposto(Orcamento orcamento, Imposto estrategiaDeImposto)
        {
            Console.WriteLine(estrategiaDeImposto.Calcular(orcamento));
        }
    }
}
