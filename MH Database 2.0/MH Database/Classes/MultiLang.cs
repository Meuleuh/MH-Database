using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH_Database.Classes
{
    class MultiLang
    {
        //Variables
        internal string fr;
        internal string en;

        //Constructor
        internal MultiLang(string fr = "Missing french text", string en = "Missing english text")
        {
            this.fr = fr;
            this.en = en;
        }
    }
}
