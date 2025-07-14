using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPrimeiroDesafio.Personagem
{
    internal class Heroi

    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }

        public Heroi(string nome, int vida, int ataque, int defesa)
        {
            Nome = nome;
            Vida = vida;
            Ataque = ataque;
            Defesa = defesa;
        }



        public virtual void Atacar (Heroi oponente)
        {


            int dano = Ataque - oponente.Defesa;
            if (dano < 0) dano = 0; // 
            oponente.Vida -= dano;
            Console.WriteLine($"{Nome} ataca {oponente.Nome} causando {dano} de dano.");
            Console.WriteLine($"{oponente.Nome} agora tem {oponente.Vida} de vida.");
        }

        







    }

}

