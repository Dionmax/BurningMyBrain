using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula48 {
    static class ConversorMoeda {

        private static double _dolar = Cotacao.GetDolarValueBuy();

        public static double RealToDolar(double real)
            => real * _dolar;

        public static double RealToDolar(double real, double taxa)
           => (real * _dolar) * (1 + (taxa / 100));

        public static double DolarToReal(double dolar)
            => dolar / _dolar;

    }
}
