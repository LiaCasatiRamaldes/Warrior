using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using Factionnamespace;

class Program
{
    public void Menu()
    {
        //Console.WriteLine("Bem vindo a:");
        //Console.WriteLine("                         _            ");
        //Console.WriteLine("                        (_)           ");
        //Console.WriteLine("__      ____ _ _ __ _ __ _  ___  _ __");
        //Console.WriteLine("\ \ /\ / / _` | '__| '__| |/ _ \| '__|");
        //Console.WriteLine(" \ V  V / (_| | |  | |  | | (_) | |   ");
        //Console.WriteLine("  \_/\_/ \__,_|_|  |_|  |_|\___/|_|   ");


        Console.WriteLine("Criar guerreiro:");
        int opcaoMenu = int.Parse(Console.ReadLine());
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
        
        Program programa = new Program();
        Warrior guerreiro = programa.CreateWarrior();
        Console.WriteLine("Seu guerreiro foi montado:");
        Console.WriteLine("Nome: " + guerreiro.name + " (" + guerreiro.faction + ") Saúde: " + guerreiro.health);

        Warrior inimigo = programa.CreateEnemy(guerreiro);

        Console.WriteLine("deseja lutar?S/N");
        string lutar = Console.ReadLine();

        if (lutar == "S")
        {  
            guerreiro.Attack(inimigo);
        }
        else if (lutar == "N")
        {
            Console.WriteLine("Então até uma próxima" + guerreiro.name);
        }

        //Warrior inimigo = programa.CreateEnemy(guerreiro);
        //Console.WriteLine("Nome: " + inimigo.name + " (" + inimigo.faction + ") Saúde: " + guerreiro.health);

        

    }
}

