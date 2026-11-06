using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPoo
{
    public class Calculadora
    {
        public double Somar(double a, double b)
        {
            return a + b;
        }
        public double Subtrair(double a, double b)
        {
            return a - b;
        }
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }
        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Divisão por zero não é permitida.");
            }
            return a / b;
        }
    }
}