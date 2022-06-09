using System;

namespace AutoAtendimentoPosto
{
    class Program
    {
        static AbastecimentoDinheiro AbastecerEmDinheiro(decimal precoPorLitro)
        {
            Console.Write("Digite o valor para abastecer: R$");
            decimal valorAbastecimento = decimal.Parse(Console.ReadLine());
            return new AbastecimentoDinheiro(precoPorLitro, valorAbastecimento);
        }

        static AbastecimentoLitro AbastecerPorLitro(decimal precoPorLitro)
        {
            Console.Write("Digite a quantidade de Litros: ");
            decimal valorLitros = decimal.Parse(Console.ReadLine());
            return new AbastecimentoLitro(precoPorLitro, valorLitros);
        }

        static Completar CompletarTanque(decimal precoPorLitro)
        {
            return new Completar(precoPorLitro);
        }

        static string VerificaViabilidade(decimal alcool, decimal gasolina)
        {
            return alcool <= gasolina * 0.7M ? "Recomendamos Alcool" : "Recomendamos Gasolina";
        }
        
        static void Main(string[] args)
        {
            int combustivel = 0;
            int tipoAbastecimento = 0;
            decimal precoPorLitro = 0;
            Abastecimento abastecimento = null;
            DateTime inicio, fim;

            Console.WriteLine("Bem vindo ao Posto Dot Net!!!!");
            Console.Write("Digite o preco do alcool por litro: R$");
            decimal alcool = decimal.Parse(Console.ReadLine());
            Console.Write("Digite o preco da gasolina por litro: R$");
            decimal gasolina = decimal.Parse(Console.ReadLine());
            Console.WriteLine(VerificaViabilidade(alcool, gasolina));
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu CPF sem traco ou ponto: ");
            string cpf = Console.ReadLine();
            Console.Write("Escolha seu combustivel: 1 - Alcool, 2- Gasolina: ");
            do
            {
                combustivel = int.Parse(Console.ReadLine());
                if (combustivel == 1)
                    precoPorLitro = alcool;
                else if (combustivel == 2)
                    precoPorLitro = alcool;
                else
                    Console.WriteLine("Escolha invalida!! Digite novamente");
            } while (combustivel != 1 && combustivel != 2);

            Console.WriteLine("Escolha o abastecimento: 1 - Por valor, 2 - Por litro, 3 - Completar: ");
            do
            {
                tipoAbastecimento = int.Parse(Console.ReadLine());
                inicio = DateTime.Now;
                switch (tipoAbastecimento)
                {
                    case 1:
                        abastecimento = AbastecerEmDinheiro(precoPorLitro);
                        break;
                    case 2:
                        abastecimento = AbastecerPorLitro(precoPorLitro);
                        break;
                    case 3:
                        abastecimento = CompletarTanque(precoPorLitro);
                        break;
                    default:
                        Console.WriteLine("Opcao Invalida!!! Digite Novamente!!!");
                        break;
                }
            } while (tipoAbastecimento < 1 || tipoAbastecimento > 3);
            fim = DateTime.Now;
            NotaFiscal nota = new NotaFiscal(nome, cpf, inicio, fim, combustivel, abastecimento);
            Console.WriteLine(nota);

            
        }
    }
}
