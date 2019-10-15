using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MH_Database.Classes
{
    class MultiLangGroupBox
    {
        internal MultiLang displayText = new MultiLang();
        internal Button linkedGroupBox = null;
        internal MultiLangGroupBox(Button groupBox)
        {
            linkedGroupBox = groupBox;
            displayText.ChangeEveryLang("#_MISSING_TRANSLATION_#");
        }
        internal MultiLangGroupBox(Button groupBox, string everyLang)
        {
            linkedGroupBox = groupBox;
            displayText.ChangeEveryLang(everyLang);
        }
        internal MultiLangGroupBox(Button groupBox, string fr, string en) //Manipulating language procedure - Note 7
        {
            linkedGroupBox = groupBox;
            displayText.fr = fr;
            displayText.en = en;
        }
        internal void DisplayLang(string langToDisplay) //Manipulating language procedure - Note 8
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
