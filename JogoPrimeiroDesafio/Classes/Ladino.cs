using JogoPrimeiroDesafio.Personagem;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPrimeiroDesafio.Classes
{
    public class Ladino : Heroi, IAtacavel
    {
        public Ladino(string nome, int vida, int ataque, int defesa) : base(nome, vida, ataque, defesa)
        {
            Nome = nome;
            Vida = vida;
            Ataque = ataque;
            Defesa = defesa;
        }

        public override int Atacar(Heroi inimigo)
        {
            int dano = 25 - inimigo.Defesa;

            if (dano > 0)
            {
                inimigo.Vida = Vida - dano;
                return dano;
            }
            else
            {
                return 0;
            }
        }

        public override int AtaqueEspecial(Heroi inimigo)
        {
            if (inimigo.Defesa <=5)
            {
                Console.WriteLine($"{inimigo.Nome} está vulnerável ao ataque especial!");
                return inimigo.Vida = 0; // O ataque especial causa dano fatal se a defesa for zero
            }
            else
            {
                Console.WriteLine($"{inimigo.Nome} conseguiu se defender do ataque especial!");
                return 0; // Se a defesa não for zero, o ataque especial não causa dano
            }


        }
    }
}
