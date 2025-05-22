namespace Lanceur
{
    partial class frDetailsLanceur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frDetailsLanceur));
            this.lbl_id = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_commentaire = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_nbrEtage = new System.Windows.Forms.Label();
            this.lbl_deltaV = new System.Windows.Forms.Label();
            this.lbl_leoMax = new System.Windows.Forms.Label();
            this.lbl_masse = new System.Windows.Forms.Label();
            this.lbl_longueur = new System.Windows.Forms.Label();
            this.lbl_largeur = new System.Windows.Forms.Label();
            this.lbl_hauteur = new System.Windows.Forms.Label();
            this.lbl_cout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(89, 9);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(14, 13);
            this.lbl_id.TabIndex = 54;
            this.lbl_id.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 53;
            this.label18.Text = "ID du lanceur :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_leoMax);
            this.groupBox2.Controls.Add(this.lbl_deltaV);
            this.groupBox2.Controls.Add(this.lbl_nbrEtage);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(15, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 95);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caractéristiques";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "LEO max :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Delta V :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nbr d\'étage :";
            // 
            // txtBox_commentaire
            // 
            this.txtBox_commentaire.HideSelection = false;
            this.txtBox_commentaire.Location = new System.Drawing.Point(15, 343);
            this.txtBox_commentaire.Multiline = true;
            this.txtBox_commentaire.Name = "txtBox_commentaire";
            this.txtBox_commentaire.ReadOnly = true;
            this.txtBox_commentaire.Size = new System.Drawing.Size(254, 110);
            this.txtBox_commentaire.TabIndex = 50;
            this.txtBox_commentaire.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Commentaire :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_cout);
            this.groupBox1.Controls.Add(this.lbl_hauteur);
            this.groupBox1.Controls.Add(this.lbl_largeur);
            this.groupBox1.Controls.Add(this.lbl_longueur);
            this.groupBox1.Controls.Add(this.lbl_masse);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(15, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 142);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistiques";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Coût :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Hauteur :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Largueur :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Longueur :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Masse :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nom :";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.Location = new System.Drawing.Point(48, 31);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(34, 13);
            this.lbl_nom.TabIndex = 55;
            this.lbl_nom.Text = "label";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(48, 54);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(34, 13);
            this.lbl_type.TabIndex = 55;
            this.lbl_type.Text = "label";
            // 
            // lbl_nbrEtage
            // 
            this.lbl_nbrEtage.AutoSize = true;
            this.lbl_nbrEtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nbrEtage.Location = new System.Drawing.Point(83, 20);
            this.lbl_nbrEtage.Name = "lbl_nbrEtage";
            this.lbl_nbrEtage.Size = new System.Drawing.Size(34, 13);
            this.lbl_nbrEtage.TabIndex = 55;
            this.lbl_nbrEtage.Text = "label";
            // 
            // lbl_deltaV
            // 
            this.lbl_deltaV.AutoSize = true;
            this.lbl_deltaV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deltaV.Location = new System.Drawing.Point(63, 42);
            this.lbl_deltaV.Name = "lbl_deltaV";
            this.lbl_deltaV.Size = new System.Drawing.Size(59, 13);
            this.lbl_deltaV.TabIndex = 55;
            this.lbl_deltaV.Text = "label m/s";
            // 
            // lbl_leoMax
            // 
            this.lbl_leoMax.AutoSize = true;
            this.lbl_leoMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leoMax.Location = new System.Drawing.Point(71, 65);
            this.lbl_leoMax.Name = "lbl_leoMax";
            this.lbl_leoMax.Size = new System.Drawing.Size(84, 13);
            this.lbl_leoMax.TabIndex = 55;
            this.lbl_leoMax.Text = "label tonne(s)";
            // 
            // lbl_masse
            // 
            this.lbl_masse.AutoSize = true;
            this.lbl_masse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masse.Location = new System.Drawing.Point(59, 21);
            this.lbl_masse.Name = "lbl_masse";
            this.lbl_masse.Size = new System.Drawing.Size(84, 13);
            this.lbl_masse.TabIndex = 55;
            this.lbl_masse.Text = "label tonne(s)";
            // 
            // lbl_longueur
            // 
            this.lbl_longueur.AutoSize = true;
            this.lbl_longueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_longueur.Location = new System.Drawing.Point(71, 44);
            this.lbl_longueur.Name = "lbl_longueur";
            this.lbl_longueur.Size = new System.Drawing.Size(83, 13);
            this.lbl_longueur.TabIndex = 55;
            this.lbl_longueur.Text = "label mètre(s)";
            // 
            // lbl_largeur
            // 
            this.lbl_largeur.AutoSize = true;
            this.lbl_largeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_largeur.Location = new System.Drawing.Point(71, 67);
            this.lbl_largeur.Name = "lbl_largeur";
            this.lbl_largeur.Size = new System.Drawing.Size(83, 13);
            this.lbl_largeur.TabIndex = 55;
            this.lbl_largeur.Text = "label mètre(s)";
            // 
            // lbl_hauteur
            // 
            this.lbl_hauteur.AutoSize = true;
            this.lbl_hauteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hauteur.Location = new System.Drawing.Point(71, 90);
            this.lbl_hauteur.Name = "lbl_hauteur";
            this.lbl_hauteur.Size = new System.Drawing.Size(83, 13);
            this.lbl_hauteur.TabIndex = 55;
            this.lbl_hauteur.Text = "label mètre(s)";
            // 
            // lbl_cout
            // 
            this.lbl_cout.AutoSize = true;
            this.lbl_cout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cout.Location = new System.Drawing.Point(47, 113);
            this.lbl_cout.Name = "lbl_cout";
            this.lbl_cout.Size = new System.Drawing.Size(34, 13);
            this.lbl_cout.TabIndex = 55;
            this.lbl_cout.Text = "label";
            // 
            // frDetailsLanceur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 470);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtBox_commentaire);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frDetailsLanceur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Détails du lanceur";
            this.Load += new System.EventHandler(this.frDetailsLanceur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_commentaire;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_leoMax;
        private System.Windows.Forms.Label lbl_deltaV;
        private System.Windows.Forms.Label lbl_nbrEtage;
        private System.Windows.Forms.Label lbl_cout;
        private System.Windows.Forms.Label lbl_hauteur;
        private System.Windows.Forms.Label lbl_largeur;
        private System.Windows.Forms.Label lbl_longueur;
        private System.Windows.Forms.Label lbl_masse;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_type;
    }
}