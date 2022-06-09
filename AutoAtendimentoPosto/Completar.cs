using System;
using System.Threading;

namespace AutoAtendimentoPosto
{
    class Completar : Abastecimento
    {
        private int _capacidadeTanque;
        private int _capacidadeAtual;
        private int _volumeRestante;

        public Completar(decimal precoPorLitro) : base(precoPorLitro)
        {
            _capacidadeTanque = Convert.ToInt32(new Random().Next(60, 80));
            _capacidadeAtual =Convert.ToInt32(new Random().Next(_capacidadeTanque));
            _volumeRestante = _capacidadeTanque - _capacidadeAtual;
            Litros = (decimal) _volumeRestante;
            ValorTotal = CalculaPreco();
            Abastecer();
        }

        public decimal CalculaPreco()
        {
            return Litros * PrecoPorLitro;
        } 
    }
}
