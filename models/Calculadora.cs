using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoCalculadoraCmd.models
{
    public class Calculadora
    {
        public double Somar(double x, double y)
        {
            double result = x + y;
            return result;
        }
        public double Subtrair(double x, double y)
        {
            double result = x - y;
            return result;
        }
        public double Multiplicar(double x, double y)
        {
            double result = x * y;
            return result;
        }
        public double Dividir(double x, double y)
        {
            double result = x / y;
            return result;
        }
        public double RestoDivisao(double x, double y)
        {
            double result = x % y;
            return result;
        }
        public double Potenciacao(double x, double y)
        {
            double result = Math.Pow(x, y);
            return result;
        }

    }
}