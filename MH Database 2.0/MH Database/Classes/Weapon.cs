using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MH_Database.Classes
{
    class Weapon
    {
        //Slots enum
        internal enum slot 
        { 
            None = default,
            Empty,
            LevelOne,
            LevelTwo,
            LevelThree,
            LevelFour
        }

        //Elderseal enum
        internal enum eldersealEnum
        {
            None,
            Low,
            Medium,
            High
        }

        //Material struct
        internal struct Material
        {
            int quantity;
            Item item;
        }

        //Variables
        internal MultiLang name;
        internal int attack;
        internal StatusEffect statusEffect;
        internal int affinity;
        internal SharpnessBar sharpnessBar;
        internal slot[] slots = new slot[3];
        internal int defense;
        internal eldersealEnum elderseal;
        internal int rarity;
        internal MultiLang description;
        internal bool buyableFromStore;
        internal int buyingCost;
        internal Material[] creationMaterials;
        internal int creationCost;
        internal Material[] upgradeMaterials;
        internal int upgradeCost;
        internal Bitmap picture;
        internal Bitmap icon;

        //Constructor
        internal Weapon(MultiLang name = null, int attack = 0, StatusEffect statusEffect = null, int affinity = 0, SharpnessBar sharpnessBar = null, slot[] slots = null, int defense = 0, eldersealEnum elderseal = eldersealEnum.None, int rarity = 1, MultiLang description = null, bool buyableFromStore = false, int buyingCost = 0, Material[] creationMaterials = null, int creationCost = 0, Material[] upgradeMaterials = null, int upgradeCost = 0, Bitmap picture = null, Bitmap icon = null)
        {
            this.name = name ?? new MultiLang();
            this.attack = attack;
            this.statusEffect = statusEffect ?? new StatusEffect();
            this.affinity = affinity;
            this.sharpnessBar = sharpnessBar ?? new SharpnessBar();
            this.slots = slots ?? new slot[3]
            {
                slot.None,
                slot.None,
                slot.None
            };
            this.defense = defense;
            this.elderseal = elderseal;
            this.rarity = rarity;
            this.description = new MultiLang();
            this.buyableFromStore = buyableFromStore;
            this.buyingCost = buyingCost;
            this.creationMaterials = creationMaterials;
            this.creationCost = creationCost;
            this.upgradeMaterials = upgradeMaterials;
            this.upgradeCost = upgradeCost;
            this.picture = picture;
            this.picture = icon;
        }
    }
}
