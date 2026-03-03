namespace ProjetAtlantik
{
    partial class FormTarifLiasonPeriode
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
            this.lblSecteurs = new System.Windows.Forms.Label();
            this.lbxSecteurs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.lblperiode = new System.Windows.Forms.Label();
            this.cmbPeriode = new System.Windows.Forms.ComboBox();
            this.gbxcategorie = new System.Windows.Forms.GroupBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSecteurs
            // 
            this.lblSecteurs.AutoSize = true;
            this.lblSecteurs.Location = new System.Drawing.Point(61, 33);
            this.lblSecteurs.Name = "lblSecteurs";
            this.lblSecteurs.Size = new System.Drawing.Size(58, 13);
            this.lblSecteurs.TabIndex = 0;
            this.lblSecteurs.Text = "Secteurs : ";
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.Location = new System.Drawing.Point(33, 49);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(121, 238);
            this.lbxSecteurs.TabIndex = 1;
            this.lbxSecteurs.SelectedIndexChanged += new System.EventHandler(this.lbxSecteurs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liaison : ";
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(33, 329);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaison.TabIndex = 3;
            // 
            // lblperiode
            // 
            this.lblperiode.AutoSize = true;
            this.lblperiode.Location = new System.Drawing.Point(61, 392);
            this.lblperiode.Name = "lblperiode";
            this.lblperiode.Size = new System.Drawing.Size(52, 13);
            this.lblperiode.TabIndex = 4;
            this.lblperiode.Text = "Période : ";
            // 
            // cmbPeriode
            // 
            this.cmbPeriode.FormattingEnabled = true;
            this.cmbPeriode.Location = new System.Drawing.Point(119, 392);
            this.cmbPeriode.Name = "cmbPeriode";
            this.cmbPeriode.Size = new System.Drawing.Size(121, 21);
            this.cmbPeriode.TabIndex = 5;
            // 
            // gbxcategorie
            // 
            this.gbxcategorie.Location = new System.Drawing.Point(278, 49);
            this.gbxcategorie.Name = "gbxcategorie";
            this.gbxcategorie.Size = new System.Drawing.Size(424, 294);
            this.gbxcategorie.TabIndex = 6;
            this.gbxcategorie.TabStop = false;
            this.gbxcategorie.Text = "Tarifs par categorie-type";
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(509, 390);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(111, 23);
            this.btnajouter.TabIndex = 7;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // FormTarifLiasonPeriode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.gbxcategorie);
            this.Controls.Add(this.cmbPeriode);
            this.Controls.Add(this.lblperiode);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxSecteurs);
            this.Controls.Add(this.lblSecteurs);
            this.Name = "FormTarifLiasonPeriode";
            this.Text = "FormTarifLiasonPeriode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecteurs;
        private System.Windows.Forms.ListBox lbxSecteurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Label lblperiode;
        private System.Windows.Forms.ComboBox cmbPeriode;
        private System.Windows.Forms.GroupBox gbxcategorie;
        private System.Windows.Forms.Button btnajouter;
    }
}