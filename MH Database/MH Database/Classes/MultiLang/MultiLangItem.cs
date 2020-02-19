namespace MH_Database.Classes.MultiLang
{
    class MultiLangItem
    {
        internal string fr;
        internal string en;

        internal MultiLangItem()
        {
            //Allow creating without parameters
        }

        internal MultiLangItem(string allLang)
        {
            fr = allLang;
            en = allLang;
        }

        internal MultiLangItem(string fr, string en)
        {
            this.fr = fr;
            this.en = en;
        }
    }
}
