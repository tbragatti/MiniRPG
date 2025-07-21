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
        public Ladino() : base()
        {
            Nome = "Barian";
            Vida = 80;
            Ataque = 25;
            Defesa = 7;
        }

        public override int Atacar(Heroi inimigo)
        {
            int dano = this.Ataque - inimigo.Defesa;

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
            int defesaMinima = 5;

            if (inimigo.Defesa <= defesaMinima)
            {
                Console.WriteLine($"{inimigo.Nome} está vulnerável ao ataque especial!");

                int vidaInimigoTemp = inimigo.Vida;
                 inimigo.Vida = 0; // O ataque especial causa dano fatal se a defesa for zero

                return vidaInimigoTemp;
            }
            else
            {
                Console.WriteLine($"{inimigo.Nome} conseguiu se defender do ataque especial!");
                return 0; // Se a defesa não for zero, o ataque especial não causa dano
            }


        }
    }
}
