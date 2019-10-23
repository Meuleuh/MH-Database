using System;
using System.Windows.Forms;

namespace MH_Database
{
    public partial class Language_Selection : Form
    {
        public string lang = "\0";
        public bool closedByProgram = false;
        public Language_Selection()
        {
            InitializeComponent();
        }

        private void French_language_Click(object sender, EventArgs e)
        {
            lang = "fr";
            Hide();
            Game_Selection_International game_Selection = new Game_Selection_International(lang);
            game_Selection.ShowDialog();
            Close();
        }

        private void English_language_Click(object sender, EventArgs e)
        {
            lang = "en";
            Hide();
            Game_Selection_International game_Selection = new Game_Selection_International(lang);
            game_Selection.ShowDialog();
            Close();
        }
    }
}
