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
            Heroi HeroiEscolhido = null;
            Heroi InimigoEscolhido = null;

            Heroi Ladino = new Ladino();
            Heroi Mago = new Mago("Merlin", 55, 15, 5);
            Heroi Barbaro = new Bárbaro("Tristan", 100, 25, 10);
            void ExibirMenu()
            {
                Console.Clear();

                ExibirBoasVindas();

                int escolha = 0;

                while (escolha != 4)
                {
                    Console.WriteLine("1 - Ver Heróis");
                    Console.WriteLine("2 - Escolher Herói");
                    Console.WriteLine("3 - Escolher Inimigo");
                    Console.WriteLine("4 - Batalhar");

                    Console.WriteLine("Digite sua escolha:");

                    string line = "Heroi:";

                    if (HeroiEscolhido != null)
                    {
                        line += HeroiEscolhido.Nome;
                    }
                    else
                    {
                        line += "sem heroi";
                    }

                    Console.WriteLine(line);
                    string opcaoEscolhida = Console.ReadLine();

                    if (HeroiEscolhido == null || InimigoEscolhido == null)
                    {
                        int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);
                        if (opcaoEscolhidaNum != 4)
                        {
                            escolha = opcaoEscolhidaNum;
                        }
                        else
                        {
                            Console.WriteLine("Você precisa escolher um herói e um inimigo antes de batalhar.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        escolha = int.Parse(opcaoEscolhida);
                    }

                    bool escolherHeroi;

                    switch (escolha)
                    {
                        case 0:
                            break;
                        case 1:
                            ExibirHerois();
                            break;
                        case 2:
                            escolherHeroi = true;
                            HeroiEscolhido = EscolherPersonagem(escolherHeroi);
                            break;
                        case 3:
                            escolherHeroi = false;
                            InimigoEscolhido = EscolherPersonagem(escolherHeroi);
                            break;
                    }
                }

                Batalhar(HeroiEscolhido, InimigoEscolhido);






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
            }


            Heroi EscolherPersonagem(bool escolherHeroi)
            {
                Console.Clear();

                Console.WriteLine("1 - Ladino");
                Console.WriteLine("2 - Mago");
                Console.WriteLine("3 - Bárbaro");

                if (escolherHeroi)
                    Console.WriteLine("Escolha seu Herói:");
                else
                {
                    Console.WriteLine("Escolha o Inimigo:");
                }

                string opcaoEscolhida = Console.ReadLine();
                int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);
                switch (opcaoEscolhidaNum)
                {
                    case 1:
                        return Ladino;

                    case 2:
                        return (Mago);

                    case 3:
                        return (Barbaro);
                    default:

                        Console.WriteLine("Opção inválida! Tente novamente.");
                        return null;
                }

            }


            void Batalhar(Heroi heroi, Heroi inimigo)
            {
                Console.Clear();
                Console.WriteLine($"Iniciando a batalha entre {heroi.Nome} e {inimigo.Nome}");

                Console.WriteLine($"A batalha entre {heroi.Nome} e {inimigo.Nome} começa agora! Clique enter para selecionar seu ataque! ");

                int turnNumber = 0;

                while (heroi.Vida > 0 && inimigo.Vida > 0)
                {
                    OpcoesBatalha(heroi, inimigo);

                    Console.WriteLine($"{inimigo.Nome} esta pronto para atacar");
                    Console.ReadKey();
                    Console.Clear();

                    if (turnNumber % 2 == 0)
                    {
                        inimigo.Atacar(heroi);
                        Console.WriteLine($"{inimigo.Nome} causou {inimigo.Atacar(heroi)} de dano ");
                    }
                    else
                    {
                        inimigo.AtaqueEspecial(heroi);
                        Console.WriteLine($"{inimigo.Nome} usou seu ataque especial causando {inimigo.AtaqueEspecial(heroi)} de dano ");
                    }

                    Console.Clear();
                    Console.WriteLine($"{heroi.Nome} esta com {heroi.Vida} de vida");
                    Console.ReadKey();
                    Console.Clear();

                    turnNumber++;
                }

                if (heroi.Vida <= 0)
                {
                    Console.WriteLine("Você venceu!");
                    Console.ReadKey();
                    ExibirMenu();
                }
                else if (inimigo.Vida <= 0)
                {

                    Console.WriteLine("Você perdeu!");
                    Console.ReadKey();
                    ExibirMenu();
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
  
