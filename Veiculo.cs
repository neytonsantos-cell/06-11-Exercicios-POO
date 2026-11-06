using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPoo
{
    public class Veiculo
    {
        private double _Velocidade;
        public double Velocidade {
            get
            { 
                return _Velocidade;
            }
            set
            {
                if (value > 0 && value <= 200)
                {
                    _Velocidade = value;
                }
                else
                {
                    Console.WriteLine("A velocidade deve estar entre 0 e 200.");
                }
            }
        }

    }
}