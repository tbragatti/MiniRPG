using JogoPrimeiroDesafio.Personagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPrimeiroDesafio.Classes
{
    public class Bárbaro : Heroi, IAtacavel
    {

        public Bárbaro(string nome, int vida, int ataque, int defesa) : base(nome, vida, ataque, defesa)
        {
            Nome = nome;
            Vida = vida;
            Ataque = ataque;
            Defesa = defesa;

        }
        public override int Atacar(Heroi alvo)
        {

            int dano = 20 - alvo.Defesa;
            if (dano > 0)
            {
                return dano;
            }
            else
            {
                return 0;
            }
        }
        public int AtaqueEspecial(Heroi alvo)
        {
            if (Defesa == 0)
            {
                Defesa = 10;
                Vida -= 10;
                Console.WriteLine($"{Nome} usou o ataque especial e aumentou sua defesa para 10!");
                return 0; // O ataque especial não causa dano, mas aumenta a defesa
            }
            else
            {
                Console.WriteLine($"{Nome} já está com a defesa aumentada!");
                return 0; // Se a defesa já estiver aumentada, não faz nada
            }

        }

    }
}
