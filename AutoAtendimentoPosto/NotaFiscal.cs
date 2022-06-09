using System;
using System.Collections.Generic;
using System.Text;

namespace AutoAtendimentoPosto
{
    class NotaFiscal
    {
        private int _combustivel;
        private string _cpf;
        public string Nome { get; set; }
        public DateTime InicioAbastecimento { get; set; }
        public DateTime FimAbastecimento { get; set; }

        public Abastecimento Abastecimento { get; set; }

        public NotaFiscal()
        {

        }

        public NotaFiscal(string nome, string cpf, DateTime inicioAbastecimento, DateTime fimAbastecimento, int combustivel, Abastecimento abastecimento)
        {
            Nome = nome.ToUpper().Trim();
            _cpf = cpf;
            InicioAbastecimento = inicioAbastecimento;
            FimAbastecimento = fimAbastecimento;
            _combustivel = combustivel;
            Abastecimento = abastecimento;
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
                
                return MontarCpf();
            }
        }

        private string MontarCpf()
        {
            string cpfGrupo1 = _cpf.Substring(0, 3);
            string cpfGrupo2 = _cpf.Substring(3, 3);
            string cpfGrupo3 = _cpf.Substring(6, 3);
            string cpfGrupo4 = _cpf.Substring(9, 2);
            string cpf = $"{cpfGrupo1}.{cpfGrupo2}.{cpfGrupo3}-{cpfGrupo4}";
            return cpf;
        }

        public override string ToString()
        {
            StringBuilder mensagem = new StringBuilder();
            mensagem.AppendLine("Posto de Gasolina Dot Net");
            mensagem.AppendLine($"Cliente: {Nome}");
            mensagem.AppendLine($"CPF: {CPF}");
            mensagem.AppendLine($"Inicio do Abastecimento: {InicioAbastecimento.ToString("dd/MM/yyyy HH:mm:ss")}");
            mensagem.AppendLine($"Fim do Abastecimento: {FimAbastecimento.ToString("dd/MM/yyyy HH:mm:ss")}");
            mensagem.AppendLine($"Tipo de combustivel = {Combustivel}");
            mensagem.AppendLine($"Litros: {Abastecimento.Litros}");
            mensagem.AppendLine($"VALOR TOTAL: R${Abastecimento.ValorTotal.ToString("F2")} ");

            return mensagem.ToString();
        }
    }
}
