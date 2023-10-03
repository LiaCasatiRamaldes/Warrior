using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Factionnamespace;
//using Warrior;

class Warrior
{
    public Faction faction { get; set; }
    public string name { get; private set; }
    public int health { get; private set; }
    public bool isAlive { get; private set; }
    public Weapon weapon { get; private set; }
    public Armor armor { get; private set; }

    private static int GoodGuyStartingHealth = 200;
    private static int BadGuyStartingHealth = 100;

    //construtor com nome e facção do personagem
    public Warrior(string nameChose, Faction factionChose)
    {
        name = nameChose;
        if (factionChose == Faction.badGuy)
        {
            faction = Faction.badGuy;
            health = BadGuyStartingHealth;
            weapon = new Weapon(Faction.badGuy);
            armor = new Armor(Faction.badGuy);

        }
        else
        {
            faction = Faction.goodGuy;
            health = GoodGuyStartingHealth;
            weapon = new Weapon(Faction.goodGuy);
            armor = new Armor(Faction.goodGuy);

        }

    }

    public void Defense(Warrior enemy)
    {

    }
    public void Attack(Warrior enemy)
    {
        //Luta
        Console.WriteLine("Lutar?S/N");
        string lutar = Console.ReadLine();

        if (lutar.ToUpper() == "S")
        {
            while (enemy.health > 0)
            {
                //ataque
                Console.WriteLine("Ataque de: " + weapon.damage);
                enemy.health -= weapon.damage;

                //imprimindo inimigo a esquerda da tela.
                Console.SetCursorPosition(Console.WindowWidth - "ooooooooooooo".Length, Console.CursorTop);
                Console.WriteLine(enemy.name);
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
                Console.WriteLine("Vida:" + enemy.health);

                Console.WriteLine("Oh não ele te atacou de volta com " + enemy.weapon.damage + " de dano");
                this.health -= enemy.weapon.damage;

                Console.WriteLine(name);
                Console.WriteLine("   .-.");
                Console.WriteLine("| (@ @)");
                Console.WriteLine(" \\ \\-/");
                Console.WriteLine("  \\/ \\");
                Console.WriteLine("   \\ /\\");
                Console.WriteLine("   _H_ \\");
                Console.WriteLine("Vida: " + health);
                Attack(enemy);
                Attack(this);

            }
            
        }
        else if (lutar.ToUpper() == "N")
        {
            Console.WriteLine("Então até uma próxima" + name + "...");
            Environment.Exit(0);
        }
        else { Environment.Exit(0); }
    }
}



//enemy
// .-.
//(o o) 
//| O \
// \   \
//  \   \
//   `~~~'

//you
//   .-.
//| (@ @)
// \ \-/
//  \/ \
//   \ /\
//   _H_ \