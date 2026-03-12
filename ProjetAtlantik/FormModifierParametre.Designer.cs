namespace ProjetAtlantik
{
    partial class FormModifierParametre
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
            this.gbxPayBox = new System.Windows.Forms.GroupBox();
            this.lblEnProduction = new System.Windows.Forms.Label();
            this.cbxEnProduction = new System.Windows.Forms.CheckBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.tbxMelSite = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gbxPayBox
            // 
            this.gbxPayBox.Location = new System.Drawing.Point(215, 22);
            this.gbxPayBox.Name = "gbxPayBox";
            this.gbxPayBox.Size = new System.Drawing.Size(320, 246);
            this.gbxPayBox.TabIndex = 0;
            this.gbxPayBox.TabStop = false;
            this.gbxPayBox.Text = "Identifiants PayBox";
            // 
            // lblEnProduction
            // 
            this.lblEnProduction.AutoSize = true;
            this.lblEnProduction.Location = new System.Drawing.Point(439, 280);
            this.lblEnProduction.Name = "lblEnProduction";
            this.lblEnProduction.Size = new System.Drawing.Size(73, 13);
            this.lblEnProduction.TabIndex = 1;
            this.lblEnProduction.Text = "En production";
            // 
            // cbxEnProduction
            // 
            this.cbxEnProduction.AutoSize = true;
            this.cbxEnProduction.Location = new System.Drawing.Point(418, 280);
            this.cbxEnProduction.Name = "cbxEnProduction";
            this.cbxEnProduction.Size = new System.Drawing.Size(15, 14);
            this.cbxEnProduction.TabIndex = 2;
            this.cbxEnProduction.UseVisualStyleBackColor = true;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(338, 322);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(34, 13);
            this.lblSite.TabIndex = 3;
            this.lblSite.Text = "Site : ";
            // 
            // tbxMelSite
            // 
            this.tbxMelSite.Location = new System.Drawing.Point(412, 315);
            this.tbxMelSite.Name = "tbxMelSite";
            this.tbxMelSite.Size = new System.Drawing.Size(100, 20);
            this.tbxMelSite.TabIndex = 4;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(412, 363);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // FormModifierParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.tbxMelSite);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.cbxEnProduction);
            this.Controls.Add(this.lblEnProduction);
            this.Controls.Add(this.gbxPayBox);
            this.Name = "FormModifierParametre";
            this.Text = "FormMofifierParametre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPayBox;
        private System.Windows.Forms.Label lblEnProduction;
        private System.Windows.Forms.CheckBox cbxEnProduction;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.TextBox tbxMelSite;
        private System.Windows.Forms.Button btnModifier;
    }
}