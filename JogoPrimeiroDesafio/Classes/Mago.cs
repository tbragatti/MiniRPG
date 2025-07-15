using JogoPrimeiroDesafio.Personagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPrimeiroDesafio.Classes
{
    public class Mago:Heroi,IAtacavel
    {
        public Mago(string nome, int vida, int ataque, int defesa) : base(nome, vida, ataque, defesa)
        {
           Nome= nome;
            Vida = vida;
            Ataque = ataque;
            Defesa = defesa;
        }
        public override int Atacar(Heroi alvo)
        {   int totalDeGelo = 0;
            if (totalDeGelo == 3)
            {
                alvo.Defesa = 0;
                Console.WriteLine($"{alvo.Nome} está congelado e não pode se defender!");
            }
            int dano = 15 - alvo.Defesa;

            if (dano > 0)
            {
                totalDeGelo++;
                return dano;
                
            }
            else
            {
                return 0;
            }
        }
       

        public int AtaqueEspecial(Heroi alvo)
        {
            if (alvo.Defesa== 0)
            {
                return alvo.Ataque = 0;

               


            }else
            {
                return 0;
            }
        }



    } 
}
