namespace Configuration
{
    partial class frConfigSysteme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frConfigSysteme));
            this.pctBox_PictureType = new System.Windows.Forms.PictureBox();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_listSysteme = new System.Windows.Forms.DataGridView();
            this.txtBox_idSysteme = new System.Windows.Forms.TextBox();
            this.txtBox_description = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PictureType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listSysteme)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBox_PictureType
            // 
            this.pctBox_PictureType.Image = ((System.Drawing.Image)(resources.GetObject("pctBox_PictureType.Image")));
            this.pctBox_PictureType.Location = new System.Drawing.Point(12, 111);
            this.pctBox_PictureType.Name = "pctBox_PictureType";
            this.pctBox_PictureType.Size = new System.Drawing.Size(51, 50);
            this.pctBox_PictureType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_PictureType.TabIndex = 23;
            this.pctBox_PictureType.TabStop = false;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(171, 138);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.btn_enregistrer.TabIndex = 22;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(90, 138);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 21;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nom :";
            // 
            // txtBox_nom
            // 
            this.txtBox_nom.Location = new System.Drawing.Point(90, 28);
            this.txtBox_nom.Name = "txtBox_nom";
            this.txtBox_nom.Size = new System.Drawing.Size(156, 20);
            this.txtBox_nom.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID système :";
            // 
            // dgv_listSysteme
            // 
            this.dgv_listSysteme.AllowUserToAddRows = false;
            this.dgv_listSysteme.AllowUserToDeleteRows = false;
            this.dgv_listSysteme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_listSysteme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listSysteme.Location = new System.Drawing.Point(252, 6);
            this.dgv_listSysteme.Name = "dgv_listSysteme";
            this.dgv_listSysteme.ReadOnly = true;
            this.dgv_listSysteme.RowHeadersVisible = false;
            this.dgv_listSysteme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listSysteme.Size = new System.Drawing.Size(397, 155);
            this.dgv_listSysteme.TabIndex = 24;
            // 
            // txtBox_idSysteme
            // 
            this.txtBox_idSysteme.Location = new System.Drawing.Point(90, 6);
            this.txtBox_idSysteme.Name = "txtBox_idSysteme";
            this.txtBox_idSysteme.Size = new System.Drawing.Size(77, 20);
            this.txtBox_idSysteme.TabIndex = 25;
            // 
            // txtBox_description
            // 
            this.txtBox_description.Location = new System.Drawing.Point(90, 51);
            this.txtBox_description.Multiline = true;
            this.txtBox_description.Name = "txtBox_description";
            this.txtBox_description.Size = new System.Drawing.Size(156, 81);
            this.txtBox_description.TabIndex = 26;
            // 
            // frConfigSysteme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 176);
            this.Controls.Add(this.txtBox_description);
            this.Controls.Add(this.txtBox_idSysteme);
            this.Controls.Add(this.dgv_listSysteme);
            this.Controls.Add(this.pctBox_PictureType);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frConfigSysteme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration liste Systèmes";
            this.Load += new System.EventHandler(this.frConfigSysteme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PictureType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listSysteme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBox_PictureType;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_listSysteme;
        private System.Windows.Forms.TextBox txtBox_idSysteme;
        private System.Windows.Forms.TextBox txtBox_description;
    }
}