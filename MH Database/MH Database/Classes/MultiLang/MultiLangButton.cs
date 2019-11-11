using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MH_Database.Classes.MultiLang
{
    class MultiLangButton
    {
        internal MultiLang displayText = new MultiLang();
        internal Button linkedButton = null;
        internal MultiLangButton(Button button)
        {
            linkedButton = button;
            displayText.ChangeNames("#_MISSING_TRANSLATION_#");
        }
        internal MultiLangButton(Button button, string everyLang)
        {
            linkedButton = button;
            displayText.ChangeNames(everyLang);
        }
        internal MultiLangButton(Button button, string fr, string en) //Manipulating language procedure - Note 1
        {
            linkedButton = button;
            displayText.fr = fr;
            displayText.en = en;
        }
        internal MultiLangButton(Button button, MultiLang multiLang)
        {
            linkedButton = button;
            displayText = multiLang;
        }
        internal void DisplayLang(string langToDisplay) //Manipulating language procedure - Note 2
        {
            if (langToDisplay == "fr")
            {
                linkedButton.Text = displayText.fr;
            }
            else if (langToDisplay == "en")
            {
                linkedButton.Text = displayText.en;
            }
        }
    }
}
