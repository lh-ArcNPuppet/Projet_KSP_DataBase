namespace Configuration
{
    partial class frConfigAstre
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
            this.lbl_numAstre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_systemeParent = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBox_nom = new System.Windows.Forms.TextBox();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.dgv_listeAstre = new System.Windows.Forms.DataGridView();
            this.numUD_rayon = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBox_description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_atmosphere = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numUD_periodeOrbitale = new System.Windows.Forms.NumericUpDown();
            this.numUD_graviteSurface = new System.Windows.Forms.NumericUpDown();
            this.numUD_temperature = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeAstre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_rayon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_periodeOrbitale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_graviteSurface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_temperature)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Astre n°";
            // 
            // lbl_numAstre
            // 
            this.lbl_numAstre.AutoSize = true;
            this.lbl_numAstre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numAstre.Location = new System.Drawing.Point(53, 9);
            this.lbl_numAstre.Name = "lbl_numAstre";
            this.lbl_numAstre.Size = new System.Drawing.Size(14, 13);
            this.lbl_numAstre.TabIndex = 0;
            this.lbl_numAstre.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Système parent :";
            // 
            // cbo_systemeParent
            // 
            this.cbo_systemeParent.FormattingEnabled = true;
            this.cbo_systemeParent.Location = new System.Drawing.Point(104, 72);
            this.cbo_systemeParent.Name = "cbo_systemeParent";
            this.cbo_systemeParent.Size = new System.Drawing.Size(136, 21);
            this.cbo_systemeParent.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(246, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Type :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Nom :";
            // 
            // txtBox_nom
            // 
            this.txtBox_nom.Location = new System.Drawing.Point(104, 25);
            this.txtBox_nom.Name = "txtBox_nom";
            this.txtBox_nom.Size = new System.Drawing.Size(136, 20);
            this.txtBox_nom.TabIndex = 38;
            // 
            // cbo_type
            // 
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Location = new System.Drawing.Point(104, 48);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(136, 21);
            this.cbo_type.TabIndex = 47;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(222, 366);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.btn_enregistrer.TabIndex = 50;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(141, 366);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 50;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // dgv_listeAstre
            // 
            this.dgv_listeAstre.AllowUserToAddRows = false;
            this.dgv_listeAstre.AllowUserToDeleteRows = false;
            this.dgv_listeAstre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listeAstre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeAstre.Location = new System.Drawing.Point(303, 9);
            this.dgv_listeAstre.Name = "dgv_listeAstre";
            this.dgv_listeAstre.ReadOnly = true;
            this.dgv_listeAstre.Size = new System.Drawing.Size(469, 380);
            this.dgv_listeAstre.TabIndex = 51;
            // 
            // numUD_rayon
            // 
            this.numUD_rayon.DecimalPlaces = 1;
            this.numUD_rayon.Location = new System.Drawing.Point(94, 19);
            this.numUD_rayon.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numUD_rayon.Name = "numUD_rayon";
            this.numUD_rayon.Size = new System.Drawing.Size(83, 20);
            this.numUD_rayon.TabIndex = 52;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBox_description);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBox_atmosphere);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numUD_periodeOrbitale);
            this.groupBox1.Controls.Add(this.numUD_graviteSurface);
            this.groupBox1.Controls.Add(this.numUD_temperature);
            this.groupBox1.Controls.Add(this.numUD_rayon);
            this.groupBox1.Location = new System.Drawing.Point(15, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 261);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caractéristiques";
            // 
            // txtBox_description
            // 
            this.txtBox_description.Location = new System.Drawing.Point(94, 170);
            this.txtBox_description.Multiline = true;
            this.txtBox_description.Name = "txtBox_description";
            this.txtBox_description.Size = new System.Drawing.Size(182, 83);
            this.txtBox_description.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Atmosphère :";
            // 
            // txtBox_atmosphere
            // 
            this.txtBox_atmosphere.Location = new System.Drawing.Point(94, 88);
            this.txtBox_atmosphere.Multiline = true;
            this.txtBox_atmosphere.Name = "txtBox_atmosphere";
            this.txtBox_atmosphere.Size = new System.Drawing.Size(182, 56);
            this.txtBox_atmosphere.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(180, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "jour(s)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(180, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "m/s²";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(180, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Kelvin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(180, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "km";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Description :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Période orbitale :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Gravité surface :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Température :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Rayon :";
            // 
            // numUD_periodeOrbitale
            // 
            this.numUD_periodeOrbitale.DecimalPlaces = 2;
            this.numUD_periodeOrbitale.Location = new System.Drawing.Point(94, 147);
            this.numUD_periodeOrbitale.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUD_periodeOrbitale.Name = "numUD_periodeOrbitale";
            this.numUD_periodeOrbitale.Size = new System.Drawing.Size(83, 20);
            this.numUD_periodeOrbitale.TabIndex = 52;
            // 
            // numUD_graviteSurface
            // 
            this.numUD_graviteSurface.DecimalPlaces = 3;
            this.numUD_graviteSurface.Location = new System.Drawing.Point(94, 65);
            this.numUD_graviteSurface.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUD_graviteSurface.Name = "numUD_graviteSurface";
            this.numUD_graviteSurface.Size = new System.Drawing.Size(83, 20);
            this.numUD_graviteSurface.TabIndex = 52;
            // 
            // numUD_temperature
            // 
            this.numUD_temperature.Location = new System.Drawing.Point(94, 42);
            this.numUD_temperature.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numUD_temperature.Name = "numUD_temperature";
            this.numUD_temperature.Size = new System.Drawing.Size(83, 20);
            this.numUD_temperature.TabIndex = 52;
            // 
            // frConfigAstre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_listeAstre);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_systemeParent);
            this.Controls.Add(this.cbo_type);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBox_nom);
            this.Controls.Add(this.lbl_numAstre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frConfigAstre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurer liste Astres";
            this.Load += new System.EventHandler(this.frConfigAstre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeAstre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_rayon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_periodeOrbitale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_graviteSurface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_temperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_numAstre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_systemeParent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBox_nom;
        private System.Windows.Forms.ComboBox cbo_type;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.DataGridView dgv_listeAstre;
        private System.Windows.Forms.NumericUpDown numUD_rayon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUD_graviteSurface;
        private System.Windows.Forms.NumericUpDown numUD_temperature;
        private System.Windows.Forms.TextBox txtBox_description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_atmosphere;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUD_periodeOrbitale;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

