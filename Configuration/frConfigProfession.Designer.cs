namespace Configuration
{
    partial class frConfigProfession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frConfigProfession));
            this.txtBox_idProfession = new System.Windows.Forms.TextBox();
            this.dgv_listProfession = new System.Windows.Forms.DataGridView();
            this.pctBox_PictureType = new System.Windows.Forms.PictureBox();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_libelle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listProfession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PictureType)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_idProfession
            // 
            this.txtBox_idProfession.Location = new System.Drawing.Point(93, 12);
            this.txtBox_idProfession.Name = "txtBox_idProfession";
            this.txtBox_idProfession.Size = new System.Drawing.Size(49, 20);
            this.txtBox_idProfession.TabIndex = 45;
            // 
            // dgv_listProfession
            // 
            this.dgv_listProfession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listProfession.Location = new System.Drawing.Point(255, 12);
            this.dgv_listProfession.Name = "dgv_listProfession";
            this.dgv_listProfession.Size = new System.Drawing.Size(281, 128);
            this.dgv_listProfession.TabIndex = 44;
            // 
            // pctBox_PictureType
            // 
            this.pctBox_PictureType.Image = ((System.Drawing.Image)(resources.GetObject("pctBox_PictureType.Image")));
            this.pctBox_PictureType.Location = new System.Drawing.Point(18, 90);
            this.pctBox_PictureType.Name = "pctBox_PictureType";
            this.pctBox_PictureType.Size = new System.Drawing.Size(51, 50);
            this.pctBox_PictureType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_PictureType.TabIndex = 43;
            this.pctBox_PictureType.TabStop = false;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(174, 60);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.btn_enregistrer.TabIndex = 42;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(93, 60);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 41;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "ID Profession :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Libellé :";
            // 
            // txtBox_libelle
            // 
            this.txtBox_libelle.Location = new System.Drawing.Point(93, 34);
            this.txtBox_libelle.Name = "txtBox_libelle";
            this.txtBox_libelle.Size = new System.Drawing.Size(156, 20);
            this.txtBox_libelle.TabIndex = 37;
            // 
            // frConfigProfession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 154);
            this.Controls.Add(this.txtBox_idProfession);
            this.Controls.Add(this.dgv_listProfession);
            this.Controls.Add(this.pctBox_PictureType);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_libelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frConfigProfession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration liste Professions";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listProfession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PictureType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox_idProfession;
        private System.Windows.Forms.DataGridView dgv_listProfession;
        private System.Windows.Forms.PictureBox pctBox_PictureType;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_libelle;
    }
}