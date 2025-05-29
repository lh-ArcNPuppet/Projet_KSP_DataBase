namespace Configuration
{
    partial class frConfigStatusMission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frConfigStatusMission));
            this.txtBox_idStatusMission = new System.Windows.Forms.TextBox();
            this.dgv_listStatusMission = new System.Windows.Forms.DataGridView();
            this.pctBox_PictureType = new System.Windows.Forms.PictureBox();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_libelle = new System.Windows.Forms.TextBox();
            this.btn_editer = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listStatusMission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PictureType)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_idStatusMission
            // 
            this.txtBox_idStatusMission.Location = new System.Drawing.Point(116, 12);
            this.txtBox_idStatusMission.Name = "txtBox_idStatusMission";
            this.txtBox_idStatusMission.Size = new System.Drawing.Size(49, 20);
            this.txtBox_idStatusMission.TabIndex = 53;
            // 
            // dgv_listStatusMission
            // 
            this.dgv_listStatusMission.AllowUserToAddRows = false;
            this.dgv_listStatusMission.AllowUserToDeleteRows = false;
            this.dgv_listStatusMission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listStatusMission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listStatusMission.Location = new System.Drawing.Point(278, 12);
            this.dgv_listStatusMission.Name = "dgv_listStatusMission";
            this.dgv_listStatusMission.ReadOnly = true;
            this.dgv_listStatusMission.RowHeadersVisible = false;
            this.dgv_listStatusMission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listStatusMission.Size = new System.Drawing.Size(281, 128);
            this.dgv_listStatusMission.TabIndex = 52;
            // 
            // pctBox_PictureType
            // 
            this.pctBox_PictureType.Image = ((System.Drawing.Image)(resources.GetObject("pctBox_PictureType.Image")));
            this.pctBox_PictureType.Location = new System.Drawing.Point(12, 85);
            this.pctBox_PictureType.Name = "pctBox_PictureType";
            this.pctBox_PictureType.Size = new System.Drawing.Size(51, 50);
            this.pctBox_PictureType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_PictureType.TabIndex = 51;
            this.pctBox_PictureType.TabStop = false;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(197, 60);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.btn_enregistrer.TabIndex = 50;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(116, 60);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 49;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "ID Status Mission :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Libellé :";
            // 
            // txtBox_libelle
            // 
            this.txtBox_libelle.Location = new System.Drawing.Point(116, 34);
            this.txtBox_libelle.Name = "txtBox_libelle";
            this.txtBox_libelle.Size = new System.Drawing.Size(156, 20);
            this.txtBox_libelle.TabIndex = 46;
            // 
            // btn_editer
            // 
            this.btn_editer.Location = new System.Drawing.Point(116, 85);
            this.btn_editer.Name = "btn_editer";
            this.btn_editer.Size = new System.Drawing.Size(75, 23);
            this.btn_editer.TabIndex = 56;
            this.btn_editer.Text = "Editer";
            this.btn_editer.UseVisualStyleBackColor = true;
            this.btn_editer.Click += new System.EventHandler(this.btn_editer_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(197, 85);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 55;
            this.btn_update.Text = "Modifier";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(35, 60);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 54;
            this.btn_clear.Text = "Clear Form";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // frConfigStatusMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 152);
            this.Controls.Add(this.btn_editer);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txtBox_idStatusMission);
            this.Controls.Add(this.dgv_listStatusMission);
            this.Controls.Add(this.pctBox_PictureType);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_libelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frConfigStatusMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration liste Status mission";
            this.Load += new System.EventHandler(this.frConfigStatusMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listStatusMission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PictureType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_idStatusMission;
        private System.Windows.Forms.DataGridView dgv_listStatusMission;
        private System.Windows.Forms.PictureBox pctBox_PictureType;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_libelle;
        private System.Windows.Forms.Button btn_editer;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
    }
}