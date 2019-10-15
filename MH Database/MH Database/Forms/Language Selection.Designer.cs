namespace MH_Database
{
    partial class Language_Selection
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Language_Selection));
            this.French_language = new System.Windows.Forms.Button();
            this.English_language = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // French_language
            // 
            this.French_language.Image = global::MH_Database.Properties.Resources.France;
            this.French_language.Location = new System.Drawing.Point(12, 12);
            this.French_language.Name = "French_language";
            this.French_language.Size = new System.Drawing.Size(91, 28);
            this.French_language.TabIndex = 0;
            this.French_language.Text = "Français";
            this.French_language.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.French_language.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.French_language.UseVisualStyleBackColor = true;
            this.French_language.Click += new System.EventHandler(this.French_language_Click);
            // 
            // English_language
            // 
            this.English_language.Image = global::MH_Database.Properties.Resources.US;
            this.English_language.Location = new System.Drawing.Point(109, 12);
            this.English_language.Name = "English_language";
            this.English_language.Size = new System.Drawing.Size(91, 28);
            this.English_language.TabIndex = 1;
            this.English_language.Text = "English";
            this.English_language.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.English_language.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.English_language.UseVisualStyleBackColor = true;
            this.English_language.Click += new System.EventHandler(this.English_language_Click);
            // 
            // Language_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 52);
            this.Controls.Add(this.English_language);
            this.Controls.Add(this.French_language);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Language_Selection";
            this.Text = "Language Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button French_language;
        private System.Windows.Forms.Button English_language;
    }
}

