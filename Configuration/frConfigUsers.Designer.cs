namespace Configuration
{
    partial class frConfigUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frConfigUsers));
            this.txtBox_username = new System.Windows.Forms.TextBox();
            this.dgv_listUsers = new System.Windows.Forms.DataGridView();
            this.pctBox_PictureType = new System.Windows.Forms.PictureBox();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_pswd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_pswdConfirm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PictureType)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_username
            // 
            this.txtBox_username.Location = new System.Drawing.Point(84, 22);
            this.txtBox_username.Name = "txtBox_username";
            this.txtBox_username.Size = new System.Drawing.Size(156, 20);
            this.txtBox_username.TabIndex = 45;
            // 
            // dgv_listUsers
            // 
            this.dgv_listUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listUsers.Location = new System.Drawing.Point(271, 12);
            this.dgv_listUsers.Name = "dgv_listUsers";
            this.dgv_listUsers.Size = new System.Drawing.Size(397, 181);
            this.dgv_listUsers.TabIndex = 44;
            // 
            // pctBox_PictureType
            // 
            this.pctBox_PictureType.Image = ((System.Drawing.Image)(resources.GetObject("pctBox_PictureType.Image")));
            this.pctBox_PictureType.Location = new System.Drawing.Point(12, 143);
            this.pctBox_PictureType.Name = "pctBox_PictureType";
            this.pctBox_PictureType.Size = new System.Drawing.Size(51, 50);
            this.pctBox_PictureType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_PictureType.TabIndex = 43;
            this.pctBox_PictureType.TabStop = false;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(165, 93);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.btn_enregistrer.TabIndex = 42;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(84, 93);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 41;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Mot de passe :";
            // 
            // txtBox_pswd
            // 
            this.txtBox_pswd.Location = new System.Drawing.Point(84, 44);
            this.txtBox_pswd.Name = "txtBox_pswd";
            this.txtBox_pswd.Size = new System.Drawing.Size(156, 20);
            this.txtBox_pswd.TabIndex = 37;
            this.txtBox_pswd.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBox_username);
            this.groupBox1.Controls.Add(this.txtBox_pswdConfirm);
            this.groupBox1.Controls.Add(this.txtBox_pswd);
            this.groupBox1.Controls.Add(this.btn_supprimer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_enregistrer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 125);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter/Modifier un utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Confirmation :";
            // 
            // txtBox_pswdConfirm
            // 
            this.txtBox_pswdConfirm.Location = new System.Drawing.Point(84, 67);
            this.txtBox_pswdConfirm.Name = "txtBox_pswdConfirm";
            this.txtBox_pswdConfirm.Size = new System.Drawing.Size(156, 20);
            this.txtBox_pswdConfirm.TabIndex = 37;
            this.txtBox_pswdConfirm.UseSystemPasswordChar = true;
            // 
            // frConfigUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 210);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_listUsers);
            this.Controls.Add(this.pctBox_PictureType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frConfigUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration liste utilisateurs";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PictureType)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox_username;
        private System.Windows.Forms.DataGridView dgv_listUsers;
        private System.Windows.Forms.PictureBox pctBox_PictureType;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_pswd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_pswdConfirm;
    }
}