namespace Configuration
{
    partial class frConfigListePayload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frConfigListePayload));
            this.txtBox_description = new System.Windows.Forms.TextBox();
            this.txtBox_codePayload = new System.Windows.Forms.TextBox();
            this.dgv_listTypePayload = new System.Windows.Forms.DataGridView();
            this.pctBox_PictureType = new System.Windows.Forms.PictureBox();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_nom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listTypePayload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PictureType)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_description
            // 
            this.txtBox_description.Location = new System.Drawing.Point(91, 57);
            this.txtBox_description.Multiline = true;
            this.txtBox_description.Name = "txtBox_description";
            this.txtBox_description.Size = new System.Drawing.Size(156, 81);
            this.txtBox_description.TabIndex = 36;
            // 
            // txtBox_codePayload
            // 
            this.txtBox_codePayload.Location = new System.Drawing.Point(91, 12);
            this.txtBox_codePayload.Name = "txtBox_codePayload";
            this.txtBox_codePayload.Size = new System.Drawing.Size(77, 20);
            this.txtBox_codePayload.TabIndex = 35;
            // 
            // dgv_listTypePayload
            // 
            this.dgv_listTypePayload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listTypePayload.Location = new System.Drawing.Point(253, 12);
            this.dgv_listTypePayload.Name = "dgv_listTypePayload";
            this.dgv_listTypePayload.Size = new System.Drawing.Size(397, 155);
            this.dgv_listTypePayload.TabIndex = 34;
            // 
            // pctBox_PictureType
            // 
            this.pctBox_PictureType.Image = ((System.Drawing.Image)(resources.GetObject("pctBox_PictureType.Image")));
            this.pctBox_PictureType.Location = new System.Drawing.Point(16, 117);
            this.pctBox_PictureType.Name = "pctBox_PictureType";
            this.pctBox_PictureType.Size = new System.Drawing.Size(51, 50);
            this.pctBox_PictureType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_PictureType.TabIndex = 33;
            this.pctBox_PictureType.TabStop = false;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(172, 144);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.btn_enregistrer.TabIndex = 32;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(91, 144);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 31;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Code payload :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nom :";
            // 
            // txtBox_nom
            // 
            this.txtBox_nom.Location = new System.Drawing.Point(91, 34);
            this.txtBox_nom.Name = "txtBox_nom";
            this.txtBox_nom.Size = new System.Drawing.Size(156, 20);
            this.txtBox_nom.TabIndex = 27;
            // 
            // frConfigListePayload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 182);
            this.Controls.Add(this.txtBox_description);
            this.Controls.Add(this.txtBox_codePayload);
            this.Controls.Add(this.dgv_listTypePayload);
            this.Controls.Add(this.pctBox_PictureType);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frConfigListePayload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration liste Type payload";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listTypePayload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PictureType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_description;
        private System.Windows.Forms.TextBox txtBox_codePayload;
        private System.Windows.Forms.DataGridView dgv_listTypePayload;
        private System.Windows.Forms.PictureBox pctBox_PictureType;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_nom;
    }
}