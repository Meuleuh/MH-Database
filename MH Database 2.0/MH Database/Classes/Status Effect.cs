using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH_Database.Classes
{
    class StatusEffect
    {
        //Type enum
        internal enum Type
        {
            None,
            AttackUp,
            DefenseUp,
            NaturalRecUp,
            ColdResistant,
            HeatResistant,
            Windproof,
            MovementSpeedUp,
            NoQuakes,
            NoParalysis,
            NoFaint,
            NoHeat,
            NoColdAndSnowRes,
            ElementAttackUp,
            HeavenlyProtection,
            HealthIncLo,
            HealtIncHi,
            WindReduce,
            WindCancel,
            HearProtectLo,
            HearProtectHi,
            FireResUpLo,
            FireResUpHi,
            FireResIncreased,
            WaterResUpLo,
            WaterResUpHi,
            WaterResIncreased,
            ThunderResUpLo,
            ThunderResUpHi,
            ThunderResIncreased,
            IceResUpLo,
            IceResUpHi,
            IceResIncreased,
            DragonResUpLo,
            DragonResUpHi,
            DragonResIncreased,
            Poison,
            DeadlyPoison,
            NoxiousPoison = DeadlyPoison,
            Venom = DeadlyPoison,
            DeadlyPoisonMHGen,
            Paralysis,
            Sleep,
            Stun,
            DefenseDown,
            Soiled,
            Fatigue,
            Snowman,
            Muddy,
            Felvine_Scented,
            LifeDrain,
            Slimeblight,
            Blastblight = Slimeblight,
            FrenzyVirus,
            Webbed,
            Bleeding,
            Tarred,
            Confusion,
            Bubbleblight,
            Mucus,
            Ossified,
            Effluvium,
            Blastcourge,
            Zombification,
            Crystallization,
            Frostbite,
            Magnetism,
            VocalCordParalysis,
            Dark,
            ConfusionMHF,
            CorruptedPoison,
            ExtremePoison,
            ExtremeParalysis,
            ExtremeSleep,
            Silked,
            Frozen,
            Stabbed,
            PositiveCharge,
            NegativeCharge,
            Rust,
            Drunken,
            Fireblight,
            SevereFireblight,
            Waterblight,
            SevereWaterblight,
            Thunderblight,
            SevereThunderblight,
            Iceblight,
            SevereIceblight,
            Dragonblight,
            SevereDragonblight,
            ExtremeFireblight,
            ExtremeWaterblight,
            ExtremeThunderblight,
            ExtremeIceblight,
            ExtremeDragonblight
        }

        //Variables
        internal int power;
        internal Type type;

        //Constructor
        internal StatusEffect(int powerToSet = 0, Type typeToSet = Type.None)
        {
            power = powerToSet;
            type = typeToSet;
        }
    }
}
