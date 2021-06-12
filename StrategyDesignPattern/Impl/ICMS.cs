using StrategyDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Impl
{
    public class ICMS : Imposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + 50.00;
        }
    }
}
