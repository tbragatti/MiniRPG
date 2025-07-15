using JogoPrimeiroDesafio;
using JogoPrimeiroDesafio.Classes;
using JogoPrimeiroDesafio.Personagem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Jogo
{
    internal class Program
    {
        
        static void Main(string[] args)
        { 
            



        Heroi Ladino = new Ladino("Ladino", 80, 25, 7);
            Heroi Mago = new Mago("Merlin", 55, 15, 5); 
            Heroi Barbaro = new Bárbaro("Tristan", 100, 25, 10);
            void ExibirBoasVindas()
            {
                Console.WriteLine(@"
█▄▄ █▀▀ █▀▄▀█   █░█ █ █▄░█ █▀▄ █▀█ █▀   ▄▀█ █▀█   █▀▄▀█ █ █▄░█ █   █▀█ █▀█ █▀▀
█▄█ ██▄ █░▀░█   ▀▄▀ █ █░▀█ █▄▀ █▄█ ▄█   █▀█ █▄█   █░▀░█ █ █░▀█ █   █▀▄ █▀▀ █▄█");
                Console.WriteLine("*******************************************************************************");


            }
            void ExibirHerois()
            {
                Console.Clear();
                Console.WriteLine("Heróis disponíveis:");
                Console.WriteLine($"1 - {Ladino.Nome} - Vida: {Ladino.Vida}, Ataque: {Ladino.Ataque}, Defesa: {Ladino.Defesa}");
                Console.WriteLine($"2 - {Mago.Nome} - Vida: {Mago.Vida}, Ataque: {Mago.Ataque}, Defesa: {Mago.Defesa}");
                Console.WriteLine($"3 - {Barbaro.Nome} - Vida: {Barbaro.Vida}, Ataque: {Barbaro.Ataque}, Defesa: {Barbaro.Defesa}");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                Console.ReadKey();
                ExibirMenu();
            }

            Heroi EscolherHeroi()
            {
                Console.Clear();




                Console.WriteLine("1 - Ladino");
                Console.WriteLine("2 - Mago");
                Console.WriteLine("3 - Bárbaro");

                Console.WriteLine("Escolha seu Herói:");

                string opcaoEscolhida = Console.ReadLine();
                int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);
                switch (opcaoEscolhidaNum)
                {
                    case 1: return Ladino;
                    case 2: return Mago;
                    case 3: return Barbaro;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        return EscolherHeroi();
                }












            }
            Heroi EscolherInimigo()
            {
                Console.Clear();

                Console.WriteLine("1 - Ladino");
                Console.WriteLine("2 - Mago");
                Console.WriteLine("3 - Bárbaro");

                Console.WriteLine("Escolha seu Inimigo:");
                
                string opcaoEscolhida = Console.ReadLine();
                int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);
                switch (opcaoEscolhidaNum)
                {
                    case 1: return Ladino;
                    case 2: return Mago;
                    case 3: return Barbaro;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        return EscolherInimigo();
                }
                
            }



            void Batalhar()
            {


                EscolherHeroi();
                EscolherInimigo();

                   Heroi heroi= EscolherHeroi();
                     Heroi inimigo = EscolherInimigo();
                while (heroi.Vida > 0 && inimigo.Vida > 0)
                {
                    Console.Clear();

                    Console.WriteLine($"Você escolheu: {heroi.Nome}");
                    Console.WriteLine($"Inimigo escolhido: {inimigo.Nome}");

                    Console.WriteLine("Escolha uma ação:");
                    Console.WriteLine("1 - Atacar");
                    Console.WriteLine("2 - Usar Ataque Especial");
                    Console.WriteLine("3 - Ver Status");
                   


                }







            }


            



            void ExibirMenu()
            {
                Console.Clear();

                ExibirBoasVindas();


                Console.WriteLine("1 - Ver Heróis");
                Console.WriteLine("2 - Batalhar");

                Console.WriteLine("Digite sua escolha:");

                string opcaoEscolhida = Console.ReadLine();

                int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);


                switch (opcaoEscolhidaNum)
                {

                    case 1:ExibirHerois(); break;
                    case 2:Batalhar(); ; break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        ExibirMenu();
                        break;

                }


                
            

      
                
                
            

            
            }
            ExibirMenu();


            
        }
    }
}

