using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Factionnamespace;

class Armor
{
    public int armorPoints { get; private set; }
    private static int goodGuyArmor = 5;
    private static int badGuyArmor = 10;

    //Definindo ataque de acordo com a facção do personagem
    public Armor(Faction faction)
    {
        if (faction == Faction.badGuy)
        {
            armorPoints = badGuyArmor;
        }
        else
        {
            armorPoints = goodGuyArmor;
        }
    }
}

