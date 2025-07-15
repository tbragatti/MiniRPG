using JogoPrimeiroDesafio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JogoPrimeiroDesafio.Personagem
{
    public abstract class Heroi

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
        public virtual int Atacar(Heroi alvo)
        {
            int dano = Ataque - alvo.Defesa;

            if (dano > 0)
            {
                return dano;
            }
            else
            {
                return 0;
            }
        }

        public void Receberdano(int dano)
        {
            Vida -= dano;
            if (Vida == 0)
            {
                Console.WriteLine($"{Nome} foi derrotado!");

            }
           
            
        }

        public void ExibirStatus()
        {
            Console.WriteLine($"Nome: {Nome}, Vida: {Vida}, Ataque: {Ataque}, Defesa: {Defesa}");
        }

        
    }















}




















