namespace ProjetAtlantik
{
    partial class FormAjouterTraverse
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
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.lblNomBateau = new System.Windows.Forms.Label();
            this.cbxNomBateau = new System.Windows.Forms.ComboBox();
            this.lblDateDepart = new System.Windows.Forms.Label();
            this.dateDepart = new System.Windows.Forms.DateTimePicker();
            this.lblDateArrive = new System.Windows.Forms.Label();
            this.dateArrive = new System.Windows.Forms.DateTimePicker();
            this.lblHeureDepart = new System.Windows.Forms.Label();
            this.heureDepart = new System.Windows.Forms.DateTimePicker();
            this.lblHeureArrive = new System.Windows.Forms.Label();
            this.heureArrive = new System.Windows.Forms.DateTimePicker();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(48, 29);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(50, 13);
            this.lblSecteur.TabIndex = 0;
            this.lblSecteur.Text = "Secteur :";
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.Location = new System.Drawing.Point(51, 66);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(120, 238);
            this.lbxSecteur.TabIndex = 1;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(48, 316);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(46, 13);
            this.lblLiaison.TabIndex = 2;
            this.lblLiaison.Text = "Liaison :";
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(50, 332);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaison.TabIndex = 3;
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Location = new System.Drawing.Point(332, 29);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(75, 13);
            this.lblNomBateau.TabIndex = 4;
            this.lblNomBateau.Text = "Nom Bateau : ";
            // 
            // cbxNomBateau
            // 
            this.cbxNomBateau.FormattingEnabled = true;
            this.cbxNomBateau.Location = new System.Drawing.Point(532, 29);
            this.cbxNomBateau.Name = "cbxNomBateau";
            this.cbxNomBateau.Size = new System.Drawing.Size(121, 21);
            this.cbxNomBateau.TabIndex = 5;
            // 
            // lblDateDepart
            // 
            this.lblDateDepart.AutoSize = true;
            this.lblDateDepart.Location = new System.Drawing.Point(302, 197);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(69, 13);
            this.lblDateDepart.TabIndex = 6;
            this.lblDateDepart.Text = "Date depart :";
            // 
            // dateDepart
            // 
            this.dateDepart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDepart.Location = new System.Drawing.Point(389, 197);
            this.dateDepart.Name = "dateDepart";
            this.dateDepart.Size = new System.Drawing.Size(85, 20);
            this.dateDepart.TabIndex = 7;
            // 
            // lblDateArrive
            // 
            this.lblDateArrive.AutoSize = true;
            this.lblDateArrive.Location = new System.Drawing.Point(296, 277);
            this.lblDateArrive.Name = "lblDateArrive";
            this.lblDateArrive.Size = new System.Drawing.Size(75, 13);
            this.lblDateArrive.TabIndex = 8;
            this.lblDateArrive.Text = "Date Arrivée : ";
            // 
            // dateArrive
            // 
            this.dateArrive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateArrive.Location = new System.Drawing.Point(389, 277);
            this.dateArrive.Name = "dateArrive";
            this.dateArrive.Size = new System.Drawing.Size(85, 20);
            this.dateArrive.TabIndex = 9;
            // 
            // lblHeureDepart
            // 
            this.lblHeureDepart.AutoSize = true;
            this.lblHeureDepart.Location = new System.Drawing.Point(529, 197);
            this.lblHeureDepart.Name = "lblHeureDepart";
            this.lblHeureDepart.Size = new System.Drawing.Size(77, 13);
            this.lblHeureDepart.TabIndex = 10;
            this.lblHeureDepart.Text = "Heure Depart :";
            // 
            // heureDepart
            // 
            this.heureDepart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.heureDepart.Location = new System.Drawing.Point(606, 197);
            this.heureDepart.Name = "heureDepart";
            this.heureDepart.Size = new System.Drawing.Size(69, 20);
            this.heureDepart.TabIndex = 11;
            // 
            // lblHeureArrive
            // 
            this.lblHeureArrive.AutoSize = true;
            this.lblHeureArrive.Location = new System.Drawing.Point(529, 277);
            this.lblHeureArrive.Name = "lblHeureArrive";
            this.lblHeureArrive.Size = new System.Drawing.Size(78, 13);
            this.lblHeureArrive.TabIndex = 12;
            this.lblHeureArrive.Text = "Heure Arrivée :";
            // 
            // heureArrive
            // 
            this.heureArrive.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.heureArrive.Location = new System.Drawing.Point(613, 270);
            this.heureArrive.Name = "heureArrive";
            this.heureArrive.Size = new System.Drawing.Size(62, 20);
            this.heureArrive.TabIndex = 13;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(578, 364);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormAjouterTraverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.heureArrive);
            this.Controls.Add(this.lblHeureArrive);
            this.Controls.Add(this.heureDepart);
            this.Controls.Add(this.lblHeureDepart);
            this.Controls.Add(this.dateArrive);
            this.Controls.Add(this.lblDateArrive);
            this.Controls.Add(this.dateDepart);
            this.Controls.Add(this.lblDateDepart);
            this.Controls.Add(this.cbxNomBateau);
            this.Controls.Add(this.lblNomBateau);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lbxSecteur);
            this.Controls.Add(this.lblSecteur);
            this.Name = "FormAjouterTraverse";
            this.Text = "FormAjouterTraverse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.ComboBox cbxNomBateau;
        private System.Windows.Forms.Label lblDateDepart;
        private System.Windows.Forms.DateTimePicker dateDepart;
        private System.Windows.Forms.Label lblDateArrive;
        private System.Windows.Forms.DateTimePicker dateArrive;
        private System.Windows.Forms.Label lblHeureDepart;
        private System.Windows.Forms.DateTimePicker heureDepart;
        private System.Windows.Forms.Label lblHeureArrive;
        private System.Windows.Forms.DateTimePicker heureArrive;
        private System.Windows.Forms.Button btnAjouter;
    }
}