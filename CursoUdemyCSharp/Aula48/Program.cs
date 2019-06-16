using System;

namespace Aula48 {
    class Program {
        static void Main(string[] args) {
            Cotacao cot = new Cotacao();

            Console.WriteLine(Cotacao.GetDolarValueBuy());

            Console.WriteLine(Cotacao.GetDolarValueSell());

            Console.WriteLine(ConversorMoeda.RealToDolar(200, 6));

            Console.ReadKey();



        }
    }
}
