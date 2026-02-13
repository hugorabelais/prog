namespace FenetreGraphique
{
    partial class FormAccueil
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
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnAjouterEditeur = new System.Windows.Forms.Button();
            this.btnSuppripmerTitre = new System.Windows.Forms.Button();
            this.btnAjouterLivre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(97, 75);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(132, 24);
            this.btnAfficher.TabIndex = 2;
            this.btnAfficher.Text = "afficher les editeur";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAjouterEditeur
            // 
            this.btnAjouterEditeur.Location = new System.Drawing.Point(97, 143);
            this.btnAjouterEditeur.Name = "btnAjouterEditeur";
            this.btnAjouterEditeur.Size = new System.Drawing.Size(131, 23);
            this.btnAjouterEditeur.TabIndex = 3;
            this.btnAjouterEditeur.Text = "ajouter editeur";
            this.btnAjouterEditeur.UseVisualStyleBackColor = true;
            this.btnAjouterEditeur.Click += new System.EventHandler(this.btnAjouterEditeur_Click);
            // 
            // btnSuppripmerTitre
            // 
            this.btnSuppripmerTitre.Location = new System.Drawing.Point(97, 202);
            this.btnSuppripmerTitre.Name = "btnSuppripmerTitre";
            this.btnSuppripmerTitre.Size = new System.Drawing.Size(131, 23);
            this.btnSuppripmerTitre.TabIndex = 4;
            this.btnSuppripmerTitre.Text = "supprimer titre";
            this.btnSuppripmerTitre.UseVisualStyleBackColor = true;
            this.btnSuppripmerTitre.Click += new System.EventHandler(this.btnSuppripmerTitre_Click);
            // 
            // btnAjouterLivre
            // 
            this.btnAjouterLivre.Location = new System.Drawing.Point(97, 265);
            this.btnAjouterLivre.Name = "btnAjouterLivre";
            this.btnAjouterLivre.Size = new System.Drawing.Size(131, 23);
            this.btnAjouterLivre.TabIndex = 5;
            this.btnAjouterLivre.Text = "ajouter livre";
            this.btnAjouterLivre.UseVisualStyleBackColor = true;
            this.btnAjouterLivre.Click += new System.EventHandler(this.btnAjouterLivre_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouterLivre);
            this.Controls.Add(this.btnSuppripmerTitre);
            this.Controls.Add(this.btnAjouterEditeur);
            this.Controls.Add(this.btnAfficher);
            this.Name = "FormAccueil";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Button btnAjouterEditeur;
        private System.Windows.Forms.Button btnSuppripmerTitre;
        private System.Windows.Forms.Button btnAjouterLivre;
    }
}

