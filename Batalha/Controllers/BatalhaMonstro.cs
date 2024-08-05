using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Batalha.Models;

namespace Batalha.Controllers
{
    public class BatalhaMonstro
    {
        private Monstro Monstro1 { get; set; }
        private Monstro Monstro2 { get; set; }
        public BatalhaMonstro(Monstro monstro1, Monstro monstro2)
        {
            Monstro1 = monstro1;
            Monstro2 = monstro2;
        }

        private (Monstro, Monstro) SortearAtacanteDefensor()
        {
            Random random = new Random();
            return random.Next(0, 2) == 0 ? (Monstro1, Monstro2) : (Monstro2, Monstro1);
        }

        public (Monstro vencedor, Monstro perdedor) Batalhar()
        {
            var (atacante, defensor) = SortearAtacanteDefensor();

            while (atacante.Vida > 0 && defensor.Vida > 0)
            {
                defensor.Vida -= Math.Max(0, atacante.Ataque - defensor.Defesa);
                (atacante, defensor) = SortearAtacanteDefensor();
            }

            var vencedor = atacante.Vida > 0 ? atacante : defensor;
            var perdedor = atacante.Vida > 0 ? defensor : atacante;

            return (vencedor, perdedor);
        }

        public void SubirNivel(ref Monstro monstro)
        {
            monstro.Nivel +=1;
            monstro.Ataque += 5;
            monstro.Defesa += 2;
            monstro.Vida += 50;
        }
    }
}