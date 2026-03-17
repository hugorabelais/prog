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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcceuil));
            this.mmAcceuil = new System.Windows.Forms.MenuStrip();
            this.miAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.miSecteur = new System.Windows.Forms.ToolStripTextBox();
            this.miAjouterPort = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterLiaison = new System.Windows.Forms.ToolStripMenuItem();
            this.milesTarifsPourUneLiaisonEtUnePériode = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterUnBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterUneTraversée = new System.Windows.Forms.ToolStripMenuItem();
            this.mimodifier = new System.Windows.Forms.ToolStripMenuItem();
            this.miModifierBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.miModifierParametre = new System.Windows.Forms.ToolStripMenuItem();
            this.miAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.miAfficherLiaison = new System.Windows.Forms.ToolStripMenuItem();
            this.miAfficherReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.miAPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAcceuil.SuspendLayout();
            this.SuspendLayout();
            // 
            // mmAcceuil
            // 
            this.mmAcceuil.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mmAcceuil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAjouter,
            this.mimodifier,
            this.miAfficher,
            this.miAPropos});
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
            this.milesTarifsPourUneLiaisonEtUnePériode,
            this.miAjouterUnBateau,
            this.miAjouterUneTraversée});
            this.miAjouter.Name = "miAjouter";
            this.miAjouter.Size = new System.Drawing.Size(58, 22);
            this.miAjouter.Text = "Ajouter";
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
            // miAjouterUnBateau
            // 
            this.miAjouterUnBateau.Name = "miAjouterUnBateau";
            this.miAjouterUnBateau.Size = new System.Drawing.Size(287, 22);
            this.miAjouterUnBateau.Text = "Un bateau";
            this.miAjouterUnBateau.Click += new System.EventHandler(this.miAjouterUnBateau_Click);
            // 
            // miAjouterUneTraversée
            // 
            this.miAjouterUneTraversée.Name = "miAjouterUneTraversée";
            this.miAjouterUneTraversée.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.miAjouterUneTraversée.Size = new System.Drawing.Size(287, 22);
            this.miAjouterUneTraversée.Text = "Une traversée";
            this.miAjouterUneTraversée.Click += new System.EventHandler(this.miAjouterUneTraversée_Click);
            // 
            // mimodifier
            // 
            this.mimodifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miModifierBateau,
            this.miModifierParametre});
            this.mimodifier.Name = "mimodifier";
            this.mimodifier.Size = new System.Drawing.Size(64, 22);
            this.mimodifier.Text = "Modifier";
            // 
            // miModifierBateau
            // 
            this.miModifierBateau.Name = "miModifierBateau";
            this.miModifierBateau.Size = new System.Drawing.Size(191, 22);
            this.miModifierBateau.Text = "Un bateau";
            this.miModifierBateau.Click += new System.EventHandler(this.miModifierBateau_Click);
            // 
            // miModifierParametre
            // 
            this.miModifierParametre.Name = "miModifierParametre";
            this.miModifierParametre.Size = new System.Drawing.Size(191, 22);
            this.miModifierParametre.Text = "Les paramètres du site";
            this.miModifierParametre.Click += new System.EventHandler(this.miModifierParametre_Click);
            // 
            // miAfficher
            // 
            this.miAfficher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAfficherLiaison,
            this.miAfficherReservation});
            this.miAfficher.Name = "miAfficher";
            this.miAfficher.Size = new System.Drawing.Size(61, 22);
            this.miAfficher.Text = "Afficher";
            // 
            // miAfficherLiaison
            // 
            this.miAfficherLiaison.Name = "miAfficherLiaison";
            this.miAfficherLiaison.Size = new System.Drawing.Size(529, 22);
            this.miAfficherLiaison.Text = "Les traversées pour une liaison et une date données avec places restantes par cat" +
    "égorie";
            this.miAfficherLiaison.Click += new System.EventHandler(this.miAfficherLiaison_Click);
            // 
            // miAfficherReservation
            // 
            this.miAfficherReservation.Name = "miAfficherReservation";
            this.miAfficherReservation.Size = new System.Drawing.Size(529, 22);
            this.miAfficherReservation.Text = "Les détails d\'une réservation pour un client";
            this.miAfficherReservation.Click += new System.EventHandler(this.miAfficherReservation_Click);
            // 
            // miAPropos
            // 
            this.miAPropos.Name = "miAPropos";
            this.miAPropos.Size = new System.Drawing.Size(67, 22);
            this.miAPropos.Text = "A propos";
            // 
            // FormAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.mmAcceuil);
            this.MainMenuStrip = this.mmAcceuil;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ToolStripMenuItem miAjouterUnBateau;
        private System.Windows.Forms.ToolStripMenuItem mimodifier;
        private System.Windows.Forms.ToolStripMenuItem miModifierBateau;
        private System.Windows.Forms.ToolStripMenuItem miAjouterUneTraversée;
        private System.Windows.Forms.ToolStripMenuItem miAfficher;
        private System.Windows.Forms.ToolStripMenuItem miAfficherLiaison;
        private System.Windows.Forms.ToolStripMenuItem miAfficherReservation;
        private System.Windows.Forms.ToolStripMenuItem miModifierParametre;
        private System.Windows.Forms.ToolStripMenuItem miAPropos;
    }
}

