namespace FenetreGraphique
{
    partial class FormAjouterLivre
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.tbxTitre = new System.Windows.Forms.TextBox();
            this.lblAnnéPublication = new System.Windows.Forms.Label();
            this.tbxAnnnéPublication = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.tbxISBN = new System.Windows.Forms.TextBox();
            this.cmbPublisher = new System.Windows.Forms.ComboBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lbxAuteur = new System.Windows.Forms.ListBox();
            this.lblauteur = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(95, 40);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(24, 13);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "titre";
            // 
            // tbxTitre
            // 
            this.tbxTitre.Location = new System.Drawing.Point(58, 56);
            this.tbxTitre.Name = "tbxTitre";
            this.tbxTitre.Size = new System.Drawing.Size(100, 20);
            this.tbxTitre.TabIndex = 1;
            // 
            // lblAnnéPublication
            // 
            this.lblAnnéPublication.AutoSize = true;
            this.lblAnnéPublication.Location = new System.Drawing.Point(67, 91);
            this.lblAnnéPublication.Name = "lblAnnéPublication";
            this.lblAnnéPublication.Size = new System.Drawing.Size(91, 13);
            this.lblAnnéPublication.TabIndex = 2;
            this.lblAnnéPublication.Text = "année publication";
            // 
            // tbxAnnnéPublication
            // 
            this.tbxAnnnéPublication.Location = new System.Drawing.Point(58, 107);
            this.tbxAnnnéPublication.Name = "tbxAnnnéPublication";
            this.tbxAnnnéPublication.Size = new System.Drawing.Size(100, 20);
            this.tbxAnnnéPublication.TabIndex = 3;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(84, 144);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 4;
            this.lblISBN.Text = "ISBN";
            // 
            // tbxISBN
            // 
            this.tbxISBN.Location = new System.Drawing.Point(58, 160);
            this.tbxISBN.Name = "tbxISBN";
            this.tbxISBN.Size = new System.Drawing.Size(100, 20);
            this.tbxISBN.TabIndex = 5;
            // 
            // cmbPublisher
            // 
            this.cmbPublisher.FormattingEnabled = true;
            this.cmbPublisher.Location = new System.Drawing.Point(58, 214);
            this.cmbPublisher.Name = "cmbPublisher";
            this.cmbPublisher.Size = new System.Drawing.Size(121, 21);
            this.cmbPublisher.TabIndex = 6;
            this.cmbPublisher.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(84, 198);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(50, 13);
            this.lblPublisher.TabIndex = 7;
            this.lblPublisher.Text = "Publisher";
            // 
            // lbxAuteur
            // 
            this.lbxAuteur.FormattingEnabled = true;
            this.lbxAuteur.Location = new System.Drawing.Point(59, 275);
            this.lbxAuteur.Name = "lbxAuteur";
            this.lbxAuteur.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxAuteur.Size = new System.Drawing.Size(120, 121);
            this.lbxAuteur.TabIndex = 8;
            // 
            // lblauteur
            // 
            this.lblauteur.AutoSize = true;
            this.lblauteur.Location = new System.Drawing.Point(87, 255);
            this.lblauteur.Name = "lblauteur";
            this.lblauteur.Size = new System.Drawing.Size(36, 17);
            this.lblauteur.TabIndex = 9;
            this.lblauteur.Text = "auteur";
            this.lblauteur.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblauteur.UseCompatibleTextRendering = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(70, 414);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(96, 24);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormAjouterLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblauteur);
            this.Controls.Add(this.lbxAuteur);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.cmbPublisher);
            this.Controls.Add(this.tbxISBN);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.tbxAnnnéPublication);
            this.Controls.Add(this.lblAnnéPublication);
            this.Controls.Add(this.tbxTitre);
            this.Controls.Add(this.lblTitre);
            this.Name = "FormAjouterLivre";
            this.Text = "FormAjouterLivre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox tbxTitre;
        private System.Windows.Forms.Label lblAnnéPublication;
        private System.Windows.Forms.TextBox tbxAnnnéPublication;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox tbxISBN;
        private System.Windows.Forms.ComboBox cmbPublisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.ListBox lbxAuteur;
        private System.Windows.Forms.Label lblauteur;
        private System.Windows.Forms.Button btnAjouter;
    }
}