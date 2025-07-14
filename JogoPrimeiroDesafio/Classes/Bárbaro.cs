using JogoPrimeiroDesafio.Personagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPrimeiroDesafio.Classes
{
    internal class Bárbaro : Heroi
    {

        public Bárbaro(string nome, int vida, int ataque, int defesa) : base(nome, vida, ataque, defesa)
        {

        }

        string nome = "Tristan";
        int vida = 100;
        int ataque = 20;
        int defesa = 10;

    }

    
}
