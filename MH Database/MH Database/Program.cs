using System;
using System.Windows.Forms;

namespace MH_Database
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Language_Selection language_Selection = new Language_Selection();
            Application.Run(language_Selection);
            if (language_Selection.lang == "jp")
            {
                //Application.Run(game_Selection);
            }
            else if (language_Selection.lang == "cn")
            {
               //Application.Run(game_Selection);
            }
            else
            {
                Game_Selection_International game_Selection = new Game_Selection_International(language_Selection.lang);
                Application.Run(game_Selection);
            }
        }
    }
}
