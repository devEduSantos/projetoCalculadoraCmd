using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoCalculadoraCmd.models
{
    public class Calculadora
    {
        public decimal Somar(decimal x, decimal y)
        {
            decimal result = x + y;
            return result;
        }
        public decimal Subtrair(decimal x, decimal y)
        {
            decimal result = x - y;
            return result;
        }
        public decimal Multiplicar(decimal x, decimal y)
        {
            decimal result = x * y;
            return result;
        }
        public decimal Dividir(decimal x, decimal y)
        {
            decimal result = x / y;
            return result;
        }
        

    }
}