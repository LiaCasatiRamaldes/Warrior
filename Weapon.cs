//using Factionnamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Weapon
{
    public Faction faction { get; private set; }
    public int damage { get; private set; }
    private static int goodGuyDamage = 10;
    private static int badGuyDamage = 7;

    //Definindo dano de acordo com a facção do personagem
    public Weapon(Faction faction)
    {
        if (faction == Faction.badGuy)
        {
            damage = badGuyDamage;
        }
        else
        {
            damage = goodGuyDamage;
        }
    }

}

