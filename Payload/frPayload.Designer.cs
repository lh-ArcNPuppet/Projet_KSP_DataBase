namespace Payload
{
    partial class frPayload
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
            this.dgv_listPayloads = new System.Windows.Forms.DataGridView();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_editer = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_details = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listPayloads)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listPayloads
            // 
            this.dgv_listPayloads.AllowUserToAddRows = false;
            this.dgv_listPayloads.AllowUserToDeleteRows = false;
            this.dgv_listPayloads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_listPayloads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_listPayloads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listPayloads.Location = new System.Drawing.Point(12, 41);
            this.dgv_listPayloads.Name = "dgv_listPayloads";
            this.dgv_listPayloads.ReadOnly = true;
            this.dgv_listPayloads.RowHeadersVisible = false;
            this.dgv_listPayloads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listPayloads.Size = new System.Drawing.Size(765, 349);
            this.dgv_listPayloads.TabIndex = 0;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajouter.Location = new System.Drawing.Point(699, 12);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 1;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_editer
            // 
            this.btn_editer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editer.Location = new System.Drawing.Point(618, 12);
            this.btn_editer.Name = "btn_editer";
            this.btn_editer.Size = new System.Drawing.Size(75, 23);
            this.btn_editer.TabIndex = 1;
            this.btn_editer.Text = "Editer";
            this.btn_editer.UseVisualStyleBackColor = true;
            this.btn_editer.Click += new System.EventHandler(this.btn_editer_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_supprimer.Location = new System.Drawing.Point(537, 12);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 1;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_details
            // 
            this.btn_details.Location = new System.Drawing.Point(456, 12);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(75, 23);
            this.btn_details.TabIndex = 2;
            this.btn_details.Text = "Détails";
            this.btn_details.UseVisualStyleBackColor = true;
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // frPayload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 403);
            this.Controls.Add(this.btn_details);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_editer);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.dgv_listPayloads);
            this.Name = "frPayload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un payload";
            this.Load += new System.EventHandler(this.frPayload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listPayloads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listPayloads;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_editer;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_details;
    }
}

