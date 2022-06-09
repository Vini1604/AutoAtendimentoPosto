using System;
using System.Collections.Generic;
using System.Text;

namespace AutoAtendimentoPosto
{
    class AbastecimentoLitro : Abastecimento
    {
        public AbastecimentoLitro(decimal precoPorLitro, decimal quantidadeLitros) : base(precoPorLitro)
        {
            Litros = quantidadeLitros;
            ValorTotal = CalculaCusto();
            Abastecer();
        }

        protected decimal CalculaCusto()
        {
            return Litros * PrecoPorLitro;
        }

    }
}
