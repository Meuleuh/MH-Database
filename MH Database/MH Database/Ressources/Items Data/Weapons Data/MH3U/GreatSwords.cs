using MH_Database.Classes.Containers;

namespace MH_Database.Ressources.Items_Data
{
    partial class Weapons
    {
        internal partial class MonsterHunter3U
        {
            internal class GreatSwords
            {
                private static readonly MultiLangTexts.Game_Elements.Weapons.MonsterHunter3U.GreatSwords greatSwordsName = new MultiLangTexts.Game_Elements.Weapons.MonsterHunter3U.GreatSwords();

                //Iron Sword
                internal readonly Weapon ironSword = new Weapon
                    (
                    name: greatSwordsName.ironSword,
                    rarity: new Classes.Elements.Rarity(1, Classes.Elements.Rarity.tag.Gen_Three_Four_Great_Sword),
                    picture: null,
                    attack: 336,
                    true_attack: 70,
                    defense: 0,
                    affinity: 0,
                    slots: new int[3]
                    {
                            0,
                            0,
                            0
                    }
                    );

                //Iron Sword+
                internal readonly Weapon ironSwordPlus = new Weapon
                    (
                    name: greatSwordsName.ironSwordPlus,
                    rarity: new Classes.Elements.Rarity(1, Classes.Elements.Rarity.tag.Gen_Three_Four_Great_Sword),
                    picture: null,
                    attack: 384,
                    true_attack: 80,
                    defense: 0,
                    affinity: 0,
                    slots: new int[3]
                    {
                            0,
                            0,
                            0
                    }
                    );

                //Buster Sword
                internal readonly Weapon busterSword = new Weapon
                    (
                    name: greatSwordsName.busterSword,
                    rarity: new Classes.Elements.Rarity(1, Classes.Elements.Rarity.tag.Gen_Three_Four_Great_Sword),
                    picture: null,
                    attack: 432,
                    true_attack: 90,
                    defense: 0,
                    affinity: 0,
                    slots: new int[3]
                    {
                        0,
                        0,
                        0
                    }
                    );

                //Buster Sword+
                internal readonly Weapon busterSwordPlus = new Weapon
                    (
                    name: greatSwordsName.busterSwordPlus,
                    rarity: new Classes.Elements.Rarity(1, Classes.Elements.Rarity.tag.Gen_Three_Four_Great_Sword),
                    picture: null,
                    attack: 528,
                    true_attack: 110,
                    defense: 0,
                    affinity: 0,
                    slots: new int[3]
                    {
                        0,
                        0,
                        0
                    }
                    );

                //Buster Blade
                internal readonly Weapon busterBlade = new Weapon
                    (
                    name: greatSwordsName.busterBlade,
                    rarity: new Classes.Elements.Rarity(3, Classes.Elements.Rarity.tag.Gen_Three_Four_Great_Sword),
                    picture: null,
                    attack: 624,
                    true_attack: 130,
                    defense: 0,
                    affinity: 0,
                    slots: new int[3]
                    {
                        0,
                        0,
                        0
                    }
                    );

                //Ravager Blade
                internal readonly Weapon ravagerBlade = new Weapon
                    (
                    name: greatSwordsName.ravagerBlade,
                    rarity: new Classes.Elements.Rarity(3, Classes.Elements.Rarity.tag.Gen_Three_Four_Great_Sword),
                    picture: null,
                    attack: 672,
                    true_attack: 140,
                    defense: 12,
                    affinity: 5,
                    slots: new int[3]
                    {
                        1,
                        0,
                        0
                    }
                    );
            }
        }
    }
}
