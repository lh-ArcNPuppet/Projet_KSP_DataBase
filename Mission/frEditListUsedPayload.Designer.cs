namespace Mission
{
    partial class frEditListUsedPayload
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
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_retirer = new System.Windows.Forms.Button();
            this.lst_usedPayloads = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_listPayloads = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.txtBox_modificationNomPayload = new System.Windows.Forms.TextBox();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_editer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listPayloads)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(174, 93);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 2;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_retirer
            // 
            this.btn_retirer.Location = new System.Drawing.Point(174, 122);
            this.btn_retirer.Name = "btn_retirer";
            this.btn_retirer.Size = new System.Drawing.Size(75, 23);
            this.btn_retirer.TabIndex = 3;
            this.btn_retirer.Text = "Retirer";
            this.btn_retirer.UseVisualStyleBackColor = true;
            this.btn_retirer.Click += new System.EventHandler(this.btn_retirer_Click);
            // 
            // lst_usedPayloads
            // 
            this.lst_usedPayloads.FormattingEnabled = true;
            this.lst_usedPayloads.Location = new System.Drawing.Point(12, 29);
            this.lst_usedPayloads.Name = "lst_usedPayloads";
            this.lst_usedPayloads.Size = new System.Drawing.Size(156, 212);
            this.lst_usedPayloads.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liste des payloads";
            // 
            // dgv_listPayloads
            // 
            this.dgv_listPayloads.AllowUserToAddRows = false;
            this.dgv_listPayloads.AllowUserToDeleteRows = false;
            this.dgv_listPayloads.AllowUserToResizeColumns = false;
            this.dgv_listPayloads.AllowUserToResizeRows = false;
            this.dgv_listPayloads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listPayloads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listPayloads.Location = new System.Drawing.Point(255, 28);
            this.dgv_listPayloads.Name = "dgv_listPayloads";
            this.dgv_listPayloads.ReadOnly = true;
            this.dgv_listPayloads.RowHeadersVisible = false;
            this.dgv_listPayloads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listPayloads.Size = new System.Drawing.Size(270, 213);
            this.dgv_listPayloads.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Liste des payloads utilisé(s)";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(426, 247);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(99, 23);
            this.btn_valider.TabIndex = 3;
            this.btn_valider.Text = "Valider la liste";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // txtBox_modificationNomPayload
            // 
            this.txtBox_modificationNomPayload.Enabled = false;
            this.txtBox_modificationNomPayload.Location = new System.Drawing.Point(12, 249);
            this.txtBox_modificationNomPayload.Name = "txtBox_modificationNomPayload";
            this.txtBox_modificationNomPayload.Size = new System.Drawing.Size(156, 20);
            this.txtBox_modificationNomPayload.TabIndex = 7;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Enabled = false;
            this.btn_modifier.Location = new System.Drawing.Point(174, 249);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 8;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_editer
            // 
            this.btn_editer.Location = new System.Drawing.Point(174, 151);
            this.btn_editer.Name = "btn_editer";
            this.btn_editer.Size = new System.Drawing.Size(75, 23);
            this.btn_editer.TabIndex = 9;
            this.btn_editer.Text = "Editer";
            this.btn_editer.UseVisualStyleBackColor = true;
            this.btn_editer.Click += new System.EventHandler(this.btn_editer_Click);
            // 
            // frEditListUsedPayload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 288);
            this.Controls.Add(this.btn_editer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.txtBox_modificationNomPayload);
            this.Controls.Add(this.dgv_listPayloads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_usedPayloads);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_retirer);
            this.Controls.Add(this.btn_ajouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frEditListUsedPayload";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edition liste des payloads utilisé";
            this.Load += new System.EventHandler(this.frEditListUsedPayload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listPayloads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_retirer;
        private System.Windows.Forms.ListBox lst_usedPayloads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_listPayloads;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.TextBox txtBox_modificationNomPayload;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_editer;
    }
}