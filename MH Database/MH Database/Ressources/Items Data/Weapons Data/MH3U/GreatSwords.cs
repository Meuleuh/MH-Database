using MH_Database.Classes.Containers;

namespace MH_Database.Ressources.Items_Data
{
    partial class Weapons
    {
        internal partial class MonsterHunter3U
        {
            internal class GreatSwords
            {
                //////////////////
                // Index needed //
                //////////////////

                //Look for the MultiLangWeapon database linked to those sword specificly
                private static readonly MultiLangTexts.Game_Elements.Weapons.MonsterHunter3U.GreatSwords greatSwordsName = new MultiLangTexts.Game_Elements.Weapons.MonsterHunter3U.GreatSwords();

                ///////////////////////
                // Contraption tools //
                ///////////////////////

                //Index of the rarities for this type of weapon and this generation, allowing useful contraptions upon setting up stats and avoiding creating hundreads of rarity instances which could end up loading memory more than intended
                private static readonly Classes.Elements.Rarity[] rarityIcon =
                    {
                    null,
                    new Classes.Elements.Rarity(1, Classes.Elements.Rarity.tag.Gen_Three_Four_Great_Sword),
                    new Classes.Elements.Rarity(2, Classes.Elements.Rarity.tag.Gen_Three_Four_Great_Sword),
                    new Classes.Elements.Rarity(3, Classes.Elements.Rarity.tag.Gen_Three_Four_Great_Sword),
                    new Classes.Elements.Rarity(4, Classes.Elements.Rarity.tag.Gen_Three_Four_Great_Sword),
                    new Classes.Elements.Rarity(5, Classes.Elements.Rarity.tag.Gen_Three_Four_Great_Sword),
                    new Classes.Elements.Rarity(6, Classes.Elements.Rarity.tag.Gen_Three_Four_Great_Sword),
                    new Classes.Elements.Rarity(7, Classes.Elements.Rarity.tag.Gen_Three_Four_Great_Sword),
                    new Classes.Elements.Rarity(8, Classes.Elements.Rarity.tag.Gen_Three_Four_Great_Sword),
                    new Classes.Elements.Rarity(9, Classes.Elements.Rarity.tag.Gen_Three_Four_Great_Sword),
                    new Classes.Elements.Rarity(10, Classes.Elements.Rarity.tag.Gen_Three_Four_Great_Sword)
                };

                //Index of possibles slots, allowing useful contraptions upon setting up slots and avoiding creating hundreads of different array while those const are enough
                private static readonly int[][] slots = new int[4][]
                {
                    new int[3] {0, 0, 0 },
                    new int[3] {1, 0, 0 },
                    new int[3] {1, 1, 0 },
                    new int[3] {1, 1, 1 }
                };

                ///////////////////////////////////////////
                // Monster Hunter 3 Ultimate Greatswords //
                ///////////////////////////////////////////

                //Iron Sword
                internal readonly Weapon ironSword = new Weapon
                    (
                    name: greatSwordsName.ironSword,
                    rarity: rarityIcon[1],
                    picture: null,
                    attack: 336,
                    true_attack: 70,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Iron Sword+
                internal readonly Weapon ironSwordPlus = new Weapon
                    (
                    name: greatSwordsName.ironSwordPlus,
                    rarity: rarityIcon[1],
                    picture: null,
                    attack: 384,
                    true_attack: 80,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Buster Sword
                internal readonly Weapon busterSword = new Weapon
                    (
                    name: greatSwordsName.busterSword,
                    rarity: rarityIcon[1],
                    picture: null,
                    attack: 432,
                    true_attack: 90,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Buster Sword+
                internal readonly Weapon busterSwordPlus = new Weapon
                    (
                    name: greatSwordsName.busterSwordPlus,
                    rarity: rarityIcon[1],
                    picture: null,
                    attack: 528,
                    true_attack: 110,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Buster Blade
                internal readonly Weapon busterBlade = new Weapon
                    (
                    name: greatSwordsName.busterBlade,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 624,
                    true_attack: 130,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Ravager Blade
                internal readonly Weapon ravagerBlade = new Weapon
                    (
                    name: greatSwordsName.ravagerBlade,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 672,
                    true_attack: 140,
                    defense: 12,
                    affinity: 5,
                    slots: slots[1]
                    );

                //Ravager Blade+
                internal readonly Weapon ravagerBladePlus = new Weapon
                    (
                    name: greatSwordsName.ravagerBladePlus,
                    rarity: rarityIcon[4],
                    picture: null,
                    attack: 768,
                    true_attack: 160,
                    defense: 16,
                    affinity: 10,
                    slots: slots[1]
                    );

                //Lacerator Blade
                internal readonly Weapon laceratorBlade = new Weapon
                    (
                    name: greatSwordsName.laceratorBlade,
                    rarity: rarityIcon[8],
                    picture: null,
                    attack: 1056,
                    true_attack: 220,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Devastator Blade
                internal readonly Weapon devastatorBlade = new Weapon
                    (
                    name: greatSwordsName.devastatorBlade,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1200,
                    true_attack: 250,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Chrome Razor
                internal readonly Weapon chromeRazor = new Weapon
                    (
                    name: greatSwordsName.chromeRazor,
                    rarity: rarityIcon[8],
                    picture: null,
                    attack: 1008,
                    true_attack: 210,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Chrome Quietus
                internal readonly Weapon chromeQuietus = new Weapon
                    (
                    name: greatSwordsName.chromeQuietus,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1152,
                    true_attack: 240,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Brazenwall
                internal readonly Weapon brazenwall = new Weapon
                    (
                    name: greatSwordsName.brazenwall,
                    rarity: rarityIcon[4],
                    picture: null,
                    attack: 912,
                    true_attack: 190,
                    defense: 20,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Crimsonwall
                internal readonly Weapon crimsonWall = new Weapon
                    (
                    name: greatSwordsName.crimsonwall,
                    rarity: rarityIcon[6],
                    picture: null,
                    attack: 1104,
                    true_attack: 230,
                    defense: 25,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Cragscliff
                internal readonly Weapon cragscliff = new Weapon
                    (
                    name: greatSwordsName.cragscliff,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1296,
                    true_attack: 270,
                    defense: 31,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Goliath's Scream
                internal readonly Weapon goliathsScream = new Weapon
                    (
                    name: greatSwordsName.goliathsScream,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1440,
                    true_attack: 300,
                    defense: 35,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Hidden Blade
                internal readonly Weapon hiddenBlade = new Weapon
                    (
                    name: greatSwordsName.hiddenBlade,
                    rarity: rarityIcon[6],
                    picture: null,
                    attack: 864,
                    true_attack: 180,
                    defense: 0,
                    affinity: 25,
                    slots: slots[1]
                    );

                //Dark of Night
                internal readonly Weapon darkOfNight = new Weapon
                    (
                    name: greatSwordsName.darkOfNight,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1008,
                    true_attack: 210,
                    defense: 0,
                    affinity: 30,
                    slots: slots[1]
                    );

                //Avidya Great Sword
                internal readonly Weapon avidyaGreatSword = new Weapon
                    (
                    name: greatSwordsName.avidyaGreatSword,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1104,
                    true_attack: 230,
                    defense: 0,
                    affinity: 40,
                    slots: slots[1]
                    );

                //Type 41 Wyvernator
                internal readonly Weapon type41Wyvernator = new Weapon
                    (
                    name: greatSwordsName.type41Wyvernator,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 672,
                    true_attack: 140,
                    defense: 5,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Remalgalypse
                internal readonly Weapon remalgalypse = new Weapon
                    (
                    name: greatSwordsName.remalgalypse,
                    rarity: rarityIcon[4],
                    picture: null,
                    attack: 768,
                    true_attack: 160,
                    defense: 10,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Remalgagorgon
                internal readonly Weapon remalgagorgon = new Weapon
                    (
                    name: greatSwordsName.remalgagorgon,
                    rarity: rarityIcon[8],
                    picture: null,
                    attack: 1056,
                    true_attack: 220,
                    defense: 15,
                    affinity: 0,
                    slots: slots[3]
                    );

                //Rugged Great Sword
                internal readonly Weapon ruggedGreatSword = new Weapon
                    (
                    name: greatSwordsName.ruggedGreatSword,
                    rarity: rarityIcon[1],
                    picture: null,
                    attack: 528,
                    true_attack: 110,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Chieftain's Grt Swd
                internal readonly Weapon chieftainsGrtSwd = new Weapon
                    (
                    name: greatSwordsName.chieftainsGrtSwd,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 576,
                    true_attack: 120,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //High Chief's Grt Swd
                internal readonly Weapon highChiefsGrtSwd = new Weapon
                    (
                    name: greatSwordsName.highChiefsGrtSwd,
                    rarity: rarityIcon[5],
                    picture: null,
                    attack: 912,
                    true_attack: 190,
                    defense: 0,
                    affinity: 0,
                    slots: slots[3]
                    );

                //Lagiacrus Blade
                internal readonly Weapon lagiacrusBlade = new Weapon
                    (
                    name: greatSwordsName.lagiacrusBlade,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 624,
                    true_attack: 130,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Lagiacrus Blade+
                internal readonly Weapon lagiacrusBladePlus = new Weapon
                    (
                    name: greatSwordsName.lagiacrusBladePlus,
                    rarity: rarityIcon[4],
                    picture: null,
                    attack: 720,
                    true_attack: 150,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //High Lagia Blade
                internal readonly Weapon highLagiaBlade = new Weapon
                    (
                    name: greatSwordsName.highLagiaBlade,
                    rarity: rarityIcon[4],
                    picture: null,
                    attack: 768,
                    true_attack: 160,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Lagia Lightning
                internal readonly Weapon lagiaLightning = new Weapon
                    (
                    name: greatSwordsName.lagiaLightning,
                    rarity: rarityIcon[5],
                    picture: null,
                    attack: 864,
                    true_attack: 180,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Lagia Wildfire
                internal readonly Weapon lagiaWildfire = new Weapon
                    (
                    name: greatSwordsName.lagiaWildfire,
                    rarity: rarityIcon[6],
                    picture: null,
                    attack: 960,
                    true_attack: 200,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Neo Lagia Blade
                internal readonly Weapon neoLagiaBlade = new Weapon
                    (
                    name: greatSwordsName.neoLagiaBlade,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1104,
                    true_attack: 230,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Lagia Fulmination
                internal readonly Weapon lagiaFulmination = new Weapon
                    (
                    name: greatSwordsName.lagiaFulmination,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1248,
                    true_attack: 260,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Usurper's Storm
                internal readonly Weapon usurpersStorm = new Weapon
                    (
                    name: greatSwordsName.usurpersStorm,
                    rarity: rarityIcon[5],
                    picture: null,
                    attack: 768,
                    true_attack: 160,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Despot's Blackstorm
                internal readonly Weapon despotsBlackstorm = new Weapon
                    (
                    name: greatSwordsName.despotsBlackstorm,
                    rarity: rarityIcon[6],
                    picture: null,
                    attack: 864,
                    true_attack: 180,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Oppressor's Forger
                internal readonly Weapon oppressorsForger = new Weapon
                    (
                    name: greatSwordsName.oppressorsForger,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 960,
                    true_attack: 200,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Orcus Tonitrus
                internal readonly Weapon orcusTonitrus = new Weapon
                    (
                    name: greatSwordsName.orcusTonitrus,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1008,
                    true_attack: 210,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Nether Great Sword
                internal readonly Weapon netherGreatSword = new Weapon
                    (
                    name: greatSwordsName.netherGreatSword,
                    rarity: rarityIcon[10],
                    picture: null,
                    attack: 1104,
                    true_attack: 230,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Nether Lufactrus
                internal readonly Weapon netherLufactrus = new Weapon
                    (
                    name: greatSwordsName.netherLufactrus,
                    rarity: rarityIcon[10],
                    picture: null,
                    attack: 1152,
                    true_attack: 240,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Brimstren Drakepride
                internal readonly Weapon brimstrenDrakepride = new Weapon
                    (
                    name: greatSwordsName.brimstrenDrakepride,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1104,
                    true_attack: 230,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Stygian Acedia
                internal readonly Weapon stygianAcedia = new Weapon
                    (
                    name: greatSwordsName.stygianAcedia,
                    rarity: rarityIcon[10],
                    picture: null,
                    attack: 1248,
                    true_attack: 260,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Carapace Sword
                internal readonly Weapon carapaceSword = new Weapon
                    (
                    name: greatSwordsName.carapaceSword,
                    rarity: rarityIcon[2],
                    picture: null,
                    attack: 576,
                    true_attack: 120,
                    defense: 0,
                    affinity: -30,
                    slots: slots[0]
                    );

                //Carapace Blade
                internal readonly Weapon carapaceBlade = new Weapon
                    (
                    name: greatSwordsName.carapaceBlade,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 672,
                    true_attack: 140,
                    defense: 0,
                    affinity: -30,
                    slots: slots[0]
                    );

                //Barroth Smasher
                internal readonly Weapon barrothSmasher = new Weapon
                    (
                    name: greatSwordsName.barrothSmasher,
                    rarity: rarityIcon[4],
                    picture: null,
                    attack: 816,
                    true_attack: 170,
                    defense: 0,
                    affinity: -25,
                    slots: slots[0]
                    );

                //Aurora Blade
                internal readonly Weapon auroraBlade = new Weapon
                    (
                    name: greatSwordsName.auroraBlade,
                    rarity: rarityIcon[6],
                    picture: null,
                    attack: 960,
                    true_attack: 200,
                    defense: 0,
                    affinity: -20,
                    slots: slots[0]
                    );

                //Northern Lights
                internal readonly Weapon northernLights = new Weapon
                    (
                    name: greatSwordsName.northernLights,
                    rarity: rarityIcon[8],
                    picture: null,
                    attack: 960,
                    true_attack: 200,
                    defense: 0,
                    affinity: -15,
                    slots: slots[0]
                    );

                //Northern Cross
                internal readonly Weapon northernCross = new Weapon
                    (
                    name: greatSwordsName.northernCross,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1152,
                    true_attack: 240,
                    defense: 0,
                    affinity: -10,
                    slots: slots[0]
                    );

                //Viking Hornsword
                internal readonly Weapon vikingHornsword = new Weapon
                    (
                    name: greatSwordsName.vikingHornsword,
                    rarity: rarityIcon[4],
                    picture: null,
                    attack: 768,
                    true_attack: 160,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Ancharius Sword
                internal readonly Weapon anchariusSword = new Weapon
                    (
                    name: greatSwordsName.anchariusSword,
                    rarity: rarityIcon[7],
                    picture: null,
                    attack: 1008,
                    true_attack: 210,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Excalius Sword
                internal readonly Weapon excaliusSword = new Weapon
                    (
                    name: greatSwordsName.excaliusSword,
                    rarity: rarityIcon[8],
                    picture: null,
                    attack: 1152,
                    true_attack: 240,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Bone Blade
                internal readonly Weapon boneBlade = new Weapon
                    (
                    name: greatSwordsName.boneBlade,
                    rarity: rarityIcon[1],
                    picture: null,
                    attack: 384,
                    true_attack: 80,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Bone Blade+
                internal readonly Weapon boneBladePlus = new Weapon
                    (
                    name: greatSwordsName.boneBladePlus,
                    rarity: rarityIcon[1],
                    picture: null,
                    attack: 432,
                    true_attack: 90,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Jawblade
                internal readonly Weapon jawblade = new Weapon
                    (
                    name: greatSwordsName.jawblade,
                    rarity: rarityIcon[1],
                    picture: null,
                    attack: 528,
                    true_attack: 110,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Giant Jawblade
                internal readonly Weapon giantJawblade = new Weapon
                    (
                    name: greatSwordsName.giantJawblade,
                    rarity: rarityIcon[2],
                    picture: null,
                    attack: 576,
                    true_attack: 120,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Red Wing
                internal readonly Weapon redWing = new Weapon
                    (
                    name: greatSwordsName.redWing,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 720,
                    true_attack: 150,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Rathalos Firesword
                internal readonly Weapon rathalosFiresword = new Weapon
                    (
                    name: greatSwordsName.rathalosFiresword,
                    rarity: rarityIcon[4],
                    picture: null,
                    attack: 768,
                    true_attack: 160,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Rathalos Flamesword
                internal readonly Weapon rathalosFlamesword = new Weapon
                    (
                    name: greatSwordsName.rathalosFlamesword,
                    rarity: rarityIcon[5],
                    picture: null,
                    attack: 864,
                    true_attack: 180,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Blue Wing
                internal readonly Weapon blueWing = new Weapon
                    (
                    name: greatSwordsName.blueWing,
                    rarity: rarityIcon[6],
                    picture: null,
                    attack: 1008,
                    true_attack: 210,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Rathalos Glinsword
                internal readonly Weapon rathalosGlinsword = new Weapon
                    (
                    name: greatSwordsName.rathalosGlinsword,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1104,
                    true_attack: 230,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Rathalos Gleamsword
                internal readonly Weapon rathalosGleamsword = new Weapon
                    (
                    name: greatSwordsName.rathalosGleamsword,
                    rarity: rarityIcon[10],
                    picture: null,
                    attack: 1248,
                    true_attack: 260,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Dios Blade
                internal readonly Weapon diosBlade = new Weapon
                    (
                    name: greatSwordsName.diosBlade,
                    rarity: rarityIcon[5],
                    picture: null,
                    attack: 912,
                    true_attack: 190,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Dios Blade+
                internal readonly Weapon diosBladePlus = new Weapon
                    (
                    name: greatSwordsName.diosBladePlus,
                    rarity: rarityIcon[6],
                    picture: null,
                    attack: 1008,
                    true_attack: 210,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Demolition Sword
                internal readonly Weapon demolitionSword = new Weapon
                    (
                    name: greatSwordsName.demolitionSword,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1152,
                    true_attack: 240,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Myxo Demolisher
                internal readonly Weapon myxoDemolisher = new Weapon
                    (
                    name: greatSwordsName.myxoDemolisher,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1248,
                    true_attack: 260,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Valkyrie Blade
                internal readonly Weapon valkyrieBlade = new Weapon
                    (
                    name: greatSwordsName.valkyrieBlade,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 672,
                    true_attack: 140,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Sieglinde
                internal readonly Weapon sieglinde = new Weapon
                    (
                    name: greatSwordsName.sieglinde,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 720,
                    true_attack: 150,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //High Sieglinde
                internal readonly Weapon highSieglinde = new Weapon
                    (
                    name: greatSwordsName.highSieglinde,
                    rarity: rarityIcon[4],
                    picture: null,
                    attack: 768,
                    true_attack: 160,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Titania
                internal readonly Weapon titania = new Weapon
                    (
                    name: greatSwordsName.titania,
                    rarity: rarityIcon[5],
                    picture: null,
                    attack: 864,
                    true_attack: 180,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Blushing Dame
                internal readonly Weapon blushingDame = new Weapon
                    (
                    name: greatSwordsName.blushingDame,
                    rarity: rarityIcon[6],
                    picture: null,
                    attack: 960,
                    true_attack: 200,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Ljósálfar
                internal readonly Weapon ljósálfar = new Weapon
                    (
                    name: greatSwordsName.ljósálfar,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1056,
                    true_attack: 220,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Brünnhilde
                internal readonly Weapon brünnhilde = new Weapon
                    (
                    name: greatSwordsName.brünnhilde,
                    rarity: rarityIcon[10],
                    picture: null,
                    attack: 1200,
                    true_attack: 250,
                    defense: 0,
                    affinity: 0,
                    slots: slots[3]
                    );

                //Siegmund
                internal readonly Weapon siegmund = new Weapon
                    (
                    name: greatSwordsName.siegmund,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 768,
                    true_attack: 160,
                    defense: 0,
                    affinity: 15,
                    slots: slots[0]
                    );

                //High Siegmund
                internal readonly Weapon highSiegmund = new Weapon
                    (
                    name: greatSwordsName.highSiegmund,
                    rarity: rarityIcon[5],
                    picture: null,
                    attack: 864,
                    true_attack: 180,
                    defense: 0,
                    affinity: 20,
                    slots: slots[1]
                    );

                //Reddnaught
                internal readonly Weapon reddnaught = new Weapon
                    (
                    name: greatSwordsName.reddnaught,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1152,
                    true_attack: 240,
                    defense: 0,
                    affinity: 25,
                    slots: slots[3]
                    );

                //Auberon
                internal readonly Weapon auberon = new Weapon
                    (
                    name: greatSwordsName.auberon,
                    rarity: rarityIcon[6],
                    picture: null,
                    attack: 1008,
                    true_attack: 210,
                    defense: 0,
                    affinity: 5,
                    slots: slots[2]
                    );

                //Pale Kaiser
                internal readonly Weapon paleKaiser = new Weapon
                    (
                    name: greatSwordsName.paleKaiser,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1200,
                    true_attack: 250,
                    defense: 0,
                    affinity: 15,
                    slots: slots[3]
                    );

                //Golem Blade
                internal readonly Weapon golemBlade = new Weapon
                    (
                    name: greatSwordsName.golemBlade,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 720,
                    true_attack: 150,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Blade of Talos
                internal readonly Weapon bladeOfTalos = new Weapon
                    (
                    name: greatSwordsName.bladeOfTalos,
                    rarity: rarityIcon[4],
                    picture: null,
                    attack: 864,
                    true_attack: 180,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Blade of Tartarus
                internal readonly Weapon bladeOfTartarus = new Weapon
                    (
                    name: greatSwordsName.bladeOfTartarus,
                    rarity: rarityIcon[8],
                    picture: null,
                    attack: 1344,
                    true_attack: 280,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Wyvern Jawblade
                internal readonly Weapon wyvernJawblade = new Weapon
                    (
                    name: greatSwordsName.wyvernJawblade,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 720,
                    true_attack: 150,
                    defense: 10,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Quarrel Hornsword
                internal readonly Weapon quarrelHornsword = new Weapon
                    (
                    name: greatSwordsName.quarrelHornsword,
                    rarity: rarityIcon[4],
                    picture: null,
                    attack: 864,
                    true_attack: 180,
                    defense: 12,
                    affinity: -5,
                    slots: slots[0]
                    );

                //Quarrel Hornsword+
                internal readonly Weapon quarrelHornswordPlus = new Weapon
                    (
                    name: greatSwordsName.quarrelHornswordPlus,
                    rarity: rarityIcon[5],
                    picture: null,
                    attack: 960,
                    true_attack: 200,
                    defense: 15,
                    affinity: -5,
                    slots: slots [0]
                    );

                //Doublie Diablos
                internal readonly Weapon doubleDiablos = new Weapon
                    (
                    name: greatSwordsName.doubleDiablos,
                    rarity: rarityIcon[6],
                    picture: null,
                    attack: 1152,
                    true_attack: 240,
                    defense: 18,
                    affinity: -10,
                    slots: slots[0]
                    );

                //Cera Cigil
                internal readonly Weapon ceraCigil = new Weapon
                    (
                    name: greatSwordsName.ceraCigil,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1392,
                    true_attack: 290,
                    defense: 21,
                    affinity: -20,
                    slots: slots[0]
                    );

                //Cera Cymmetry
                internal readonly Weapon ceraCymmetry = new Weapon
                    (
                    name: greatSwordsName.ceraCymmmetry,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1488,
                    true_attack: 310,
                    defense: 24,
                    affinity: -20,
                    slots: slots[0]
                    );

                //Ludroth Bone Sword
                internal readonly Weapon ludrothBoneSword = new Weapon
                    (
                    name: greatSwordsName.ludrothBoneSword,
                    rarity: rarityIcon[1],
                    picture: null,
                    attack: 528,
                    true_attack: 110,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Cataclysm Sword
                internal readonly Weapon cataclysmSword = new Weapon
                    (
                    name: greatSwordsName.cataclysmSword,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 624,
                    true_attack: 130,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Cataclysm Blade
                internal readonly Weapon cataclysmBlade = new Weapon
                    (
                    name: greatSwordsName.cataclysmBlade,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 672,
                    true_attack: 140,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Icicle Fang
                internal readonly Weapon icicleFang = new Weapon
                    (
                    name: greatSwordsName.icicleFang,
                    rarity: rarityIcon[4],
                    picture: null,
                    attack: 768,
                    true_attack: 160,
                    defense: 0,
                    affinity: 10,
                    slots: slots[1]
                    );

                //Icicle Fang+
                internal readonly Weapon icicleFangPlus = new Weapon
                    (
                    name: greatSwordsName.icicleFangPlus,
                    rarity: rarityIcon[5],
                    picture: null,
                    attack: 912,
                    true_attack: 190,
                    defense: 0,
                    affinity: 15,
                    slots: slots[1]
                    );

                //Paladire
                internal readonly Weapon paladire = new Weapon
                    (
                    name: greatSwordsName.paladire,
                    rarity: rarityIcon[8],
                    picture: null,
                    attack: 1152,
                    true_attack: 240,
                    defense: 0,
                    affinity: 20,
                    slots: slots[1]
                    );

                //Galespike
                internal readonly Weapon galespike = new Weapon
                    (
                    name: greatSwordsName.galespike,
                    rarity: rarityIcon[6],
                    picture: null,
                    attack: 960,
                    true_attack: 200,
                    defense: 0,
                    affinity: 20,
                    slots: slots[1]
                    );

                //Simoom Sandbarb
                internal readonly Weapon simoomSandbarb = new Weapon
                    (
                    name: greatSwordsName.simoomSandbarb,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1104,
                    true_attack: 230,
                    defense: 0,
                    affinity: 25,
                    slots: slots[1]
                    );

                //Simoom Sandbitter
                internal readonly Weapon simoomSandbiter = new Weapon
                    (
                    name: greatSwordsName.simoomSandbiter,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1152,
                    true_attack: 240,
                    defense: 0,
                    affinity: 35,
                    slots: slots[2]
                    );

                //Finblade
                internal readonly Weapon finblade = new Weapon
                    (
                    name: greatSwordsName.finblade,
                    rarity: rarityIcon[4],
                    picture: null,
                    attack: 816,
                    true_attack: 170,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Plesioth Watercutter
                internal readonly Weapon plesiothWatercutter = new Weapon
                    (
                    name: greatSwordsName.plesiothWatercutter,
                    rarity: rarityIcon[6],
                    picture: null,
                    attack: 864,
                    true_attack: 180,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Plesioth Aquablade
                internal readonly Weapon plesiothAquablade = new Weapon
                    (
                    name: greatSwordsName.plesiothAquablade,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1248,
                    true_attack: 260,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Plesioth Lullaby
                internal readonly Weapon plesiothLullaby = new Weapon
                    (
                    name: greatSwordsName.plesiothLullaby,
                    rarity: rarityIcon[8],
                    picture: null,
                    attack: 912,
                    true_attack: 190,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Plesioth Lullabane
                internal readonly Weapon plesiothLullabane = new Weapon
                    (
                    name: greatSwordsName.plesiothLullabane,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 960,
                    true_attack: 200,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Frozen Speartuna
                internal readonly Weapon frozenSpeartuna = new Weapon
                    (
                    name: greatSwordsName.frozenSpeartuna,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 672,
                    true_attack: 140,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Freezer Speartuna
                internal readonly Weapon freezerSpeartuna = new Weapon
                    (
                    name: greatSwordsName.freezerSpeartuna,
                    rarity: rarityIcon[5],
                    picture: null,
                    attack: 816,
                    true_attack: 170,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Xiphias Gladius
                internal readonly Weapon xiphiasGladius = new Weapon
                    (
                    name: greatSwordsName.xiphiasGladius,
                    rarity: rarityIcon[8],
                    picture: null,
                    attack: 912,
                    true_attack: 190,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Vulcanis
                internal readonly Weapon vulcanis = new Weapon
                    (
                    name: greatSwordsName.vulcanis,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 624,
                    true_attack: 130,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Vulcanis+
                internal readonly Weapon vulcanisPlus = new Weapon
                    (
                    name: greatSwordsName.vulcanisPlus,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 672,
                    true_attack: 140,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Vulcanvil
                internal readonly Weapon vulcanvil = new Weapon
                    (
                    name: greatSwordsName.vulcanvil,
                    rarity: rarityIcon[4],
                    picture: null,
                    attack: 768,
                    true_attack: 160,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Vulcamagnon
                internal readonly Weapon vulcamagnon = new Weapon
                    (
                    name: greatSwordsName.vulcamagnon,
                    rarity: rarityIcon[5],
                    picture: null,
                    attack: 816,
                    true_attack: 170,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Vulcatastrophe
                internal readonly Weapon vulcatastrophe = new Weapon
                    (
                    name: greatSwordsName.vulcatastrophe,
                    rarity: rarityIcon[8],
                    picture: null,
                    attack: 1008,
                    true_attack: 210,
                    defense: 0,
                    affinity: 0,
                    slots: slots[3]
                    );

                //Vulca Vendetta
                internal readonly Weapon vulcaVendetta = new Weapon
                    (
                    name: greatSwordsName.vulcaVendetta,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1152,
                    true_attack: 240,
                    defense: 0,
                    affinity: 0,
                    slots: slots[3]
                    );

                //Rusted Great Sword
                internal readonly Weapon rustedGreatSword = new Weapon
                    (
                    name: greatSwordsName.rustedGreatSword,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 480,
                    true_attack: 100,
                    defense: 0,
                    affinity: -70,
                    slots: slots[0]
                    );

                //Tarnished Great Swd
                internal readonly Weapon tarnishedGreatSwd = new Weapon
                    (
                    name: greatSwordsName.tarnishedGreatSword,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 480,
                    true_attack: 100,
                    defense: 0,
                    affinity: -70,
                    slots: slots[0]
                    );

                //Ancient Blade
                internal readonly Weapon ancientBlade = new Weapon
                    (
                    name: greatSwordsName.ancientBlade,
                    rarity: rarityIcon[3],
                    picture: null,
                    attack: 720,
                    true_attack: 150,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Elder Monument
                internal readonly Weapon elderMonument = new Weapon
                    (
                    name: greatSwordsName.elderMonument,
                    rarity: rarityIcon[4],
                    picture: null,
                    attack: 816,
                    true_attack: 170,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Eternal Glyph
                internal readonly Weapon eternalGlyph = new Weapon
                    (
                    name: greatSwordsName.eternalGlyph,
                    rarity: rarityIcon[5],
                    picture: null,
                    attack: 864,
                    true_attack: 180,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Wyvern's Perch
                internal readonly Weapon wyvernsPerch = new Weapon
                    (
                    name: greatSwordsName.wyvernsPerch,
                    rarity: rarityIcon[4],
                    picture: null,
                    attack: 576,
                    true_attack: 120,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Roguish Deathcap
                internal readonly Weapon roguishDeathcap = new Weapon
                    (
                    name: greatSwordsName.roguishDeathcap,
                    rarity: rarityIcon[6],
                    picture: null,
                    attack: 720,
                    true_attack: 150,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Lordly Deathcap
                internal readonly Weapon lordlyDeathcap = new Weapon
                    (
                    name: greatSwordsName.lordlyDeathcap,
                    rarity: rarityIcon[8],
                    picture: null,
                    attack: 912,
                    true_attack: 190,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Houma no Tsurugi
                internal readonly Weapon houmaNoTsurugi = new Weapon
                    (
                    name: greatSwordsName.houmaNoTsurugi,
                    rarity: rarityIcon[4],
                    picture: null,
                    attack: 672,
                    true_attack: 140,
                    defense: 8,
                    affinity: 10,
                    slots: slots[0]
                    );

                //Tenma no Tsurugi
                internal readonly Weapon tenmaNoTsurugi = new Weapon
                    (
                    name: greatSwordsName.tenmaNoTsurugi,
                    rarity: rarityIcon[8],
                    picture: null,
                    attack: 1008,
                    true_attack: 210,
                    defense: 10,
                    affinity: 15,
                    slots: slots[0]
                    );

                //Berserker Sword
                internal readonly Weapon berserkerSword = new Weapon
                    (
                    name: greatSwordsName.berserkerSword,
                    rarity: rarityIcon[6],
                    picture: null,
                    attack: 1152,
                    true_attack: 240,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Anguish
                internal readonly Weapon anguish = new Weapon
                    (
                    name: greatSwordsName.anguish,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1248,
                    true_attack: 260,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Nero's Anguish
                internal readonly Weapon nerosAnguish = new Weapon
                    (
                    name: greatSwordsName.nerosAnguish,
                    rarity: rarityIcon[10],
                    picture: null,
                    attack: 1392,
                    true_attack: 290,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Lion's Bane
                internal readonly Weapon lionsBande = new Weapon
                    (
                    name: greatSwordsName.lionsBane,
                    rarity: rarityIcon[6],
                    picture: null,
                    attack: 1008,
                    true_attack: 210,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Alatreon Great Sword
                internal readonly Weapon alatreonGreatSword = new Weapon
                    (
                    name: greatSwordsName.alatreonGreatSword,
                    rarity: rarityIcon[7],
                    picture: null,
                    attack: 864,
                    true_attack: 180,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Alatreon Revolution
                internal readonly Weapon alatreonRevolution = new Weapon
                    (
                    name: greatSwordsName.alatreonRevolution,
                    rarity: rarityIcon[10],
                    picture: null,
                    attack: 1056,
                    true_attack: 220,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Altheos Evolutia
                internal readonly Weapon altheosEvolutia = new Weapon
                    (
                    name: greatSwordsName.altheosEvolutia,
                    rarity: rarityIcon[10],
                    picture: null,
                    attack: 1200,
                    true_attack: 250,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Amethyst Blade
                internal readonly Weapon amethystBlade = new Weapon
                    (
                    name: greatSwordsName.amethystBlade,
                    rarity: rarityIcon[8],
                    picture: null,
                    attack: 960,
                    true_attack: 200,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //Maismethyst
                internal readonly Weapon miasmethyst = new Weapon
                    (
                    name: greatSwordsName.miasmethyst,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1104,
                    true_attack: 230,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Anima Reaper
                internal readonly Weapon animaReaper = new Weapon
                    (
                    name: greatSwordsName.animaReaper,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1104,
                    true_attack: 230,
                    defense: 0,
                    affinity: 0,
                    slots: slots[2]
                    );

                //Eisenfaust
                internal readonly Weapon eisenfaust = new Weapon
                    (
                    name: greatSwordsName.eisenfaust,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1440,
                    true_attack: 300,
                    defense: 0,
                    affinity: -50,
                    slots: slots[0]
                    );

                //Worn Great Sword
                internal readonly Weapon wornGreatSword = new Weapon
                    (
                    name: greatSwordsName.wornGreatSword,
                    rarity: rarityIcon[8],
                    picture: null,
                    attack: 480,
                    true_attack: 100,
                    defense: 0,
                    affinity: -70,
                    slots: slots[0]
                    );

                //Weathered Great Swd
                internal readonly Weapon weatheredGreatSwd = new Weapon
                    (
                    name: greatSwordsName.weatheredGreatSwd,
                    rarity: rarityIcon[8],
                    picture: null,
                    attack: 528,
                    true_attack: 110,
                    defense: 0,
                    affinity: -70,
                    slots: slots[0]
                    );

                //Epitaph Blade
                internal readonly Weapon epitaphBlade = new Weapon
                    (
                    name: greatSwordsName.epitaphBlade,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 960,
                    true_attack: 200,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Epitaph Eternal
                internal readonly Weapon epitaphEternal = new Weapon
                    (
                    name: greatSwordsName.epitaphEternal,
                    rarity: rarityIcon[9],
                    picture: null,
                    attack: 1152,
                    true_attack: 240,
                    defense: 0,
                    affinity: 0,
                    slots: slots[1]
                    );

                //Eclipse Blade
                internal readonly Weapon eclipseBlade = new Weapon
                    (
                    name: greatSwordsName.eclipseBlade,
                    rarity: rarityIcon[10],
                    picture: null,
                    attack: 1056,
                    true_attack: 220,
                    defense: 0,
                    affinity: 20,
                    slots: slots[1]
                    );

                //Merak's Asterism
                internal readonly Weapon meraksAsterism = new Weapon
                    (
                    name: greatSwordsName.meraksAsterism,
                    rarity: rarityIcon[10],
                    picture: null,
                    attack: 1152,
                    true_attack: 240,
                    defense: 0,
                    affinity: 30,
                    slots: slots[1]
                    );

                //Megiddo Blaze
                internal readonly Weapon megiddoBlaze = new Weapon
                    (
                    name: greatSwordsName.megiddoBlaze,
                    rarity: rarityIcon[10],
                    picture: null,
                    attack: 1008,
                    true_attack: 210,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                //The Depotheosis
                internal readonly Weapon theDepotheosis = new Weapon
                    (
                    name: greatSwordsName.theDepotheosis,
                    rarity: rarityIcon[10],
                    picture: null,
                    attack: 1056,
                    true_attack: 220,
                    defense: 0,
                    affinity: 0,
                    slots: slots[0]
                    );

                ////////////////////
                // Side functions //
                ////////////////////

                internal Weapon[] listAll() //Return all MH3U Greatswords as a whole so that it can be used later when displaying them as a list
                {
                    Weapon[] all =
                    {
                        this.alatreonGreatSword,
                        this.alatreonRevolution,
                        this.altheosEvolutia,
                        this.amethystBlade,
                        this.anchariusSword,
                        this.ancientBlade,
                        this.anguish,
                        this.animaReaper,
                        this.auberon,
                        this.auroraBlade,
                        this.avidyaGreatSword,
                        this.barrothSmasher,
                        this.berserkerSword,
                        this.bladeOfTalos,
                        this.bladeOfTartarus,
                        this.blueWing,
                        this.blushingDame,
                        this.boneBlade,
                        this.boneBladePlus,
                        this.brazenwall,
                        this.brimstrenDrakepride,
                        this.brünnhilde,
                        this.busterBlade,
                        this.busterSword,
                        this.busterSwordPlus,
                        this.carapaceBlade,
                        this.carapaceSword,
                        this.cataclysmBlade,
                        this.cataclysmSword,
                        this.ceraCigil,
                        this.ceraCymmetry,
                        this.chieftainsGrtSwd,
                        this.chromeQuietus,
                        this.chromeRazor,
                        this.cragscliff,
                        this.crimsonWall,
                        this.darkOfNight,
                        this.demolitionSword,
                        this.despotsBlackstorm,
                        this.devastatorBlade,
                        this.diosBlade,
                        this.diosBladePlus,
                        this.doubleDiablos,
                        this.eclipseBlade,
                        this.eisenfaust,
                        this.elderMonument,
                        this.epitaphBlade,
                        this.epitaphEternal,
                        this.eternalGlyph,
                        this.excaliusSword,
                        this.finblade,
                        this.freezerSpeartuna,
                        this.frozenSpeartuna,
                        this.galespike,
                        this.giantJawblade,
                        this.golemBlade,
                        this.goliathsScream,
                        this.hiddenBlade,
                        this.highChiefsGrtSwd,
                        this.highLagiaBlade,
                        this.highSieglinde,
                        this.highSiegmund,
                        this.houmaNoTsurugi,
                        this.icicleFang,
                        this.icicleFangPlus,
                        this.ironSword,
                        this.ironSwordPlus,
                        this.jawblade,
                        this.laceratorBlade,
                        this.lagiacrusBlade,
                        this.lagiacrusBladePlus,
                        this.lagiaFulmination,
                        this.lagiaLightning,
                        this.lagiaWildfire,
                        this.lionsBande,
                        this.ljósálfar,
                        this.lordlyDeathcap,
                        this.ludrothBoneSword,
                        this.megiddoBlaze,
                        this.meraksAsterism,
                        this.miasmethyst,
                        this.myxoDemolisher,
                        this.neoLagiaBlade,
                        this.nerosAnguish,
                        this.netherGreatSword,
                        this.netherLufactrus,
                        this.northernCross,
                        this.northernLights,
                        this.oppressorsForger,
                        this.orcusTonitrus,
                        this.paladire,
                        this.paleKaiser,
                        this.plesiothAquablade,
                        this.plesiothLullabane,
                        this.plesiothLullaby,
                        this.plesiothWatercutter,
                        this.quarrelHornsword,
                        this.quarrelHornswordPlus,
                        this.rathalosFiresword,
                        this.rathalosFlamesword,
                        this.rathalosGleamsword,
                        this.rathalosGlinsword,
                        this.ravagerBlade,
                        this.ravagerBladePlus,
                        this.reddnaught,
                        this.redWing,
                        this.remalgagorgon,
                        this.remalgalypse,
                        this.roguishDeathcap,
                        this.ruggedGreatSword,
                        this.rustedGreatSword,
                        this.sieglinde,
                        this.siegmund,
                        this.simoomSandbarb,
                        this.simoomSandbiter,
                        this.stygianAcedia,
                        this.tarnishedGreatSwd,
                        this.tenmaNoTsurugi,
                        this.theDepotheosis,
                        this.titania,
                        this.type41Wyvernator,
                        this.usurpersStorm,
                        this.valkyrieBlade,
                        this.vikingHornsword,
                        this.vulcamagnon,
                        this.vulcanis,
                        this.vulcanisPlus,
                        this.vulcanvil,
                        this.vulcatastrophe,
                        this.vulcaVendetta,
                        this.weatheredGreatSwd,
                        this.wornGreatSword,
                        this.wyvernJawblade,
                        this.wyvernsPerch,
                        this.xiphiasGladius
                    };
                    return all;
                }

                internal Weapon[] displayOrder(int displayOrder) //In progress
                {
                    Weapon[] all = listAll();
                    for (int x = 0; x < all.Length; x++)
                    {
                        for (int y = x + 1; y < all.Length; y++)
                        {
                            switch(displayOrder)
                            {
                                case 0:
                                    if (all[x].name.names[0].actual[0] < all[x].name.names[0].actual[0])
                                    {

                                    }
                                    break;
                            }
                        }
                    }
                    return all;
                }
            }
        }
    }
}
