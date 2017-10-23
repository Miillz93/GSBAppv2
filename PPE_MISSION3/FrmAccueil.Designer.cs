namespace PPE_MISSION3
{
    partial class FrmAccueil
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
            this.MenuAccueil = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMedecinToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMedecinGerer = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAccueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuAccueil
            // 
            this.MenuAccueil.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuAccueil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.médicamentToolStripMenuItem,
            this.MenuMedecinToolStrip,
            this.visiteurToolStripMenuItem});
            this.MenuAccueil.Location = new System.Drawing.Point(0, 0);
            this.MenuAccueil.Name = "MenuAccueil";
            this.MenuAccueil.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.MenuAccueil.Size = new System.Drawing.Size(709, 24);
            this.MenuAccueil.TabIndex = 1;
            this.MenuAccueil.Text = "MenuAccueil";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // médicamentToolStripMenuItem
            // 
            this.médicamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererToolStripMenuItem,
            this.listeToolStripMenuItem});
            this.médicamentToolStripMenuItem.Name = "médicamentToolStripMenuItem";
            this.médicamentToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.médicamentToolStripMenuItem.Text = "Médicament";
            // 
            // gererToolStripMenuItem
            // 
            this.gererToolStripMenuItem.Name = "gererToolStripMenuItem";
            this.gererToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.gererToolStripMenuItem.Text = "Gerer";
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.listeToolStripMenuItem.Text = "Liste";
            // 
            // MenuMedecinToolStrip
            // 
            this.MenuMedecinToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMedecinGerer});
            this.MenuMedecinToolStrip.Name = "MenuMedecinToolStrip";
            this.MenuMedecinToolStrip.Size = new System.Drawing.Size(65, 22);
            this.MenuMedecinToolStrip.Text = "Medecin";
            // 
            // MenuMedecinGerer
            // 
            this.MenuMedecinGerer.Name = "MenuMedecinGerer";
            this.MenuMedecinGerer.Size = new System.Drawing.Size(102, 22);
            this.MenuMedecinGerer.Text = "Gerer";
            this.MenuMedecinGerer.Click += new System.EventHandler(this.MenuMedecinGerer_Click);
            // 
            // visiteurToolStripMenuItem
            // 
            this.visiteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererToolStripMenuItem2});
            this.visiteurToolStripMenuItem.Name = "visiteurToolStripMenuItem";
            this.visiteurToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.visiteurToolStripMenuItem.Text = "Visiteur";
            // 
            // gererToolStripMenuItem2
            // 
            this.gererToolStripMenuItem2.Name = "gererToolStripMenuItem2";
            this.gererToolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.gererToolStripMenuItem2.Text = "Gerer";
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 367);
            this.Controls.Add(this.MenuAccueil);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAccueil";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.MenuAccueil.ResumeLayout(false);
            this.MenuAccueil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuAccueil;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuMedecinToolStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuMedecinGerer;
        private System.Windows.Forms.ToolStripMenuItem visiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererToolStripMenuItem2;
    }
}

