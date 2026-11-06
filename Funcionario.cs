using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ExerciciosPoo
{
    public class Funcionario
    {
        public string? Nome { get; set; }
        public string? Cargo { get; set; }
        public decimal Salario { get; private set; }

        public void AumentarSalario(decimal percentual)
        {
            if (percentual > 0)
            {
                Salario += Salario * percentual / 100;
            }
        }
        public void ConsultarSalario()
        {
            Console.WriteLine($"Salário de {Nome}: R$ {Salario:F2}");
        }
    }
}