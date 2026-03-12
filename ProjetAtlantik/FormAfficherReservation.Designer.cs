namespace ProjetAtlantik
{
    partial class FormAfficherReservation
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
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.cbxNomPrenom = new System.Windows.Forms.ComboBox();
            this.lvAfficherReservation = new System.Windows.Forms.ListView();
            this.gbxReservation = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(59, 30);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(77, 13);
            this.lblNomPrenom.TabIndex = 0;
            this.lblNomPrenom.Text = "Nom, Prénom :";
            // 
            // cbxNomPrenom
            // 
            this.cbxNomPrenom.FormattingEnabled = true;
            this.cbxNomPrenom.Location = new System.Drawing.Point(157, 30);
            this.cbxNomPrenom.Name = "cbxNomPrenom";
            this.cbxNomPrenom.Size = new System.Drawing.Size(121, 21);
            this.cbxNomPrenom.TabIndex = 1;
            this.cbxNomPrenom.SelectedIndexChanged += new System.EventHandler(this.cbxNomPrenom_SelectedIndexChanged);
            // 
            // lvAfficherReservation
            // 
            this.lvAfficherReservation.HideSelection = false;
            this.lvAfficherReservation.Location = new System.Drawing.Point(390, 30);
            this.lvAfficherReservation.Name = "lvAfficherReservation";
            this.lvAfficherReservation.Size = new System.Drawing.Size(356, 110);
            this.lvAfficherReservation.TabIndex = 2;
            this.lvAfficherReservation.UseCompatibleStateImageBehavior = false;
            this.lvAfficherReservation.SelectedIndexChanged += new System.EventHandler(this.lvAfficherReservation_SelectedIndexChanged);
            // 
            // gbxReservation
            // 
            this.gbxReservation.Location = new System.Drawing.Point(428, 146);
            this.gbxReservation.Name = "gbxReservation";
            this.gbxReservation.Size = new System.Drawing.Size(281, 247);
            this.gbxReservation.TabIndex = 3;
            this.gbxReservation.TabStop = false;
            this.gbxReservation.Text = "Reservation";
            this.gbxReservation.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FormAfficherReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxReservation);
            this.Controls.Add(this.lvAfficherReservation);
            this.Controls.Add(this.cbxNomPrenom);
            this.Controls.Add(this.lblNomPrenom);
            this.Name = "FormAfficherReservation";
            this.Text = "FormAfficherReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.ComboBox cbxNomPrenom;
        private System.Windows.Forms.ListView lvAfficherReservation;
        private System.Windows.Forms.GroupBox gbxReservation;
    }
}