using System;
using System.Threading;

namespace AutoAtendimentoPosto
{
    abstract class Abastecimento
    {
        public decimal PrecoPorLitro { get; set; }

        protected Abastecimento(decimal precoPorLitro)
        { 
            PrecoPorLitro = precoPorLitro;
        }
        
        public virtual void Abastecer()
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
            
        }
    }
}
