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
            Console.WriteLine("Ai vem o seu inimigo");

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

            inimigo.Attack(guerreiro);


            //Console.WriteLine("Antes de Lutar é bom colocar uma armadura!");
            //Console.WriteLine("Colocar Armadura de "+ guerreiro.armor.armorPoints +" de defesa?S/N");
            //string defesa = Console.ReadLine();

            //if(defesa.ToUpper() == "S")
            //{
            //    inimigo.weapon.damage -= guerreiro.armor.armorPoints;
            //    inimigo.Attack(guerreiro);
            //}
            //else if (defesa.ToUpper() == "N")
            //{
            //    Console.WriteLine("Acabo com o inimigo na mão!");
            //    guerreiro.Attack(inimigo);

            //}
            //else
            //{
            //    Console.WriteLine("Opção invalida");
            //    Environment.Exit(0);
            //}

            
            if (inimigo.health <= 0)
            {
                Console.WriteLine("Você derrotou o inimigo");
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
            Environment.Exit(0);
        }

        //Criação do guerreiro
        Warrior guerreiro = new Warrior(nameWarrior, factionWarrior);
        return guerreiro;
    }

    public Warrior CreateEnemy(Warrior guerreiro)
    {
        Faction enemyFaction;
        if (guerreiro.faction == Faction.badGuy)
        {
            enemyFaction = Faction.goodGuy;
        }
        else 
        {
            enemyFaction = Faction.badGuy;
        }
        Warrior enemy = new Warrior("Inimigo", enemyFaction);

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

    
    }
}

