namespace Mission
{
    partial class frEditerListeKerbonaute
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
            this.lstBox_listKerbonaute = new System.Windows.Forms.ListBox();
            this.btn_retirer = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.cbo_kerbonaute = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstBox_listKerbonaute
            // 
            this.lstBox_listKerbonaute.FormattingEnabled = true;
            this.lstBox_listKerbonaute.Location = new System.Drawing.Point(186, 12);
            this.lstBox_listKerbonaute.Name = "lstBox_listKerbonaute";
            this.lstBox_listKerbonaute.Size = new System.Drawing.Size(153, 108);
            this.lstBox_listKerbonaute.TabIndex = 6;
            // 
            // btn_retirer
            // 
            this.btn_retirer.Location = new System.Drawing.Point(150, 97);
            this.btn_retirer.Name = "btn_retirer";
            this.btn_retirer.Size = new System.Drawing.Size(30, 23);
            this.btn_retirer.TabIndex = 4;
            this.btn_retirer.Text = "<<";
            this.btn_retirer.UseVisualStyleBackColor = true;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(150, 70);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(30, 23);
            this.btn_ajouter.TabIndex = 5;
            this.btn_ajouter.Text = ">>";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            // 
            // cbo_kerbonaute
            // 
            this.cbo_kerbonaute.FormattingEnabled = true;
            this.cbo_kerbonaute.Location = new System.Drawing.Point(13, 43);
            this.cbo_kerbonaute.Name = "cbo_kerbonaute";
            this.cbo_kerbonaute.Size = new System.Drawing.Size(167, 21);
            this.cbo_kerbonaute.TabIndex = 3;
            // 
            // frEditerListeKerbonaute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 137);
            this.Controls.Add(this.lstBox_listKerbonaute);
            this.Controls.Add(this.btn_retirer);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.cbo_kerbonaute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frEditerListeKerbonaute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editer la liste Kerbonaute";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox_listKerbonaute;
        private System.Windows.Forms.Button btn_retirer;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.ComboBox cbo_kerbonaute;
    }
}