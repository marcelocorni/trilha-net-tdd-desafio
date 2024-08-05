using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Batalha.Models
{
    public class Monstro
    {
        public string Nome { get; set; } = default!;
        public int Vida { get; set; } = 100;
        public int Ataque { get; set; } = 10;
        public int Defesa { get; set; } = 5;
        public int Nivel { get; set; } = 1;

        public Monstro(string nome)
        {
            this.Nome = nome;
        }
    }
}