using JogoPrimeiroDesafio.Personagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPrimeiroDesafio.Classes
{
    public class Mago : Heroi, IAtacavel
    {
        int totalDeGelo = 0;

        public Mago(string nome, int vida, int ataque, int defesa) : base(nome, vida, ataque, defesa)
        {
            Nome = nome;
            Vida = vida;
            Ataque = ataque;
            Defesa = defesa;
        }

        public override int Atacar(Heroi inimigo)
        {
            int dano = 15 - inimigo.Defesa;

            if (totalDeGelo == 2)
            {
                inimigo.Defesa = 0;
                Console.WriteLine($"{inimigo.Nome} está congelado e não pode se defender! Sua defesa foi zerada!");
            }
            else
            {
                totalDeGelo++;
            }


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
            if (inimigo.Defesa == 0)
            {
                Console.Clear();
                Console.WriteLine("Merlin congelou a arma de seus inimigo!");

                inimigo.Ataque = 0;
            }

            return 0;
        }
    }
}
