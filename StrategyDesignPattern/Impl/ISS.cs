using StrategyDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Impl
{
    public class ISS : Imposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
