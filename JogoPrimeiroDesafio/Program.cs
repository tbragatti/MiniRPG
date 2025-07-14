using JogoPrimeiroDesafio;
using JogoPrimeiroDesafio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
                    case 1: Console.WriteLine("Você escolheu o Bárbaro!"); break;

                    case 2: Console.WriteLine("Você escolheu o Mago!"); break;
                    case 3: Console.WriteLine("Você escolheu o Ladino!"); break;
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

