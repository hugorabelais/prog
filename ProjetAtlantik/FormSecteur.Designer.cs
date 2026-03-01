namespace ProjetAtlantik
{
    partial class FormSecteur
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
            this.lblAjouterSecteur = new System.Windows.Forms.Label();
            this.tbxAjouterSecteur = new System.Windows.Forms.TextBox();
            this.btnAjouterSecteur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAjouterSecteur
            // 
            this.lblAjouterSecteur.AutoSize = true;
            this.lblAjouterSecteur.Location = new System.Drawing.Point(110, 86);
            this.lblAjouterSecteur.Name = "lblAjouterSecteur";
            this.lblAjouterSecteur.Size = new System.Drawing.Size(143, 20);
            this.lblAjouterSecteur.TabIndex = 0;
            this.lblAjouterSecteur.Text = "Ajouter un secteur ";
            // 
            // tbxAjouterSecteur
            // 
            this.tbxAjouterSecteur.Location = new System.Drawing.Point(300, 83);
            this.tbxAjouterSecteur.Name = "tbxAjouterSecteur";
            this.tbxAjouterSecteur.Size = new System.Drawing.Size(135, 26);
            this.tbxAjouterSecteur.TabIndex = 1;
            // 
            // btnAjouterSecteur
            // 
            this.btnAjouterSecteur.Location = new System.Drawing.Point(323, 130);
            this.btnAjouterSecteur.Name = "btnAjouterSecteur";
            this.btnAjouterSecteur.Size = new System.Drawing.Size(75, 41);
            this.btnAjouterSecteur.TabIndex = 2;
            this.btnAjouterSecteur.Text = "Ajouter";
            this.btnAjouterSecteur.UseVisualStyleBackColor = true;
            this.btnAjouterSecteur.Click += new System.EventHandler(this.btnAjouterSecteur_Click);
            // 
            // FormSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouterSecteur);
            this.Controls.Add(this.tbxAjouterSecteur);
            this.Controls.Add(this.lblAjouterSecteur);
            this.Name = "FormSecteur";
            this.Text = "FormSecteur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAjouterSecteur;
        private System.Windows.Forms.TextBox tbxAjouterSecteur;
        private System.Windows.Forms.Button btnAjouterSecteur;
    }
}