using MH_Database.Classes.Elements;
using MH_Database.Classes.MultiLang;
using System.Drawing;

namespace MH_Database.Classes.Containers
{
    class Weapon
    {
        internal MultiLangWeapon name;
        internal MultiLangDescription description; //Need to be added to the initializer and to each weapons
        internal Rarity rarity;
        internal Bitmap picture;
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

        internal Weapon(MultiLangWeapon name, Rarity rarity, Bitmap picture, int attack, int true_attack, int defense, int affinity, int[] slots)
        {
            this.name = name;
            this.rarity = rarity;
            this.picture = picture;
            this.attack = attack;
            this.true_attack = true_attack;
            this.defense = defense;
            this.affinity = affinity;
            this.slots = slots;
        }
    }
}
