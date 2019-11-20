using System.Drawing;

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
            Ressources.Pictures.Rarities.MHW.WeaponsIcons weaponsIconsGen5 = new Ressources.Pictures.Rarities.MHW.WeaponsIcons();
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

                case 012:
                    icon = weaponsIconsGen3_4.Sword_and_Shield[rarity];
                    break;

                case 013:
                    icon = weaponsIconsGen3_4.Dual_Blades[rarity];
                    break;

                case 014:
                    icon = weaponsIconsGen3_4.Hammer[rarity];
                    break;

                case 015:
                    icon = weaponsIconsGen3_4.Hunting_Horn[rarity];
                    break;

                case 016:
                    icon = weaponsIconsGen3_4.Lance[rarity];
                    break;

                case 017:
                    icon = weaponsIconsGen3_4.Gunlance[rarity];
                    break;

                case 018:
                    icon = weaponsIconsGen3_4.Switch_Axe[rarity];
                    break;

                case 019:
                    icon = weaponsIconsGen3_4.Charge_Blade[rarity];
                    break;

                case 020:
                    icon = weaponsIconsGen3_4.Insect_Glaive[rarity];
                    break;

                case 021:
                    icon = weaponsIconsGen3_4.Light_Bowgun[rarity];
                    break;

                case 022:
                    icon = weaponsIconsGen3_4.Heavy_Bowgun[rarity];
                    break;

                case 023:
                    icon = weaponsIconsGen3_4.Bow[rarity];
                    break;

                case 024:
                    icon = weaponsIconsGen3_4.Kinsect.Cutting;
                    break;

                case 025:
                    icon = weaponsIconsGen3_4.Kinsect.Blunt;
                    break;

                case 026:
                    icon = weaponsIconsGen5.Great_Sword[rarity];
                    break;

                case 027:
                    icon = weaponsIconsGen5.Long_Sword[rarity];
                    break;

                case 028:
                    icon = weaponsIconsGen5.Sword_and_Shield[rarity];
                    break;

                case 029:
                    icon = weaponsIconsGen5.Dual_Blades[rarity];
                    break;

                case 030:
                    icon = weaponsIconsGen5.Hammer[rarity];
                    break;

                case 031:
                    icon = weaponsIconsGen5.Hunting_Horn[rarity];
                    break;

                case 032:
                    icon = weaponsIconsGen5.Lance[rarity];
                    break;

                case 033:
                    icon = weaponsIconsGen5.Gunlance[rarity];
                    break;

                case 034:
                    icon = weaponsIconsGen5.Switch_Axe[rarity];
                    break;

                case 035:
                    icon = weaponsIconsGen5.Charge_Blade[rarity];
                    break;

                case 036:
                    icon = weaponsIconsGen5.Insect_Glaive[rarity];
                    break;

                case 037:
                    icon = weaponsIconsGen5.Light_Bowgun[rarity];
                    break;

                case 038:
                    icon = weaponsIconsGen5.Heavy_Bowgun[rarity];
                    break;

                case 039:
                    icon = weaponsIconsGen5.Bow[rarity];
                    break;

                case 040:
                    icon = weaponsIconsGen5.Kinsect.Cutting[rarity];
                    break;

                case 041:
                    icon = weaponsIconsGen5.Kinsect.Blunt[rarity];
                    break;
            }
        }
    }
}
