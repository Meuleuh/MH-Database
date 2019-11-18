using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MH_Database.Ressources.Pictures.Rarities;

namespace MH_Database.Classes.Elements
{
    class Rarity
    {
        internal enum tag
        {
            Gen_One_Two_Great_Sword = 001,
            Gen_One_Two_Sword_and_Shield = 002,
            Gen_One_Two_Dual_Blades = 003,
            Gen_One_Two_Hammer = 004,
            Gen_One_Two_Hunting_Horn = 005,
            Gen_One_Two_Lance = 006,
            Gen_One_Two_Gunlance = 007,
            Gen_One_Two_Light_Bowgun = 008,
            Gen_One_Two_Heavy_Bowgun = 009,
            Gen_Three_Four_Great_Sword = 010,
            Gen_Three_Four_Long_Sword = 011,
            Gen_Three_Four_Sword_and_Shield = 012,
            Gen_Three_Four_Dual_Blades = 013,
            Gen_Three_Four_Hammer = 014,
            Gen_Three_Four_Hunting_Horn = 015,
            Gen_Three_Four_Lance = 016,
            Gen_Three_Four_Gunlance = 017,
            Gen_Three_Four_Switch_Axe = 018,
            Gen_Three_Four_Charge_Blade = 019,
            Gen_Three_Four_Insect_Glaive = 020,
            Gen_Three_Four_Light_Bowgun = 021,
            Gen_Three_Four_Heavy_Bowgun = 022,
            Gen_Three_Four_Bow = 023,
            Gen_Three_Four_Kinsect_Cut = 024,
            Gen_Three_Four_Kinsect_Blunt = 025,
            Gen_Five_Great_Sword = 026,
            Gen_Five_Long_Sword = 027,
            Gen_Five_Sword_and_Shield = 028,
            Gen_Five_Dual_Blades = 029,
            Gen_Five_Hammer = 030,
            Gen_Five_Hunting_Horn = 031,
            Gen_Five_Lance = 032,
            Gen_Five_Gunlance = 033,
            Gen_Five_Switch_Axe = 034,
            Gen_Five_Charge_Blade = 035,
            Gen_Five_Insect_Glaive = 036,
            Gen_Five_Light_Bowgun = 037,
            Gen_Five_Heavy_Bowgun = 038,
            Gen_Five_Bow = 039,
            Gen_Five_Kinsect_Cut = 040,
            Gen_Five_Kinsect_Blunt = 041
        };

        internal int rarity;
        readonly internal Bitmap icon;

        internal Rarity(int rarity, tag tag)
        {
            Ressources.Pictures.Rarities.Gen1_2.WeaponsIcons weaponsIconsGen1_2 = new Ressources.Pictures.Rarities.Gen1_2.WeaponsIcons();
            Ressources.Pictures.Rarities.Gen3_4.WeaponsIcons weaponsIconsGen3_4 = new Ressources.Pictures.Rarities.Gen3_4.WeaponsIcons();
            this.rarity = rarity;
            switch ((int)tag)
            {
                case 001:
                    icon = weaponsIconsGen1_2.Great_Sword[rarity];
                    break;

                case 002:
                    icon = weaponsIconsGen1_2.Sword_and_Shield[rarity];
                    break;

                case 003:
                    icon = weaponsIconsGen1_2.Dual_Blades[rarity];
                    break;

                case 004:
                    icon = weaponsIconsGen1_2.Hammer[rarity];
                    break;

                case 005:
                    icon = weaponsIconsGen1_2.Hunting_Horn[rarity];
                    break;

                case 006:
                    icon = weaponsIconsGen1_2.Lance[rarity];
                    break;

                case 007:
                    icon = weaponsIconsGen1_2.Gunlance[rarity];
                    break;

                case 008:
                    icon = weaponsIconsGen1_2.Light_Bowgun[rarity];
                    break;

                case 009:
                    icon = weaponsIconsGen1_2.Heavy_Bowgun[rarity];
                    break;

                case 010:
                    icon = weaponsIconsGen3_4.Great_Sword[rarity];
                    break;

                case 011:
                    icon = weaponsIconsGen3_4.Long_Sword[rarity];
                    break;


            }
        }
    }
}
