using MH_Database.Classes.Elements;

namespace MH_Database.Classes.Containers
{
    class Item
    {
        internal MultiLang.MultiLang name;
        internal MultiLang.MultiLang description;
        internal Rarity rarity;
        internal int maxCarryAmount;
        internal int sellValue;
        internal int buyValue;
        //The followings will also be used as link to the page of the monster / quest / map / combo materials pages / weapon / armor / jewel / combo other material and result
        //All of the following should be rethinked before being implemented, some could only be some list, making them easier to implement
        //Obtaining
        //internal MonsterLoot[] lootFromMonster; //Will be added with the MonsterLoot Class used to store the monster that can loot this item, the percent of chance, the way of obtaining it and the rank needed
        //internal QuestReward[] rewardFromQuest; //Will be added with the QuestReward Class used to store the quests that can reward you with this item, the percent of chance of giving it to you, the amount and if it's base quest or secondary quest reward (Will display a quick brief of the quest and, if secondary quest reward, the secondary quest)
        //internal MapLoot[] lootInMap; //Will be added with the MapLoot Class used to store the map zone, the spot to excavate, the percent of chance of obtaining it, the amount obtained, the rank needed (will display contextual window when hover to display where to find in map)
        //internal ComboResult[] comboResult; //Will be added with the ComboResult Class used to store the base material, the base percent of chance of crafting it, the amount crafted at a time and the craft (for having contextual window displaying the whole craft on hover)
        //Usage
        //internal WeaponCraft[] weaponCraft; //Will be added with the WeaponCraft Class used to store the base Weapon, the final Weapon, the amount used to do the craft and the craft (for having contextual window displaying the whole craft on hover)
        //internal ArmorCraft[] armorCraft; //Will be added with the ArmorCraft Class used to store the armor being crafted, the piece being crafted, the amount needed for the craft and the craft (for having contextual window displaying the whole craft on hover)
        //internal JewelCraft[] jewelCraft; //Will be added with the JewelCraft Class used to store the jewels being crafted, the amount needed for crafting it and the craft (for having contextual window displaying the whole craft on hover)
        //internal ComboCraft[] possibleCombo; //Will be added with the ComboCraft Class used to store the combo possible using this item

        internal Item(MultiLang.MultiLang name, MultiLang.MultiLang description, Rarity rarity, int maxCarryAmount, int sellValue, int buyValue = -1)
        {
            this.name = name;
            this.description = description;
            this.rarity = rarity;
            this.maxCarryAmount = maxCarryAmount;
            this.sellValue = sellValue;
            this.buyValue = buyValue;
        } //If the item can be bought, the buyValue must be set in order to be marked as so, otherwise, -1 means it can't be bought
    }
}
