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
    public partial class Game_Selection_International : Form
    {
        public string game = "\0";
        readonly string selected_language = "\0";

        //Every items creation
        //Buttons
        readonly MultiLangButton mbGameMonsterHunter;
        readonly MultiLangButton mbGameMonsterHunterFreedom2;
        readonly MultiLangButton mbGameMonsterHunter3;
        readonly MultiLangButton mbGameMonsterHunter3U;

        //Group Box
        readonly MultiLangGroupBox mgbFirstGen;
        readonly MultiLangGroupBox mgbSecondGen;
        readonly MultiLangGroupBox mgbThirdGen;
        public Game_Selection_International(string selected_language)
        {
            InitializeComponent();
            this.selected_language = selected_language;

            //Every items definition
            //Buttons
            mbGameMonsterHunter = new MultiLangButton(bGameMonsterHunter, Ressources.Lang.Buttons.mbGameMonsterHunter);
            mbGameMonsterHunterFreedom2 = new MultiLangButton(bGameMonsterHunterFreedom2, Ressources.Lang.Buttons.mbGameMonsterHunterFreedom2);
            mbGameMonsterHunter3 = new MultiLangButton(bGameMonsterHunter3, Ressources.Lang.Buttons.mbGameMonsterHunter3);
            mbGameMonsterHunter3U = new MultiLangButton(bGameMonsterHunter3U, Ressources.Lang.Buttons.mbGameMonsterHunter3U);

            //Group Box
            mgbFirstGen = new MultiLangGroupBox(gbFirstGen, Ressources.Lang.GroupBox.mgbFirstGen);
            mgbSecondGen = new MultiLangGroupBox(gbSecondGen, Ressources.Lang.GroupBox.mgbSecondGen);
            mgbThirdGen = new MultiLangGroupBox(gbThirdGen, Ressources.Lang.GroupBox.mgbThirdGen);
        }

        private void Game_Selection_Load(object sender, EventArgs e)
        {
            //Every items definition
            //Buttons
            mbGameMonsterHunter.DisplayLang(selected_language);
            mbGameMonsterHunterFreedom2.DisplayLang(selected_language);
            mbGameMonsterHunter3.DisplayLang(selected_language);
            mbGameMonsterHunter3U.DisplayLang(selected_language);

            //Group Box
            mgbFirstGen.DisplayLang(selected_language);
            mgbSecondGen.DisplayLang(selected_language);
            mgbThirdGen.DisplayLang(selected_language);
        }

        private void bGameMonsterHunter_Click(object sender, EventArgs e)
        {

        }

        private void bGameMonsterHunterFreedom2_Click(object sender, EventArgs e)
        {

        }

        private void bGameMonsterHunter3_Click(object sender, EventArgs e)
        {

        }

        private void bGameMonsterHunter3U_Click(object sender, EventArgs e)
        {

        }
    }
}