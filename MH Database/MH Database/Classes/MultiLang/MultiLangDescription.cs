namespace MH_Database.Classes.MultiLang
{
    class MultiLangDescription
    {
        internal string fr;
        internal string en;

        internal MultiLangDescription()
        {
            //Allow creating without parameters
        }

        internal MultiLangDescription(string allLang)
        {
            fr = allLang;
            en = allLang;
        }

        internal MultiLangDescription(string fr, string en)
        {
            this.fr = fr;
            this.en = en;
        }
    }
}
