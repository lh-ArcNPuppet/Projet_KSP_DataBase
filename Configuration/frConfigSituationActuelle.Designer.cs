namespace Configuration
{
    partial class frConfigSituationActuelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frConfigSituationActuelle));
            this.txtBox_idSituationActuelle = new System.Windows.Forms.TextBox();
            this.dgv_listSituationActuelle = new System.Windows.Forms.DataGridView();
            this.pctBox_PictureType = new System.Windows.Forms.PictureBox();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_libelle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listSituationActuelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PictureType)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_idSituationActuelle
            // 
            this.txtBox_idSituationActuelle.Location = new System.Drawing.Point(115, 12);
            this.txtBox_idSituationActuelle.Name = "txtBox_idSituationActuelle";
            this.txtBox_idSituationActuelle.Size = new System.Drawing.Size(49, 20);
            this.txtBox_idSituationActuelle.TabIndex = 61;
            // 
            // dgv_listSituationActuelle
            // 
            this.dgv_listSituationActuelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listSituationActuelle.Location = new System.Drawing.Point(277, 12);
            this.dgv_listSituationActuelle.Name = "dgv_listSituationActuelle";
            this.dgv_listSituationActuelle.Size = new System.Drawing.Size(281, 128);
            this.dgv_listSituationActuelle.TabIndex = 60;
            // 
            // pctBox_PictureType
            // 
            this.pctBox_PictureType.Image = ((System.Drawing.Image)(resources.GetObject("pctBox_PictureType.Image")));
            this.pctBox_PictureType.Location = new System.Drawing.Point(17, 90);
            this.pctBox_PictureType.Name = "pctBox_PictureType";
            this.pctBox_PictureType.Size = new System.Drawing.Size(51, 50);
            this.pctBox_PictureType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_PictureType.TabIndex = 59;
            this.pctBox_PictureType.TabStop = false;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(196, 60);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.btn_enregistrer.TabIndex = 58;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(115, 60);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 57;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "ID Status Mission :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Libellé :";
            // 
            // txtBox_libelle
            // 
            this.txtBox_libelle.Location = new System.Drawing.Point(115, 34);
            this.txtBox_libelle.Name = "txtBox_libelle";
            this.txtBox_libelle.Size = new System.Drawing.Size(156, 20);
            this.txtBox_libelle.TabIndex = 54;
            // 
            // frConfigSituationActuelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 154);
            this.Controls.Add(this.txtBox_idSituationActuelle);
            this.Controls.Add(this.dgv_listSituationActuelle);
            this.Controls.Add(this.pctBox_PictureType);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_libelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frConfigSituationActuelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration liste Situation actuelle";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listSituationActuelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PictureType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_idSituationActuelle;
        private System.Windows.Forms.DataGridView dgv_listSituationActuelle;
        private System.Windows.Forms.PictureBox pctBox_PictureType;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_libelle;
    }
}