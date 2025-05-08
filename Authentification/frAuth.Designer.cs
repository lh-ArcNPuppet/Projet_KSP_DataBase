namespace Authentification
{
    partial class frAuth
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_username = new System.Windows.Forms.TextBox();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.chk_showPassword = new System.Windows.Forms.CheckBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilisateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mot de passe :";
            // 
            // txtBox_username
            // 
            this.txtBox_username.Location = new System.Drawing.Point(95, 110);
            this.txtBox_username.Name = "txtBox_username";
            this.txtBox_username.Size = new System.Drawing.Size(195, 20);
            this.txtBox_username.TabIndex = 1;
            // 
            // txtBox_password
            // 
            this.txtBox_password.Location = new System.Drawing.Point(95, 136);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(195, 20);
            this.txtBox_password.TabIndex = 2;
            this.txtBox_password.UseSystemPasswordChar = true;
            // 
            // chk_showPassword
            // 
            this.chk_showPassword.AutoSize = true;
            this.chk_showPassword.Location = new System.Drawing.Point(95, 158);
            this.chk_showPassword.Name = "chk_showPassword";
            this.chk_showPassword.Size = new System.Drawing.Size(128, 17);
            this.chk_showPassword.TabIndex = 3;
            this.chk_showPassword.Text = "Afficher mot de passe";
            this.chk_showPassword.UseVisualStyleBackColor = true;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(199, 179);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(91, 23);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "Se connecter";
            this.btn_connect.UseVisualStyleBackColor = true;
            // 
            // frAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 214);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.chk_showPassword);
            this.Controls.Add(this.txtBox_password);
            this.Controls.Add(this.txtBox_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frAuth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_username;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.CheckBox chk_showPassword;
        private System.Windows.Forms.Button btn_connect;
    }
}

