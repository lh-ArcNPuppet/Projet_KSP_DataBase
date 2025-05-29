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
            this.cbo_listAstronaute = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_listAstronaute = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listAstronaute)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_listAstronaute
            // 
            this.cbo_listAstronaute.FormattingEnabled = true;
            this.cbo_listAstronaute.Location = new System.Drawing.Point(12, 12);
            this.cbo_listAstronaute.Name = "cbo_listAstronaute";
            this.cbo_listAstronaute.Size = new System.Drawing.Size(156, 21);
            this.cbo_listAstronaute.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 173);
            this.listBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liste des astronautes";
            // 
            // dgv_listAstronaute
            // 
            this.dgv_listAstronaute.AllowUserToAddRows = false;
            this.dgv_listAstronaute.AllowUserToDeleteRows = false;
            this.dgv_listAstronaute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listAstronaute.Location = new System.Drawing.Point(215, 28);
            this.dgv_listAstronaute.Name = "dgv_listAstronaute";
            this.dgv_listAstronaute.ReadOnly = true;
            this.dgv_listAstronaute.Size = new System.Drawing.Size(270, 213);
            this.dgv_listAstronaute.TabIndex = 6;
            // 
            // frEditListUsedPayload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 258);
            this.Controls.Add(this.dgv_listAstronaute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbo_listAstronaute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frEditListUsedPayload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edition liste des payloads utilisé";
            this.Load += new System.EventHandler(this.frEditListUsedPayload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listAstronaute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_listAstronaute;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_listAstronaute;
    }
}