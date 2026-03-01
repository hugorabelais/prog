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
            this.lbxPortDepart = new System.Windows.Forms.ListBox();
            this.lbxPortArrivee = new System.Windows.Forms.ListBox();
            this.lblPortArrivee = new System.Windows.Forms.Label();
            this.btnAjouterLiaison = new System.Windows.Forms.Button();
            this.lblDistance = new System.Windows.Forms.Label();
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.ItemHeight = 20;
            this.lbxSecteur.Location = new System.Drawing.Point(46, 57);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(168, 304);
            this.lbxSecteur.TabIndex = 0;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(97, 18);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(65, 20);
            this.lblSecteur.TabIndex = 1;
            this.lblSecteur.Text = "Secteur";
            // 
            // lblPortDepart
            // 
            this.lblPortDepart.AutoSize = true;
            this.lblPortDepart.Location = new System.Drawing.Point(252, 68);
            this.lblPortDepart.Name = "lblPortDepart";
            this.lblPortDepart.Size = new System.Drawing.Size(96, 20);
            this.lblPortDepart.TabIndex = 2;
            this.lblPortDepart.Text = "Port départ :";
            this.lblPortDepart.UseMnemonic = false;
            // 
            // lbxPortDepart
            // 
            this.lbxPortDepart.FormattingEnabled = true;
            this.lbxPortDepart.ItemHeight = 20;
            this.lbxPortDepart.Location = new System.Drawing.Point(354, 57);
            this.lbxPortDepart.Name = "lbxPortDepart";
            this.lbxPortDepart.Size = new System.Drawing.Size(120, 104);
            this.lbxPortDepart.TabIndex = 3;
            this.lbxPortDepart.SelectedIndexChanged += new System.EventHandler(this.lbxPortDepart_SelectedIndexChanged);
            // 
            // lbxPortArrivee
            // 
            this.lbxPortArrivee.FormattingEnabled = true;
            this.lbxPortArrivee.ItemHeight = 20;
            this.lbxPortArrivee.Location = new System.Drawing.Point(594, 57);
            this.lbxPortArrivee.Name = "lbxPortArrivee";
            this.lbxPortArrivee.Size = new System.Drawing.Size(120, 104);
            this.lbxPortArrivee.TabIndex = 4;
            // 
            // lblPortArrivee
            // 
            this.lblPortArrivee.AutoSize = true;
            this.lblPortArrivee.Location = new System.Drawing.Point(487, 68);
            this.lblPortArrivee.Name = "lblPortArrivee";
            this.lblPortArrivee.Size = new System.Drawing.Size(101, 20);
            this.lblPortArrivee.TabIndex = 5;
            this.lblPortArrivee.Text = "Port d\'arrivée";
            // 
            // btnAjouterLiaison
            // 
            this.btnAjouterLiaison.Location = new System.Drawing.Point(567, 316);
            this.btnAjouterLiaison.Name = "btnAjouterLiaison";
            this.btnAjouterLiaison.Size = new System.Drawing.Size(75, 45);
            this.btnAjouterLiaison.TabIndex = 6;
            this.btnAjouterLiaison.Text = "ajouter";
            this.btnAjouterLiaison.UseVisualStyleBackColor = true;
            this.btnAjouterLiaison.Click += new System.EventHandler(this.btnAjouterLiaison_Click);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(505, 231);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(81, 20);
            this.lblDistance.TabIndex = 7;
            this.lblDistance.Text = "distance : ";
            // 
            // tbxDistance
            // 
            this.tbxDistance.Location = new System.Drawing.Point(604, 231);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(100, 26);
            this.tbxDistance.TabIndex = 8;
            // 
            // FormAjouterLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.btnAjouterLiaison);
            this.Controls.Add(this.lblPortArrivee);
            this.Controls.Add(this.lbxPortArrivee);
            this.Controls.Add(this.lbxPortDepart);
            this.Controls.Add(this.lblPortDepart);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteur);
            this.Name = "FormAjouterLiaison";
            this.Text = "FormAjouterLiaison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label lblPortDepart;
        private System.Windows.Forms.ListBox lbxPortDepart;
        private System.Windows.Forms.ListBox lbxPortArrivee;
        private System.Windows.Forms.Label lblPortArrivee;
        private System.Windows.Forms.Button btnAjouterLiaison;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox tbxDistance;
    }
}