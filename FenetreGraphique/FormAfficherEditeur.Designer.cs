namespace FenetreGraphique
{
    partial class FormAfficherEditeur
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
            this.components = new System.ComponentModel.Container();
            this.tbxLettre = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbsaisirlettre = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lvafficherediteur = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tbxLettre
            // 
            this.tbxLettre.Location = new System.Drawing.Point(130, 167);
            this.tbxLettre.Name = "tbxLettre";
            this.tbxLettre.Size = new System.Drawing.Size(162, 20);
            this.tbxLettre.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lbsaisirlettre
            // 
            this.lbsaisirlettre.AutoSize = true;
            this.lbsaisirlettre.Location = new System.Drawing.Point(162, 123);
            this.lbsaisirlettre.Name = "lbsaisirlettre";
            this.lbsaisirlettre.Size = new System.Drawing.Size(110, 13);
            this.lbsaisirlettre.TabIndex = 1;
            this.lbsaisirlettre.Text = "saisir la premiere lettre";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(165, 219);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lvafficherediteur
            // 
            this.lvafficherediteur.HideSelection = false;
            this.lvafficherediteur.Location = new System.Drawing.Point(498, 25);
            this.lvafficherediteur.Name = "lvafficherediteur";
            this.lvafficherediteur.Size = new System.Drawing.Size(176, 308);
            this.lvafficherediteur.TabIndex = 2;
            this.lvafficherediteur.UseCompatibleStateImageBehavior = false;
            this.lvafficherediteur.SelectedIndexChanged += new System.EventHandler(this.lvafficherediteur_SelectedIndexChanged);
            // 
            // FormAfficherEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lvafficherediteur);
            this.Controls.Add(this.lbsaisirlettre);
            this.Controls.Add(this.tbxLettre);
            this.Name = "FormAfficherEditeur";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLettre;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lbsaisirlettre;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListView lvafficherediteur;
    }
}