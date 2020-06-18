using System.Windows.Forms;

namespace MH_Database.Classes.MultiLang
{
    class MultiLangButton : Button
    {
        internal MultiLang displayText = new MultiLang();
        internal MultiLangButton()
        {
            displayText.ChangeNames("#_MISSING_TRANSLATION_#");
        }
        internal MultiLangButton(string everyLang)
        {
            displayText.ChangeNames(everyLang);
        }
        internal MultiLangButton(string fr, string en) //Manipulating language procedure - Note 1
        {
            displayText.fr = fr;
            displayText.en = en;
        }
        internal MultiLangButton(MultiLang multiLang)
        {
            displayText = multiLang;
        }
        internal void DisplayLang(string langToDisplay) //Manipulating language procedure - Note 2
        {
                displayText.ChangeActual(langToDisplay);
                Text = displayText.actual;
        }
    }
}
