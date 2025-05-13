namespace Kerbonaute
{
    partial class frAstronaute
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
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_editer = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.dgv_listKerbonaute = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listKerbonaute)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(602, 12);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 0;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            // 
            // btn_editer
            // 
            this.btn_editer.Location = new System.Drawing.Point(521, 12);
            this.btn_editer.Name = "btn_editer";
            this.btn_editer.Size = new System.Drawing.Size(75, 23);
            this.btn_editer.TabIndex = 0;
            this.btn_editer.Text = "Editer";
            this.btn_editer.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(440, 12);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 0;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // dgv_listKerbonaute
            // 
            this.dgv_listKerbonaute.AllowUserToAddRows = false;
            this.dgv_listKerbonaute.AllowUserToDeleteRows = false;
            this.dgv_listKerbonaute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listKerbonaute.Location = new System.Drawing.Point(12, 41);
            this.dgv_listKerbonaute.Name = "dgv_listKerbonaute";
            this.dgv_listKerbonaute.ReadOnly = true;
            this.dgv_listKerbonaute.Size = new System.Drawing.Size(665, 330);
            this.dgv_listKerbonaute.TabIndex = 1;
            // 
            // frKerbonaute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 383);
            this.Controls.Add(this.dgv_listKerbonaute);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_editer);
            this.Controls.Add(this.btn_ajouter);
            this.Name = "frKerbonaute";
            this.Text = "Liste des kerbonautes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listKerbonaute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_editer;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.DataGridView dgv_listKerbonaute;
    }
}

