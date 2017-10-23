namespace PPE_MISSION3
{
    partial class FrmRapport
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
            this.components = new System.ComponentModel.Container();
            this.DateTB = new System.Windows.Forms.TextBox();
            this.BdsRapports = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DownloadBouton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MotifTB = new System.Windows.Forms.TextBox();
            this.BilanTB = new System.Windows.Forms.TextBox();
            this.IDVisiteurTB = new System.Windows.Forms.TextBox();
            this.IDMedecinTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BdsRapports)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTB
            // 
            this.DateTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BdsRapports, "date", true));
            this.DateTB.Location = new System.Drawing.Point(92, 50);
            this.DateTB.Name = "DateTB";
            this.DateTB.ReadOnly = true;
            this.DateTB.Size = new System.Drawing.Size(85, 26);
            this.DateTB.TabIndex = 1;
            // 
            // BdsRapports
            // 
            this.BdsRapports.DataSource = typeof(PPE_MISSION3.rapport);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date : ";
            // 
            // DownloadBouton
            // 
            this.DownloadBouton.Location = new System.Drawing.Point(316, 35);
            this.DownloadBouton.Name = "DownloadBouton";
            this.DownloadBouton.Size = new System.Drawing.Size(126, 57);
            this.DownloadBouton.TabIndex = 3;
            this.DownloadBouton.Text = "Telecharger";
            this.DownloadBouton.UseVisualStyleBackColor = true;
            this.DownloadBouton.Click += new System.EventHandler(this.DownloadBouton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Motif :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bilan :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID Medecin :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID Visiteur :";
            // 
            // MotifTB
            // 
            this.MotifTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BdsRapports, "motif", true));
            this.MotifTB.Location = new System.Drawing.Point(92, 118);
            this.MotifTB.Multiline = true;
            this.MotifTB.Name = "MotifTB";
            this.MotifTB.ReadOnly = true;
            this.MotifTB.Size = new System.Drawing.Size(245, 56);
            this.MotifTB.TabIndex = 8;
            // 
            // BilanTB
            // 
            this.BilanTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BdsRapports, "bilan", true));
            this.BilanTB.Location = new System.Drawing.Point(92, 213);
            this.BilanTB.Multiline = true;
            this.BilanTB.Name = "BilanTB";
            this.BilanTB.ReadOnly = true;
            this.BilanTB.Size = new System.Drawing.Size(322, 129);
            this.BilanTB.TabIndex = 9;
            // 
            // IDVisiteurTB
            // 
            this.IDVisiteurTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BdsRapports, "idVisiteur", true));
            this.IDVisiteurTB.Location = new System.Drawing.Point(131, 383);
            this.IDVisiteurTB.Name = "IDVisiteurTB";
            this.IDVisiteurTB.ReadOnly = true;
            this.IDVisiteurTB.Size = new System.Drawing.Size(96, 26);
            this.IDVisiteurTB.TabIndex = 10;
            // 
            // IDMedecinTB
            // 
            this.IDMedecinTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BdsRapports, "idMedecin", true));
            this.IDMedecinTB.Location = new System.Drawing.Point(357, 383);
            this.IDMedecinTB.Name = "IDMedecinTB";
            this.IDMedecinTB.ReadOnly = true;
            this.IDMedecinTB.Size = new System.Drawing.Size(85, 26);
            this.IDMedecinTB.TabIndex = 11;
            // 
            // FrmRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 437);
            this.Controls.Add(this.IDMedecinTB);
            this.Controls.Add(this.IDVisiteurTB);
            this.Controls.Add(this.BilanTB);
            this.Controls.Add(this.MotifTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DownloadBouton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTB);
            this.Name = "FrmRapport";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.BdsRapports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DateTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DownloadBouton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MotifTB;
        private System.Windows.Forms.TextBox BilanTB;
        private System.Windows.Forms.TextBox IDVisiteurTB;
        private System.Windows.Forms.TextBox IDMedecinTB;
        private System.Windows.Forms.BindingSource BdsRapports;
    }
}