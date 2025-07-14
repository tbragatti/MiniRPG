using JogoPrimeiroDesafio.Personagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPrimeiroDesafio.Classes
{
    internal class Ladino : Heroi, IAtacavel
    {
        public Ladino(string nome, int vida, int ataque, int defesa) : base(nome, vida, ataque, defesa)
        {
            
        }
    }
}
