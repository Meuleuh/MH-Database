using System;
using System.Windows.Forms;

namespace MH_Database
{
    public partial class Language_Selection : Form
    {
        public string lang = "\0";
        public Language_Selection()
        {
            InitializeComponent();
        }

        private void French_language_Click(object sender, EventArgs e)
        {
            lang = "fr";
            Close();
        }

        private void English_language_Click(object sender, EventArgs e)
        {
            lang = "en";
            Close();
        }
    }
}
