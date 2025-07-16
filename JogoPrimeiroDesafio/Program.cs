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

            List<Heroi> HeroisEscolhidos = new List<Heroi>();
            List<Heroi> InimigosEscolhidos = new List<Heroi>();

            Heroi Ladino = new Ladino("Barian", 80, 25, 7);
            Heroi Mago = new Mago("Merlin", 55, 15, 5);
            Heroi Barbaro = new Bárbaro("Tristan", 100, 25, 10);

            void ExibirMenu()
            {
                Console.Clear();

                ExibirBoasVindas();

                Console.WriteLine("1 - Ver Heróis");
                Console.WriteLine("2 - Escolher Herói");
                Console.WriteLine("3 - Escolher Inimigo");
                Console.WriteLine("4 - Batalhar");

                Console.WriteLine("Digite sua escolha:");
                Console.WriteLine($"Heroi:{HeroisEscolhidos.FirstOrDefault()} Inimigo: {InimigosEscolhidos.FirstOrDefault()}");
                string opcaoEscolhida = Console.ReadLine();

                int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

                switch (opcaoEscolhidaNum)
                {

                    case 1: ExibirHerois(); break;
                    case 2: EscolherHeroi(); ; break;
                    case 3: EscolherInimigo(); break;
                    case 4:
                        Batalhar();
                        if (HeroisEscolhidos == null || InimigosEscolhidos == null)
                        {
                            Console.WriteLine("Você precisa escolher um herói e um inimigo antes de batalhar.");
                            Console.ReadKey();
                            ExibirMenu();
                        }
                        else
                        {
                            Batalhar();
                        }

                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        ExibirMenu();
                        break;

                }


            }

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

            void EscolherHeroi()
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
                    case 1:
                        HeroisEscolhidos.Add(Ladino);
                        ExibirMenu(); break;



                    case 2:
                        HeroisEscolhidos.Add(Mago);
                        ExibirMenu(); break;

                    case 3:
                        HeroisEscolhidos.Add(Barbaro);
                        ExibirMenu(); break;
                    default:

                        Console.WriteLine("Opção inválida! Tente novamente.");
                        ExibirMenu();
                        break;




                }

            }

            void EscolherInimigo()
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
                    case 1:
                        InimigosEscolhidos.Add(Ladino);
                        ExibirMenu(); break;

                    case 2:
                        InimigosEscolhidos.Add(Mago)
                            ; ExibirMenu(); break;
                    case 3:
                        InimigosEscolhidos.Add(Barbaro);
                        ExibirMenu(); break;
                    default:

                        Console.WriteLine("Opção inválida! Tente novamente.");
                        ExibirMenu();
                        break;
                }

            }

            void Batalhar()
            {

                Console.Clear();
                Console.WriteLine($"Iniciando a batalha entre {HeroisEscolhidos.FirstOrDefault()} e {InimigosEscolhidos.FirstOrDefault()}");


                Heroi heroi = HeroisEscolhidos.First();
                Heroi inimigo = InimigosEscolhidos.First();


                while (heroi.Vida > 0 && inimigo.Vida > 0)
                {
                    Console.Clear();

                    Console.WriteLine($"A batalha entre {heroi.Nome} e {inimigo.Nome} começa agora! Clique enter para selecionar seu ataque! ");
                    Console.ReadKey();

                    OpcoesBatalha(heroi, inimigo);
                    
                    Console.WriteLine($"{inimigo.Nome} esta pronto para atacar");
                    Console.ReadKey();
                    Console.Clear();
                    inimigo.Atacar(heroi);
                    Console.WriteLine($"{inimigo.Nome} causou {inimigo.Atacar(heroi)} de dano ");
                    Console.Clear();
                    Console.WriteLine($"{heroi.Nome} esta com {heroi.Vida} de vida");
                    Console.ReadKey();
                    Console.Clear();

                    OpcoesBatalha(heroi, inimigo);

                    Console.WriteLine($"{inimigo.Nome} esta {inimigo.Vida} de vida");

                    Console.ReadKey();
                    inimigo.AtaqueEspecial(heroi);
                    Console.WriteLine($"{inimigo.Nome} usou seu ataque especial causando {inimigo.AtaqueEspecial(heroi)} de dano ");

                    if (heroi.Vida <= 0)
                    {
                        Console.WriteLine("Você venceu!");
                        Console.ReadKey();
                        ExibirMenu();
                    }else if (inimigo.Vida <= 0)
                    {

                        Console.WriteLine("Você perdeu!");
                        Console.ReadKey();
                        ExibirMenu();
                    }
                    


                }



            }

            void OpcoesBatalha(Heroi heroi, Heroi inimigo)
            {


                Console.Clear();
                Console.WriteLine("\nEscolha sua ação!!");

                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Especial");

                string opcaoEscolhida = Console.ReadLine();
                int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

                switch (opcaoEscolhidaNum)
                {

                    case 1:
                        heroi.Atacar(inimigo);
                        Console.WriteLine($"Você causou {heroi.Atacar(inimigo)} de dano");

                        Console.WriteLine($"{inimigo.Nome} esta com {inimigo.Vida} de vida!");

                        break;

                    case 2:
                        heroi.AtaqueEspecial(inimigo);
                        Console.WriteLine(heroi.AtaqueEspecial(inimigo));
                        Console.WriteLine($"{inimigo.Nome} esta com {inimigo.Vida} de vida!");
                        break;

                    default:
                        Console.WriteLine("Escolha inválida!");
                        break;

                }






            }

            ExibirMenu();

        }
    }
}
  
