using System;
using System.Collections.Generic;
using System.Text;

namespace AutoAtendimentoPosto
{
    class AbastecimentoLitro : Abastecimento
    {
        public decimal QuantidadeLitros { get; set; }
        public AbastecimentoLitro(decimal quantidadeLitros, decimal precoPorLitro) : base(precoPorLitro)
        {
            QuantidadeLitros = quantidadeLitros;
        }

        public decimal CalculaCusto()
        {
            return QuantidadeLitros * PrecoPorLitro;
        }

    }
}
