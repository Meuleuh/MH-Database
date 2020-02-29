namespace MH_Database.Classes.MultiLang
{
    class MultiLang
    {
        internal string fr = "\0";
        internal string en = "\0";
        internal string actual = "\0";  //Must always be set to something in order for text to be displayed
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
        internal void ChangeActual(string actual)
        {
            if (actual == "fr")
            {
                this.actual = fr;
            }
            else if (actual == "en")
            {
                this.actual = en;
            }
        }
    }
}
