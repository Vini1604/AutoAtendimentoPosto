using System;
using System.Collections.Generic;
using System.Text;

namespace AutoAtendimentoPosto
{
    class NotaFiscal
    {
        public string Nome { get; set; }
        public DateTime InicioAbastecimento { get; set; }
        public DateTime FimAbastecimento { get; set; }
        private int _combustivel;
        private string _cpf;
        public double QuantidadeLitros { get; set; }

        public NotaFiscal()
        {

        }

        public NotaFiscal(string nome, string cpf, DateTime inicioAbastecimento, DateTime fimAbastecimento, int combustivel, double quantidadeLitros)
        {
            Nome = nome;
            _cpf = cpf;
            InicioAbastecimento = inicioAbastecimento;
            FimAbastecimento = fimAbastecimento;
            _combustivel = combustivel;
            QuantidadeLitros = quantidadeLitros;
        }

        public string Combustivel
        {
            get
            {
               string combustivel = _combustivel == 1 ? "Alcool" : "Gasolina";
                return combustivel;
            }
        }

        public string CPF
        {
            get
            {
                string cpfGrupo1 = _cpf.Substring(0, 3);
                string cpfGrupo2 = _cpf.Substring(3, 3);
                string cpfGrupo3 = _cpf.Substring(6, 3);
                string cpfGrupo4 = _cpf.Substring(9, 2);
                string cpf = $"{cpfGrupo1}.{cpfGrupo2}.{cpfGrupo3}-{cpfGrupo4}";
                return cpf;
            }
        }

        public override string ToString()
        {
            StringBuilder mensagem = new StringBuilder();
            mensagem.AppendLine("Posto de Gasolina Dot Net");
            mensagem.AppendLine($"Cliente: {Nome}");
            mensagem.AppendLine($"CPF: {CPF}");
            mensagem.AppendLine($"Inicio do Abastecimento: {InicioAbastecimento.ToString("dd/MM/yyyy HH:mm:ss")}");
            mensagem.AppendLine($"Inicio do Abastecimento: {FimAbastecimento.ToString("dd/MM/yyyy HH:mm:ss")}");
            mensagem.AppendLine($"Tipo de combustivel = {Combustivel}");
            mensagem.AppendLine($"Litros: {QuantidadeLitros}");
            //mensagem.AppendLine($"INSERIR VALOR TOTAL ");

            return mensagem.ToString();
        }
    }
}
