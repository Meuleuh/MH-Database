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
                    rarity: new Classes.Elements.Rarity(1, Classes.Elements.Rarity.tag.Gen_One_Two_Great_Sword),
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

            }
        }
    }
}
