namespace prj_Cesi_KARAKUS
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listeContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.détailContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeContactsToolStripMenuItem,
            this.rechercheContactToolStripMenuItem,
            this.détailContactToolStripMenuItem,
            this.ajouterUtilisateurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listeContactsToolStripMenuItem
            // 
            this.listeContactsToolStripMenuItem.Name = "listeContactsToolStripMenuItem";
            this.listeContactsToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.listeContactsToolStripMenuItem.Text = "Liste Contacts";
            this.listeContactsToolStripMenuItem.Click += new System.EventHandler(this.listeContactsToolStripMenuItem_Click);
            // 
            // rechercheContactToolStripMenuItem
            // 
            this.rechercheContactToolStripMenuItem.Name = "rechercheContactToolStripMenuItem";
            this.rechercheContactToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.rechercheContactToolStripMenuItem.Text = "Recherche Contact";
            this.rechercheContactToolStripMenuItem.Click += new System.EventHandler(this.rechercheContactToolStripMenuItem_Click);
            // 
            // détailContactToolStripMenuItem
            // 
            this.détailContactToolStripMenuItem.Name = "détailContactToolStripMenuItem";
            this.détailContactToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.détailContactToolStripMenuItem.Text = "Détail Contact";
            this.détailContactToolStripMenuItem.Click += new System.EventHandler(this.détailContactToolStripMenuItem_Click);
            // 
            // ajouterUtilisateurToolStripMenuItem
            // 
            this.ajouterUtilisateurToolStripMenuItem.Name = "ajouterUtilisateurToolStripMenuItem";
            this.ajouterUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.ajouterUtilisateurToolStripMenuItem.Text = "Ajouter Utilisateur";
            this.ajouterUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUtilisateurToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 624);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listeContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem détailContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUtilisateurToolStripMenuItem;
    }
}

