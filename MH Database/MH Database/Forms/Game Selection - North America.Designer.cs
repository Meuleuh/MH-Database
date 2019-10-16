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
            this.gbFirstGen = new System.Windows.Forms.GroupBox();
            this.bGameMonsterHunter = new System.Windows.Forms.Button();
            this.gbSecondGen = new System.Windows.Forms.GroupBox();
            this.bGameMonsterHunterFreedom2 = new System.Windows.Forms.Button();
            this.gbThirdGen = new System.Windows.Forms.GroupBox();
            this.bGameMonsterHunter3U = new System.Windows.Forms.Button();
            this.bGameMonsterHunter3 = new System.Windows.Forms.Button();
            this.gbFirstGen.SuspendLayout();
            this.gbSecondGen.SuspendLayout();
            this.gbThirdGen.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFirstGen
            // 
            this.gbFirstGen.Controls.Add(this.bGameMonsterHunter);
            this.gbFirstGen.Location = new System.Drawing.Point(13, 13);
            this.gbFirstGen.Name = "groupFirstGen";
            this.gbFirstGen.Size = new System.Drawing.Size(775, 100);
            this.gbFirstGen.TabIndex = 0;
            this.gbFirstGen.TabStop = false;
            this.gbFirstGen.Text = "groupFirstGen";
            // 
            // gameMonsterHunter
            // 
            this.bGameMonsterHunter.Location = new System.Drawing.Point(7, 20);
            this.bGameMonsterHunter.Name = "gameMonsterHunter";
            this.bGameMonsterHunter.Size = new System.Drawing.Size(120, 23);
            this.bGameMonsterHunter.TabIndex = 0;
            this.bGameMonsterHunter.Text = "gameMonsterHunter";
            this.bGameMonsterHunter.UseVisualStyleBackColor = true;
            this.bGameMonsterHunter.Click += new System.EventHandler(this.GameMonsterHunter_Click);
            // 
            // groupSecondGen
            // 
            this.gbSecondGen.Controls.Add(this.bGameMonsterHunterFreedom2);
            this.gbSecondGen.Location = new System.Drawing.Point(13, 119);
            this.gbSecondGen.Name = "groupSecondGen";
            this.gbSecondGen.Size = new System.Drawing.Size(775, 100);
            this.gbSecondGen.TabIndex = 1;
            this.gbSecondGen.TabStop = false;
            this.gbSecondGen.Text = "groupSecondGen";
            // 
            // gameMonsterHunterFreedom2
            // 
            this.bGameMonsterHunterFreedom2.Location = new System.Drawing.Point(7, 20);
            this.bGameMonsterHunterFreedom2.Name = "gameMonsterHunterFreedom2";
            this.bGameMonsterHunterFreedom2.Size = new System.Drawing.Size(120, 23);
            this.bGameMonsterHunterFreedom2.TabIndex = 0;
            this.bGameMonsterHunterFreedom2.Text = "gameMonsterHunterFreedom2";
            this.bGameMonsterHunterFreedom2.UseVisualStyleBackColor = true;
            this.bGameMonsterHunterFreedom2.Click += new System.EventHandler(this.GameMonsterHunterFreedom2_Click);
            // 
            // groupThirdGen
            // 
            this.gbThirdGen.Controls.Add(this.bGameMonsterHunter3U);
            this.gbThirdGen.Controls.Add(this.bGameMonsterHunter3);
            this.gbThirdGen.Location = new System.Drawing.Point(13, 225);
            this.gbThirdGen.Name = "groupThirdGen";
            this.gbThirdGen.Size = new System.Drawing.Size(775, 100);
            this.gbThirdGen.TabIndex = 2;
            this.gbThirdGen.TabStop = false;
            this.gbThirdGen.Text = "groupThirdGen";
            // 
            // gameMonsterHunter3U
            // 
            this.bGameMonsterHunter3U.Location = new System.Drawing.Point(649, 20);
            this.bGameMonsterHunter3U.Name = "gameMonsterHunter3U";
            this.bGameMonsterHunter3U.Size = new System.Drawing.Size(120, 23);
            this.bGameMonsterHunter3U.TabIndex = 1;
            this.bGameMonsterHunter3U.Text = "gameMonsterHunter3U";
            this.bGameMonsterHunter3U.UseVisualStyleBackColor = true;
            this.bGameMonsterHunter3U.Click += new System.EventHandler(this.GameMonsterHunter3U_Click);
            // 
            // gameMonsterHunter3
            // 
            this.bGameMonsterHunter3.Location = new System.Drawing.Point(7, 20);
            this.bGameMonsterHunter3.Name = "gameMonsterHunter3";
            this.bGameMonsterHunter3.Size = new System.Drawing.Size(120, 23);
            this.bGameMonsterHunter3.TabIndex = 0;
            this.bGameMonsterHunter3.Text = "gameMonsterHunter3";
            this.bGameMonsterHunter3.UseVisualStyleBackColor = true;
            this.bGameMonsterHunter3.Click += new System.EventHandler(this.GameMonsterHunter3_Click);
            // 
            // Game_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbThirdGen);
            this.Controls.Add(this.gbSecondGen);
            this.Controls.Add(this.gbFirstGen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game_Selection";
            this.Text = "Game Selection";
            this.Load += new System.EventHandler(this.Game_Selection_Load);
            this.gbFirstGen.ResumeLayout(false);
            this.gbSecondGen.ResumeLayout(false);
            this.gbThirdGen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFirstGen;
        private System.Windows.Forms.Button bGameMonsterHunter;
        private System.Windows.Forms.GroupBox gbSecondGen;
        private System.Windows.Forms.Button bGameMonsterHunterFreedom2;
        private System.Windows.Forms.GroupBox gbThirdGen;
        private System.Windows.Forms.Button bGameMonsterHunter3U;
        private System.Windows.Forms.Button bGameMonsterHunter3;
    }
}