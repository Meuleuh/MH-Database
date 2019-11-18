namespace MH_Database.Classes.MultiLang
{
    class MultiLang
    {
        internal string fr = "\0";
        internal string en = "\0";
        //Manipulating language procedure - Note 1

        internal MultiLang()
        {
            //This is left blank to allow creating without entering parameters
        }
        internal MultiLang(string everyLang) //Manipulating language procedure - Note 2
        {
            ChangeNames(everyLang);
        }
        internal MultiLang(string fr, string en) //Manipulating language procedure - Note 3
        {
            ChangeNames(fr, en);
        }
        internal void ChangeNames(string everyLang) //Manipulating language procedure - Note 4
        {
            fr = everyLang;
            en = everyLang;
        }
        internal void ChangeNames(string fr, string en) //Manipulating language procedure - Note 5
        {
            this.fr = fr;
            this.en = en;
        }
    }
}
