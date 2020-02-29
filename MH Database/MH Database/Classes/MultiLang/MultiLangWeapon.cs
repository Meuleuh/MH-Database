namespace MH_Database.Classes.MultiLang
{
    class MultiLangWeapon
    {
        internal MultiLang[] names = new MultiLang[15];
        //Manipulating language procedure - Note 1

        internal MultiLangWeapon()
        {
            //This is left blank to allow creating without entering parameters
        }
        internal MultiLangWeapon(string allLangTier) //Manipulating language procedure - Note 2
        {
            ChangeNames(allLangTier);
        }
        internal MultiLangWeapon(string frAllTier, string enAllTier) //Manipulating language procedure - Note 3
        {
            ChangeNames(frAllTier, enAllTier);
        }
        internal MultiLangWeapon(string[] frTiers, string[] enTiers, int[] tiersLimitLevels) //Manipulating language procedure - Note 4
        {
            ChangeNames(frTiers, enTiers, tiersLimitLevels);
        }
        internal void ChangeNames(string allLangTier) //Manipulating language procedure - Note 5
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i].ChangeNames(allLangTier);
            }
        }
        internal void ChangeNames(string frAllTier, string enAllTier) //Manipulating language procedure - Note 6
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i].ChangeNames(frAllTier, enAllTier);
            }
        }
        internal void ChangeNames(string[] frTiers, string[] enTiers, int[] tiersLimitLevels) //Manipulating language procedure - Note 7
        {
            for (int i = 0; i + 1 < names.Length; i++)
            {
                if (i < tiersLimitLevels[0])
                {
                    names[i].ChangeNames(frTiers[0], enTiers[0]);
                }
                else if (i < tiersLimitLevels[1])
                {
                    names[i].ChangeNames(frTiers[1], enTiers[1]);
                }
                else
                {
                    names[i].ChangeNames(frTiers[2], enTiers[2]);
                }
            }
        }
    }
}
