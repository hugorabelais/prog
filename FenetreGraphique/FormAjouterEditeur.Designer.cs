namespace FenetreGraphique
{
    partial class FormAjouterEditeur
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
            this.lblNom = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.tbxAdresse = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.tbxVille = new System.Windows.Forms.TextBox();
            this.lblZIP = new System.Windows.Forms.Label();
            this.tbxZIP = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(350, 61);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(27, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "nom";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(312, 77);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(100, 20);
            this.tbxNom.TabIndex = 1;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(333, 116);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(44, 13);
            this.lblAdresse.TabIndex = 2;
            this.lblAdresse.Text = "adresse";
            // 
            // tbxAdresse
            // 
            this.tbxAdresse.Location = new System.Drawing.Point(312, 132);
            this.tbxAdresse.Name = "tbxAdresse";
            this.tbxAdresse.Size = new System.Drawing.Size(100, 20);
            this.tbxAdresse.TabIndex = 3;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(342, 170);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(25, 13);
            this.lblVille.TabIndex = 4;
            this.lblVille.Text = "ville";
            // 
            // tbxVille
            // 
            this.tbxVille.Location = new System.Drawing.Point(312, 186);
            this.tbxVille.Name = "tbxVille";
            this.tbxVille.Size = new System.Drawing.Size(100, 20);
            this.tbxVille.TabIndex = 5;
            // 
            // lblZIP
            // 
            this.lblZIP.AutoSize = true;
            this.lblZIP.Location = new System.Drawing.Point(350, 233);
            this.lblZIP.Name = "lblZIP";
            this.lblZIP.Size = new System.Drawing.Size(24, 13);
            this.lblZIP.TabIndex = 6;
            this.lblZIP.Text = "ZIP";
            // 
            // tbxZIP
            // 
            this.tbxZIP.Location = new System.Drawing.Point(312, 249);
            this.tbxZIP.Name = "tbxZIP";
            this.tbxZIP.Size = new System.Drawing.Size(100, 20);
            this.tbxZIP.TabIndex = 7;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(323, 305);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormAjouterEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.tbxZIP);
            this.Controls.Add(this.lblZIP);
            this.Controls.Add(this.tbxVille);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.tbxAdresse);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.lblNom);
            this.Name = "FormAjouterEditeur";
            this.Text = "FormAjouterEditeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox tbxAdresse;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox tbxVille;
        private System.Windows.Forms.Label lblZIP;
        private System.Windows.Forms.TextBox tbxZIP;
        private System.Windows.Forms.Button btnAjouter;
    }
}