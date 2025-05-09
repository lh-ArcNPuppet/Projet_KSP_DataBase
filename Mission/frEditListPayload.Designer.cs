namespace Mission
{
    partial class frEditListPayload
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
            this.cbo_payload = new System.Windows.Forms.ComboBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_retirer = new System.Windows.Forms.Button();
            this.lstBox_listPayload = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbo_payload
            // 
            this.cbo_payload.FormattingEnabled = true;
            this.cbo_payload.Location = new System.Drawing.Point(12, 43);
            this.cbo_payload.Name = "cbo_payload";
            this.cbo_payload.Size = new System.Drawing.Size(167, 21);
            this.cbo_payload.TabIndex = 0;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(149, 70);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(30, 23);
            this.btn_ajouter.TabIndex = 1;
            this.btn_ajouter.Text = ">>";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            // 
            // btn_retirer
            // 
            this.btn_retirer.Location = new System.Drawing.Point(149, 97);
            this.btn_retirer.Name = "btn_retirer";
            this.btn_retirer.Size = new System.Drawing.Size(30, 23);
            this.btn_retirer.TabIndex = 1;
            this.btn_retirer.Text = "<<";
            this.btn_retirer.UseVisualStyleBackColor = true;
            // 
            // lstBox_listPayload
            // 
            this.lstBox_listPayload.FormattingEnabled = true;
            this.lstBox_listPayload.Location = new System.Drawing.Point(185, 12);
            this.lstBox_listPayload.Name = "lstBox_listPayload";
            this.lstBox_listPayload.Size = new System.Drawing.Size(153, 108);
            this.lstBox_listPayload.TabIndex = 2;
            // 
            // frEditListPayload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 132);
            this.Controls.Add(this.lstBox_listPayload);
            this.Controls.Add(this.btn_retirer);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.cbo_payload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frEditListPayload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editer la liste payload";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_payload;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_retirer;
        private System.Windows.Forms.ListBox lstBox_listPayload;
    }
}