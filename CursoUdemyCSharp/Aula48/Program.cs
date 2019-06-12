using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula48 {
    class Program {
        static void Main(string[] args) {
            Cotacao cot = new Cotacao();

            Console.WriteLine(cot.GetDolarValueBuy());

            Console.WriteLine(cot.GetDolarValueSell());

            Console.ReadKey();
        }
    }
}
