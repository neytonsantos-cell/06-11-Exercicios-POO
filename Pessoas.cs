using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPoo
{
    public class Pessoas
    {
        //public string? Nome, Cidade;
        public string? Nome { get; set; }
        public string? Cidade { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Cidade: {Cidade}");
        }        
    }
}