using System;
using System.Threading;

namespace AutoAtendimentoPosto
{
    abstract class Abastecimento
    {
        public decimal PrecoPorLitro { get; set; }
        public decimal Litros { get; protected set; }
        public decimal ValorTotal { get; protected set; }
        protected Abastecimento()
        {

        }
        protected Abastecimento(decimal precoPorLitro)
        { 
            PrecoPorLitro = precoPorLitro;
        }
        
        protected void Abastecer()
        {
            int timerMax = 1000;
            int timer = 0;
            while (timer < timerMax)
            {
                Console.WriteLine("Abastecendo ...");
                timer += 100;
                Thread.Sleep(1500);
            }
            Console.WriteLine();
            Console.WriteLine("Veiculo Abastecido!");
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadKey();
            Console.WriteLine();
            
        }
    }
}
