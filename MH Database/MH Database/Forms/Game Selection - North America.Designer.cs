namespace MH_Database
{
    partial class Game_Selection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Selection));
            this.groupFirstGen = new System.Windows.Forms.GroupBox();
            this.gameMonsterHunter = new System.Windows.Forms.Button();
            this.groupFirstGen.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFirstGen
            // 
            this.groupFirstGen.Controls.Add(this.gameMonsterHunter);
            this.groupFirstGen.Location = new System.Drawing.Point(13, 13);
            this.groupFirstGen.Name = "groupFirstGen";
            this.groupFirstGen.Size = new System.Drawing.Size(775, 100);
            this.groupFirstGen.TabIndex = 0;
            this.groupFirstGen.TabStop = false;
            this.groupFirstGen.Text = "groupFirstGen";
            // 
            // gameMonsterHunter
            // 
            this.gameMonsterHunter.Location = new System.Drawing.Point(7, 20);
            this.gameMonsterHunter.Name = "gameMonsterHunter";
            this.gameMonsterHunter.Size = new System.Drawing.Size(120, 23);
            this.gameMonsterHunter.TabIndex = 0;
            this.gameMonsterHunter.Text = "gameMonsterHunter";
            this.gameMonsterHunter.UseVisualStyleBackColor = true;
            // 
            // Game_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupFirstGen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game_Selection";
            this.Text = "Game Selection";
            this.Load += new System.EventHandler(this.Game_Selection_Load);
            this.groupFirstGen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupFirstGen;
        private System.Windows.Forms.Button gameMonsterHunter;
    }
}