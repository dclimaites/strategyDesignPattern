using StrategyDesignPattern.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Interface
{
    public interface Imposto
    {
        double Calcular(Orcamento orcamento);
    }
}
