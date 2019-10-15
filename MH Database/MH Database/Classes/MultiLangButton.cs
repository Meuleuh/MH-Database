using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MH_Database.Classes
{
    class MultiLangButton
    {
        internal MultiLang displayText = new MultiLang();
        internal Button linkedButton = null;
        internal MultiLangButton(Button button)
        {
            linkedButton = button;
            displayText.ChangeEveryLang("#_MISSING_TRANSLATION_#");
        }
        internal MultiLangButton(Button button, string everyLang)
        {
            linkedButton = button;
            displayText.ChangeEveryLang(everyLang);
        }
        internal MultiLangButton(Button button, string fr, string en) //Manipulating language procedure - Note 5
        {
            linkedButton = button;
            displayText.fr = fr;
            displayText.en = en;
        }
        internal void DisplayLang(string langToDisplay) //Manipulating language procedure - Note 6
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
