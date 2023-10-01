using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using Factionnamespace;

class Program
{
    public void Menu(Program programa)
    {

        //opções menu
        Console.WriteLine("MENU:");
        Console.WriteLine("1. Criar guerreiro.");
        Console.WriteLine("2. Sair do jogo.");
        int opcaoMenu = int.Parse(Console.ReadLine());

        if (opcaoMenu == 1)
        {
            // Aguarda por 3segundos e limpa o console
            Thread.Sleep(1000);
            Console.Clear();

            //criando o guerreiro e exibindo infos
            Warrior guerreiro = programa.CreateWarrior();
            Console.WriteLine("Seu guerreiro foi montado:");
            Console.WriteLine("   .-.");
            Console.WriteLine("| (@ @)");
            Console.WriteLine(" \\ \\-/  Nome: " + guerreiro.name + " (" + guerreiro.faction + ") Vida: " + guerreiro.health);
            Console.WriteLine("  \\/ \\");
            Console.WriteLine("   \\ /\\");
            Console.WriteLine("   _H_ \\");

            //criando o inimigo e exibindo infos
            Warrior inimigo = programa.CreateEnemy(guerreiro);

            //Luta
            Console.WriteLine("deseja lutar?S/N");
            string lutar = Console.ReadLine();
               
            if (lutar.ToUpper() == "S")
            {
                while (inimigo.health > 0)
                {
                    //imprimindo inimigo a esquerda da tela.
                    Console.SetCursorPosition(Console.WindowWidth - "ooooooooooooo".Length, Console.CursorTop);
                    Console.WriteLine(inimigo.name);
                    Console.SetCursorPosition(Console.WindowWidth - "ooooooooooooo".Length, Console.CursorTop);
                    Console.WriteLine(" .-.");
                    Console.SetCursorPosition(Console.WindowWidth - "ooooooooooooo".Length, Console.CursorTop);
                    Console.WriteLine("(o o)");
                    Console.SetCursorPosition(Console.WindowWidth - "ooooooooooooo".Length, Console.CursorTop);
                    Console.WriteLine("| O \\");
                    Console.SetCursorPosition(Console.WindowWidth - "ooooooooooooo".Length, Console.CursorTop);
                    Console.WriteLine(" \\   \\");
                    Console.SetCursorPosition(Console.WindowWidth - "ooooooooooooo".Length, Console.CursorTop);
                    Console.WriteLine("  \\   \\");
                    Console.SetCursorPosition(Console.WindowWidth - "ooooooooooooo".Length, Console.CursorTop);
                    Console.WriteLine("   `~~~'");
                    Console.SetCursorPosition(Console.WindowWidth - "ooooooooooooo".Length, Console.CursorTop);
                    Console.WriteLine("Vida:" + inimigo.health);

                    //ataque
                    guerreiro.Attack(inimigo);
                    Console.WriteLine("Nome: " + inimigo.name + " (" + inimigo.faction + ") Saúde: " + guerreiro.health);

                    Console.WriteLine("deseja lutar?S/N");
                    lutar = Console.ReadLine();
                }

            }
            else if (lutar.ToUpper() == "N")
            {
                Console.WriteLine("Então até uma próxima" + guerreiro.name + "...");
                Environment.Exit(0);
            }
                

        }
        else if (opcaoMenu == 2)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Opção invalida");
            Environment.Exit(0);
            //Menu(programa);
        }

    }

    public Warrior CreateWarrior()
    {
        //variaveis temporarias para criar o guerreiro com nome e facção
        Console.WriteLine("Nome do guerreiro:");
        string nameWarrior = Console.ReadLine();

        Console.WriteLine("Digite 1 para guerreiro do bem e 2 para guerreiro do mal");
        int opcao = int.Parse(Console.ReadLine());

        Faction factionWarrior = Faction.noFaction;
        if (opcao == 1)
        {
            factionWarrior = Faction.goodGuy;
        }
        else if (opcao == 2)
        {
            factionWarrior = Faction.badGuy;
        }
        else
        {
            Console.WriteLine("Esta opção não é permitida");
            factionWarrior = Faction.noFaction;
            Console.WriteLine("Digite 1 para guerreiro do bem e 2 para guerreiro do mal");
            //opcao = int.Parse(Console.ReadLine());
        }

        //Criação do guerreiro
        Warrior guerreiro = new Warrior(nameWarrior, factionWarrior);
        return guerreiro;
    }

    public Warrior CreateEnemy(Warrior guerreiro)
    {
        Warrior enemy = new Warrior("Inimigo", Faction.noFaction);
        if (guerreiro.faction == Faction.badGuy)
        {
            enemy.faction = Faction.goodGuy;
        }
        else
        {
            enemy.faction = Faction.badGuy;
        }
        return enemy;
    }

    //public void Action() { }
    static void Main(string[] args)
    {
        //Criando o objeto programa
        Program programa = new Program();

        //Entrada do jogo
        Console.WriteLine("Bem vindo a:");
        Console.WriteLine("                         _            ");
        Console.WriteLine("                        (_)           ");
        Console.WriteLine("__      ____ _ _ __ _ __ _  ___  _ __");
        Console.WriteLine("\\ \\ /\\ / / _` | '__| '__| |/ _ \\| '__|");
        Console.WriteLine(" \\ V  V / (_| | |  | |  | | (_) | |   ");
        Console.WriteLine("  \\_/\\_/ \\__,_|_|  |_|  |_|\\___/|_|   ");

        // Aguarda por 1segundos e limpa o console
        Thread.Sleep(1000); 
        Console.Clear();

        //Chamando menu de opções
        programa.Menu(programa);

        
        //Console.WriteLine("Bem vindo a:");



        
       


        

        //Warrior inimigo = programa.CreateEnemy(guerreiro);
        


    
    }
}

