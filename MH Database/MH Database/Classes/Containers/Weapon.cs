using System.Drawing;
using MH_Database.Classes.MultiLang;
using MH_Database.Classes.Elements;

namespace MH_Database.Classes.Containers
{
    class Weapon
    {
        internal MultiLangWeapon name;
        internal Rarity rarity;
        internal Bitmap icon;
        internal int attack;
        internal int true_attack;
        internal int defense;
        internal int affinity;
        internal int[] slots = new int[3]
        {
            0, //Slot 1
            0, //Slot 2
            0  //Slot 3
        };
        //internal Element element //Will be implemented with the Element class addition
        //internal Sharpness[] baseSharpness = new Sharpness[4]; //Will be implemented with the Shaprness class addition //Will only contain two sharpness bar in games where it is only possible to have 2
        //internal Craft craft //Will be implemented with the Craft class
        //internal List<Upgrades> upgrades = new List<Upgrades>(); //Will be implemented with the Upgrades class

        Weapon(MultiLangWeapon name, Rarity rarity, Bitmap icon, int attack, int true_attack, int defense, int affinity, int[] slots)
        {
            this.name = name;
            this.rarity = rarity;
            this.icon = icon;
            this.attack = attack;
            this.true_attack = true_attack;
            this.defense = defense;
            this.affinity = affinity;
            this.slots = slots;
        }
    }
}
