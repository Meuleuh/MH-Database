using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH_Database.Classes
{
    class Item
    {
        //Material struct
        internal struct Material
        {
            int quantity;
            Item item;

            internal Material(int quantity, Item item)
            {
                this.quantity = quantity;
                this.item = item;
            }
        }

        //Variables
        internal MultiLang name;
        internal MultiLang description;
        internal MultiLang howToGet;
        internal int rarity;
        internal int maxCarry;
        internal int sellPrice;
        internal Bitmap icon;
        internal Material[] combination;

        //Constructor
        internal Item(MultiLang name = null, MultiLang description = null, MultiLang howToGet = null, int rarity = 1, int maxCarry = 1, int sellPrice = 0, Bitmap icon = null, Material[] combination = null)
        {
            this.name = name ?? new MultiLang();
            this.description = description ?? new MultiLang();
            this.howToGet = howToGet ?? new MultiLang();
            this.rarity = rarity;
            this.maxCarry = maxCarry;
            this.sellPrice = sellPrice;
            this.icon = icon;
            this.combination = combination;
        }
    }
}
