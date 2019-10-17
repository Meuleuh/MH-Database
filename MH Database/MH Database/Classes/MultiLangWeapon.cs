using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH_Database.Classes
{
    class MultiLangWeapon
    {
        internal string[] fr = new string[15];
        internal string[] en = new string[15];
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
            for (int i = 0; i < fr.Length; i++)
            {
                fr[i] = allLangTier;
            }
            for (int i = 0; i < fr.Length; i++)
            {
                en[i] = allLangTier;
            }
        }
        internal void ChangeNames(string frAllTier, string enAllTier) //Manipulating language procedure - Note 6
        {
            for (int i = 0; i < fr.Length; i++)
            {
                fr[i] = frAllTier;
            }
            for (int i = 0; i < fr.Length; i++)
            {
                en[i] = enAllTier;
            }
        }
        internal void ChangeNames(string[] frTiers, string[] enTiers, int[] tiersLimitLevels) //Manipulating language procedure - Note 7
        {
            for (int i = 0; i + 1 < fr.Length; i++)
            {
                if (i < tiersLimitLevels[0])
                {
                    fr[i] = frTiers[0];
                }
                else if (i < tiersLimitLevels[1])
                {
                    fr[i] = frTiers[1];
                }
                else
                {
                    fr[i] = frTiers[2];
                }
            }
            for (int i = 0; i + 1 < en.Length; i++)
            {
                if (i < tiersLimitLevels[0])
                {
                    en[i] = enTiers[0];
                }
                else if (i < tiersLimitLevels[1])
                {
                    en[i] = enTiers[1];
                }
                else
                {
                    en[i] = enTiers[2];
                }
            }
        }
    }
}
