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
        public override int Atacar(Heroi inimigo)
        {   int totalDeGelo = 0;
            int dano = 15 - inimigo.Defesa;
            
            if (totalDeGelo == 3)
            {
                inimigo.Defesa = 0;
                Console.WriteLine($"{inimigo.Nome} está congelado e não pode se defender! Sua defesa foi zerada!");
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
            if (inimigo.Defesa== 0)
            {
                Console.Clear();
                Console.WriteLine("Merlin congelou a arma de seus inimigo!");

                return inimigo.Ataque = 0;

               

            }else
            {
                return 0;
            }
        }



    } 
}
