using System;
using System.Collections.Generic;
using System.Text;

namespace AutoAtendimentoPosto
{
    class AbastecimentoDinheiro : Abastecimento
    {
        public AbastecimentoDinheiro(decimal precoPorLitro, decimal quantiaAbastecimento) : base(precoPorLitro)
        {
            ValorTotal = quantiaAbastecimento;
            Litros = CalculaLitros();
            Abastecer();
        }

        protected decimal CalculaLitros()
        {
            
            return ValorTotal / PrecoPorLitro;
        }


    }
}
