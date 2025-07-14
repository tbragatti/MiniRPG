using JogoPrimeiroDesafio;
using JogoPrimeiroDesafio.Classes;
using JogoPrimeiroDesafio.Personagem;
using System;
using System.Collections.Generic;
using System.Linq;
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

            void ExibirBoasVindas()
            {
                Console.WriteLine(@"
█▄▄ █▀▀ █▀▄▀█   █░█ █ █▄░█ █▀▄ █▀█ █▀   ▄▀█ █▀█   █▀▄▀█ █ █▄░█ █   █▀█ █▀█ █▀▀
█▄█ ██▄ █░▀░█   ▀▄▀ █ █░▀█ █▄▀ █▄█ ▄█   █▀█ █▄█   █░▀░█ █ █░▀█ █   █▀▄ █▀▀ █▄█");
                Console.WriteLine("*******************************************************************************");


            }

            void CriarBarbaro()
            {
                Console.Clear();
                Console.WriteLine("Tristan aparece para batalhar novamente!");
                Heroi Barbaro = new Bárbaro("Tristan", 100, 25, 10);



            }
            void CriarMago()
            {
                Console.Clear();
                Console.WriteLine("Merlin ressurge para o combate");
                Heroi Mago = new Mago("Merlin", 55, 15, 5);

            }

            void CriarLadino()
            {
                Console.Clear();
                Console.WriteLine("Lenor surge das sombras para a batalha");
                Heroi Ladino = new Ladino("Ladino", 80, 25, 7);
            }

            void MenuDePersonagens()
            {
                Console.Clear();
                Console.WriteLine("\nEscolha Dois personagens para batalhar:");
                Console.WriteLine("1 - Bárbaro");
                Console.WriteLine("2 - Mago");
                Console.WriteLine("3 - Ladino");
                Console.WriteLine("Digite sua escolha:");
                string opcaoPersonagem = Console.ReadLine();
                int opcaoPersonagemNum = int.Parse(opcaoPersonagem);
                switch (opcaoPersonagemNum)
                {
                    case 1: CriarBarbaro(); break;
                    case 2: CriarMago(); break;
                    case 3: CriarLadino(); break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        MenuDePersonagens();
                        break;
                }




            }

            void ExibirMenu()
            {


                ExibirBoasVindas();



                Console.WriteLine("1 - Batalhar");
                Console.WriteLine("2 - Escolher Personagem");
                Console.WriteLine("Digite sua escolha:");

                string opcaoEscolhida = Console.ReadLine();

                int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);


                switch (opcaoEscolhidaNum)
                {
                    case 1: Console.WriteLine("Batalhar"); break;

                    case 2: MenuDePersonagens(); break;

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

