namespace ProjetAtlantik
{
    partial class FormAjouterLiaison
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
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lblPortDepart = new System.Windows.Forms.Label();
            this.lblPortArrivee = new System.Windows.Forms.Label();
            this.btnAjouterLiaison = new System.Windows.Forms.Button();
            this.lblDistance = new System.Windows.Forms.Label();
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.cmbPortDepart = new System.Windows.Forms.ComboBox();
            this.cmbPortArrivee = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.Location = new System.Drawing.Point(11, 35);
            this.lbxSecteur.Margin = new System.Windows.Forms.Padding(2);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(113, 199);
            this.lbxSecteur.TabIndex = 0;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(39, 9);
            this.lblSecteur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(44, 13);
            this.lblSecteur.TabIndex = 1;
            this.lblSecteur.Text = "Secteur";
            // 
            // lblPortDepart
            // 
            this.lblPortDepart.AutoSize = true;
            this.lblPortDepart.Location = new System.Drawing.Point(128, 47);
            this.lblPortDepart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPortDepart.Name = "lblPortDepart";
            this.lblPortDepart.Size = new System.Drawing.Size(65, 13);
            this.lblPortDepart.TabIndex = 2;
            this.lblPortDepart.Text = "Port départ :";
            this.lblPortDepart.UseMnemonic = false;
            // 
            // lblPortArrivee
            // 
            this.lblPortArrivee.AutoSize = true;
            this.lblPortArrivee.Location = new System.Drawing.Point(324, 44);
            this.lblPortArrivee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPortArrivee.Name = "lblPortArrivee";
            this.lblPortArrivee.Size = new System.Drawing.Size(69, 13);
            this.lblPortArrivee.TabIndex = 5;
            this.lblPortArrivee.Text = "Port d\'arrivée";
            // 
            // btnAjouterLiaison
            // 
            this.btnAjouterLiaison.Location = new System.Drawing.Point(378, 205);
            this.btnAjouterLiaison.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouterLiaison.Name = "btnAjouterLiaison";
            this.btnAjouterLiaison.Size = new System.Drawing.Size(50, 29);
            this.btnAjouterLiaison.TabIndex = 6;
            this.btnAjouterLiaison.Text = "ajouter";
            this.btnAjouterLiaison.UseVisualStyleBackColor = true;
            this.btnAjouterLiaison.Click += new System.EventHandler(this.btnAjouterLiaison_Click);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(337, 150);
            this.lblDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(56, 13);
            this.lblDistance.TabIndex = 7;
            this.lblDistance.Text = "distance : ";
            // 
            // tbxDistance
            // 
            this.tbxDistance.Location = new System.Drawing.Point(403, 150);
            this.tbxDistance.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(68, 20);
            this.tbxDistance.TabIndex = 8;
            this.tbxDistance.Validating += new System.ComponentModel.CancelEventHandler(this.tbxDistance_Validating);
            // 
            // cmbPortDepart
            // 
            this.cmbPortDepart.FormattingEnabled = true;
            this.cmbPortDepart.Location = new System.Drawing.Point(198, 44);
            this.cmbPortDepart.Name = "cmbPortDepart";
            this.cmbPortDepart.Size = new System.Drawing.Size(121, 21);
            this.cmbPortDepart.TabIndex = 9;
            // 
            // cmbPortArrivee
            // 
            this.cmbPortArrivee.FormattingEnabled = true;
            this.cmbPortArrivee.Location = new System.Drawing.Point(403, 41);
            this.cmbPortArrivee.Name = "cmbPortArrivee";
            this.cmbPortArrivee.Size = new System.Drawing.Size(121, 21);
            this.cmbPortArrivee.TabIndex = 10;
            // 
            // FormAjouterLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.cmbPortArrivee);
            this.Controls.Add(this.cmbPortDepart);
            this.Controls.Add(this.tbxDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.btnAjouterLiaison);
            this.Controls.Add(this.lblPortArrivee);
            this.Controls.Add(this.lblPortDepart);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteur);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAjouterLiaison";
            this.Text = "FormAjouterLiaison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label lblPortDepart;
        private System.Windows.Forms.Label lblPortArrivee;
        private System.Windows.Forms.Button btnAjouterLiaison;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox tbxDistance;
        private System.Windows.Forms.ComboBox cmbPortDepart;
        private System.Windows.Forms.ComboBox cmbPortArrivee;
    }
}