namespace ProjetAtlantik
{
    partial class FormModifierBateau
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
            this.lblNomBateau = new System.Windows.Forms.Label();
            this.cbxNomBateau = new System.Windows.Forms.ComboBox();
            this.gbxCapacite = new System.Windows.Forms.GroupBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Location = new System.Drawing.Point(66, 60);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(72, 13);
            this.lblNomBateau.TabIndex = 0;
            this.lblNomBateau.Text = "Nom Bateau :";
            // 
            // cbxNomBateau
            // 
            this.cbxNomBateau.FormattingEnabled = true;
            this.cbxNomBateau.Location = new System.Drawing.Point(161, 57);
            this.cbxNomBateau.Name = "cbxNomBateau";
            this.cbxNomBateau.Size = new System.Drawing.Size(121, 21);
            this.cbxNomBateau.TabIndex = 1;
            this.cbxNomBateau.SelectedIndexChanged += new System.EventHandler(this.cbxNomBateau_SelectedIndexChanged);
            // 
            // gbxCapacite
            // 
            this.gbxCapacite.Location = new System.Drawing.Point(356, 56);
            this.gbxCapacite.Name = "gbxCapacite";
            this.gbxCapacite.Size = new System.Drawing.Size(376, 276);
            this.gbxCapacite.TabIndex = 2;
            this.gbxCapacite.TabStop = false;
            this.gbxCapacite.Text = "Capacités Maximales";
            this.gbxCapacite.Enter += new System.EventHandler(this.gbxCapacite_Enter);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(151, 309);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(131, 23);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // FormModifierBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.gbxCapacite);
            this.Controls.Add(this.cbxNomBateau);
            this.Controls.Add(this.lblNomBateau);
            this.Name = "FormModifierBateau";
            this.Text = "FormModifierBateau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.ComboBox cbxNomBateau;
        private System.Windows.Forms.GroupBox gbxCapacite;
        private System.Windows.Forms.Button btnModifier;
    }
}