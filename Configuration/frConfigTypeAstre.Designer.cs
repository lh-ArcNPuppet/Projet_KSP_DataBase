namespace Configuration
{
    partial class frConfigTypeAstre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frConfigTypeAstre));
            this.txtBox_idTypeAstre = new System.Windows.Forms.TextBox();
            this.dgv_listTypeAstre = new System.Windows.Forms.DataGridView();
            this.pctBox_PictureType = new System.Windows.Forms.PictureBox();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_libelle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listTypeAstre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PictureType)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_idTypeAstre
            // 
            this.txtBox_idTypeAstre.Location = new System.Drawing.Point(92, 12);
            this.txtBox_idTypeAstre.Name = "txtBox_idTypeAstre";
            this.txtBox_idTypeAstre.Size = new System.Drawing.Size(50, 20);
            this.txtBox_idTypeAstre.TabIndex = 45;
            // 
            // dgv_listTypeAstre
            // 
            this.dgv_listTypeAstre.AllowUserToAddRows = false;
            this.dgv_listTypeAstre.AllowUserToDeleteRows = false;
            this.dgv_listTypeAstre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listTypeAstre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listTypeAstre.Location = new System.Drawing.Point(254, 12);
            this.dgv_listTypeAstre.Name = "dgv_listTypeAstre";
            this.dgv_listTypeAstre.ReadOnly = true;
            this.dgv_listTypeAstre.RowHeadersVisible = false;
            this.dgv_listTypeAstre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listTypeAstre.Size = new System.Drawing.Size(252, 127);
            this.dgv_listTypeAstre.TabIndex = 44;
            // 
            // pctBox_PictureType
            // 
            this.pctBox_PictureType.Image = ((System.Drawing.Image)(resources.GetObject("pctBox_PictureType.Image")));
            this.pctBox_PictureType.Location = new System.Drawing.Point(17, 89);
            this.pctBox_PictureType.Name = "pctBox_PictureType";
            this.pctBox_PictureType.Size = new System.Drawing.Size(51, 50);
            this.pctBox_PictureType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_PictureType.TabIndex = 43;
            this.pctBox_PictureType.TabStop = false;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(173, 60);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.btn_enregistrer.TabIndex = 42;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(92, 60);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 41;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "ID Type astre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Libellé :";
            // 
            // txtBox_libelle
            // 
            this.txtBox_libelle.Location = new System.Drawing.Point(92, 34);
            this.txtBox_libelle.Name = "txtBox_libelle";
            this.txtBox_libelle.Size = new System.Drawing.Size(156, 20);
            this.txtBox_libelle.TabIndex = 37;
            // 
            // frConfigTypeAstre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 154);
            this.Controls.Add(this.txtBox_idTypeAstre);
            this.Controls.Add(this.dgv_listTypeAstre);
            this.Controls.Add(this.pctBox_PictureType);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_libelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frConfigTypeAstre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration liste Type astre";
            this.Load += new System.EventHandler(this.frConfigTypeAstre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listTypeAstre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PictureType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox_idTypeAstre;
        private System.Windows.Forms.DataGridView dgv_listTypeAstre;
        private System.Windows.Forms.PictureBox pctBox_PictureType;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_libelle;
    }
}