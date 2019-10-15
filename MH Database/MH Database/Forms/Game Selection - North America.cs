using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MH_Database.Classes;

namespace MH_Database
{
    public partial class Game_Selection : Form
    {
        
        string selected_language = "\0";
        public Game_Selection(string selected_language)
        {
            InitializeComponent();
            this.selected_language = selected_language;
            
        }

        private void Game_Selection_Load(object sender, EventArgs e)
        {
            
        }
    }
}

/*  Exemple for using the MultiLangButton using button1: 
 *  
 *  public partial class Game_Selection : Form
 *  {
 *      MultiLangButton mButton1;
 *      string selected_language = "\0";
 *      public Game_Selection(string selected_language)
 *      {
 *          InitializeComponent();
 *          this.selected_language = selected_language;
 *          mButton1 = new MultiLangButton(button1, "fr", "en");
 *      }
 *
 *      private void Game_Selection_Load(object sender, EventArgs e)
 *      {
 *          mButton1.DisplayLang(selected_language);
 *      }
 *  }
 */