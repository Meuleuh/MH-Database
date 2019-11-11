using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MH_Database.Classes.MultiLang
{
    class MultiLangGroupBox
    {
        internal MultiLang displayText = new MultiLang();
        internal GroupBox linkedGroupBox = new GroupBox();
        internal MultiLangGroupBox(GroupBox groupBox)
        {
            linkedGroupBox = groupBox;
            displayText.ChangeNames("#_MISSING_TRANSLATION_#");
        }
        internal MultiLangGroupBox(GroupBox groupBox, string everyLang)
        {
            linkedGroupBox = groupBox;
            displayText.ChangeNames(everyLang);
        }
        internal MultiLangGroupBox(GroupBox groupBox, string fr, string en) //Manipulating language procedure - Note 1
        {
            linkedGroupBox = groupBox;
            displayText.fr = fr;
            displayText.en = en;
        }
        internal MultiLangGroupBox(GroupBox groupBox, MultiLang multiLang)
        {
            linkedGroupBox = groupBox;
            displayText = multiLang;
        }
        internal void DisplayLang(string langToDisplay) //Manipulating language procedure - Note 2
        {
            if (langToDisplay == "fr")
            {
                linkedGroupBox.Text = displayText.fr;
            }
            else if (langToDisplay == "en")
            {
                linkedGroupBox.Text = displayText.en;
            }
        }
    }
}
