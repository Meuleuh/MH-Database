using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH_Database.Classes
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
            fr = everyLang;
            en = everyLang;
        }
        internal MultiLang(string fr, string en) //Manipulating language procedure - Note 3
        {
            this.fr = fr;
            this.en = en;
        }
        internal void ChangeEveryLang(string everyLang) //Manipulating language procedure - Note 4
        {
            fr = everyLang;
            en = everyLang;
        }
    }
}
