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
            Game_Selection game_Selection = new Game_Selection(language_Selection.lang);
            Application.Run(game_Selection);
        }
    }
}
