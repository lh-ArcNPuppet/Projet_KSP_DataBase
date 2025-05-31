namespace Mission
{
    partial class frEditListAstronautes
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
            this.dgv_listAstronaute = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_usedAstronaute = new System.Windows.Forms.ListBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_retirer = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listAstronaute)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listAstronaute
            // 
            this.dgv_listAstronaute.AllowUserToAddRows = false;
            this.dgv_listAstronaute.AllowUserToDeleteRows = false;
            this.dgv_listAstronaute.AllowUserToResizeColumns = false;
            this.dgv_listAstronaute.AllowUserToResizeRows = false;
            this.dgv_listAstronaute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listAstronaute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listAstronaute.Location = new System.Drawing.Point(255, 25);
            this.dgv_listAstronaute.Name = "dgv_listAstronaute";
            this.dgv_listAstronaute.ReadOnly = true;
            this.dgv_listAstronaute.RowHeadersVisible = false;
            this.dgv_listAstronaute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listAstronaute.Size = new System.Drawing.Size(313, 213);
            this.dgv_listAstronaute.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Liste des astronautes assigné(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Liste des astronautes";
            // 
            // lst_usedAstronaute
            // 
            this.lst_usedAstronaute.FormattingEnabled = true;
            this.lst_usedAstronaute.Location = new System.Drawing.Point(12, 26);
            this.lst_usedAstronaute.Name = "lst_usedAstronaute";
            this.lst_usedAstronaute.Size = new System.Drawing.Size(156, 212);
            this.lst_usedAstronaute.TabIndex = 13;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(469, 244);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(99, 23);
            this.btn_valider.TabIndex = 11;
            this.btn_valider.Text = "Valider la liste";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_retirer
            // 
            this.btn_retirer.Location = new System.Drawing.Point(174, 138);
            this.btn_retirer.Name = "btn_retirer";
            this.btn_retirer.Size = new System.Drawing.Size(75, 23);
            this.btn_retirer.TabIndex = 12;
            this.btn_retirer.Text = "Retirer";
            this.btn_retirer.UseVisualStyleBackColor = true;
            this.btn_retirer.Click += new System.EventHandler(this.btn_retirer_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(174, 109);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 10;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // frEditListAstronautes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 282);
            this.Controls.Add(this.dgv_listAstronaute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_usedAstronaute);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_retirer);
            this.Controls.Add(this.btn_ajouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frEditListAstronautes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edition liste des astronautes";
            this.Load += new System.EventHandler(this.frEditListAstronautes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listAstronaute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_listAstronaute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_usedAstronaute;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_retirer;
        private System.Windows.Forms.Button btn_ajouter;
    }
}