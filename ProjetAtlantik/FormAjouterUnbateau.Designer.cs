namespace ProjetAtlantik
{
    partial class FormAjouterUnbateau
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
            this.tbxNomBateau = new System.Windows.Forms.TextBox();
            this.gbxCapaciteMax = new System.Windows.Forms.GroupBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Location = new System.Drawing.Point(69, 73);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(74, 13);
            this.lblNomBateau.TabIndex = 0;
            this.lblNomBateau.Text = "Nom bateau : ";
            // 
            // tbxNomBateau
            // 
            this.tbxNomBateau.Location = new System.Drawing.Point(149, 73);
            this.tbxNomBateau.Name = "tbxNomBateau";
            this.tbxNomBateau.Size = new System.Drawing.Size(100, 20);
            this.tbxNomBateau.TabIndex = 1;
            // 
            // gbxCapaciteMax
            // 
            this.gbxCapaciteMax.Location = new System.Drawing.Point(347, 45);
            this.gbxCapaciteMax.Name = "gbxCapaciteMax";
            this.gbxCapaciteMax.Size = new System.Drawing.Size(313, 326);
            this.gbxCapaciteMax.TabIndex = 2;
            this.gbxCapaciteMax.TabStop = false;
            this.gbxCapaciteMax.Text = "Capacités Maximales";
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(149, 324);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(75, 23);
            this.btnajouter.TabIndex = 3;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // FormAjouterUnbateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.gbxCapaciteMax);
            this.Controls.Add(this.tbxNomBateau);
            this.Controls.Add(this.lblNomBateau);
            this.Name = "FormAjouterUnbateau";
            this.Text = "FormAjouterUnbateau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.TextBox tbxNomBateau;
        private System.Windows.Forms.GroupBox gbxCapaciteMax;
        private System.Windows.Forms.Button btnajouter;
    }
}