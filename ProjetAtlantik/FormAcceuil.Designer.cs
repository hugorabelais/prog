namespace ProjetAtlantik
{
    partial class FormAcceuil
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
            this.mmAcceuil = new System.Windows.Forms.MenuStrip();
            this.miAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.miSecteur = new System.Windows.Forms.ToolStripTextBox();
            this.miAjouterPort = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterLiaison = new System.Windows.Forms.ToolStripMenuItem();
            this.milesTarifsPourUneLiaisonEtUnePériode = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAcceuil.SuspendLayout();
            this.SuspendLayout();
            // 
            // mmAcceuil
            // 
            this.mmAcceuil.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mmAcceuil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAjouter});
            this.mmAcceuil.Location = new System.Drawing.Point(0, 0);
            this.mmAcceuil.Name = "mmAcceuil";
            this.mmAcceuil.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mmAcceuil.Size = new System.Drawing.Size(533, 24);
            this.mmAcceuil.TabIndex = 0;
            this.mmAcceuil.Text = "menuStrip1";
            // 
            // miAjouter
            // 
            this.miAjouter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSecteur,
            this.miAjouterPort,
            this.miAjouterLiaison,
            this.milesTarifsPourUneLiaisonEtUnePériode});
            this.miAjouter.Name = "miAjouter";
            this.miAjouter.Size = new System.Drawing.Size(56, 22);
            this.miAjouter.Text = "ajouter";
            // 
            // miSecteur
            // 
            this.miSecteur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.miSecteur.Name = "miSecteur";
            this.miSecteur.Size = new System.Drawing.Size(100, 23);
            this.miSecteur.Text = "Un secteur";
            this.miSecteur.Click += new System.EventHandler(this.miSecteur_Click);
            // 
            // miAjouterPort
            // 
            this.miAjouterPort.Name = "miAjouterPort";
            this.miAjouterPort.Size = new System.Drawing.Size(287, 22);
            this.miAjouterPort.Text = "Un port ";
            this.miAjouterPort.Click += new System.EventHandler(this.miAjouterPort_Click);
            // 
            // miAjouterLiaison
            // 
            this.miAjouterLiaison.Name = "miAjouterLiaison";
            this.miAjouterLiaison.Size = new System.Drawing.Size(287, 22);
            this.miAjouterLiaison.Text = "Une liaison";
            this.miAjouterLiaison.Click += new System.EventHandler(this.uneLiaisonToolStripMenuItem_Click);
            // 
            // milesTarifsPourUneLiaisonEtUnePériode
            // 
            this.milesTarifsPourUneLiaisonEtUnePériode.Name = "milesTarifsPourUneLiaisonEtUnePériode";
            this.milesTarifsPourUneLiaisonEtUnePériode.Size = new System.Drawing.Size(287, 22);
            this.milesTarifsPourUneLiaisonEtUnePériode.Text = "Les tarifs pour une liaison et une période";
            this.milesTarifsPourUneLiaisonEtUnePériode.Click += new System.EventHandler(this.milesTarifsPourUneLiaisonEtUnePériode_Click);
            // 
            // FormAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.mmAcceuil);
            this.MainMenuStrip = this.mmAcceuil;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAcceuil";
            this.Text = "acceuil";
            this.mmAcceuil.ResumeLayout(false);
            this.mmAcceuil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mmAcceuil;
        private System.Windows.Forms.ToolStripMenuItem miAjouter;
        private System.Windows.Forms.ToolStripTextBox miSecteur;
        private System.Windows.Forms.ToolStripMenuItem miAjouterPort;
        private System.Windows.Forms.ToolStripMenuItem miAjouterLiaison;
        private System.Windows.Forms.ToolStripMenuItem milesTarifsPourUneLiaisonEtUnePériode;
    }
}

