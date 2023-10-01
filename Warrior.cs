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

    private static int GoodGuyStartingHealth = 20;
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

    //public void Attack(Warrior enemy)
    //{ 
    //    enemy.health -= weapon.damage;
    //    if (enemy.health > 0)
    //    {
    //        Console.WriteLine("Atacar novamente?S/N");
    //        Attack(enemy);
            
    //    }
    //    else
    //    {

    //        Console.WriteLine("Você derrotou o inimigo");

    //    }
    //}
    public void Attack(Warrior enemy)
    {
        enemy.health -= weapon.damage;
        if (enemy.health > 0)
        {
            Console.WriteLine("Atacar novamente?S/N");
            Attack(enemy);

        }
        else
        {

            Console.WriteLine("Você derrotou o inimigo");

        }
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