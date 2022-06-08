using System;
using System.Collections.Generic;
using System.Text;

namespace AutoAtendimentoPosto
{
    class AbastecimentoDinheiro : Abastecimento
    {
        public decimal QuantiaAbastecimento { get; set; }
        public AbastecimentoDinheiro(decimal precoPorLitro, decimal quantiaAbastecimento) : base(precoPorLitro)
        {
            QuantiaAbastecimento = quantiaAbastecimento;
        }

        public virtual decimal CalculaLitros()
        {
            return QuantiaAbastecimento / PrecoPorLitro;
        }


    }
}
