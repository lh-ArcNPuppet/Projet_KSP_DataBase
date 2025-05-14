namespace Dashboard
{
    partial class frDashboard
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.missionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lanceursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kerbonautesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateurLKOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerLaListeDesStatusMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerLaListeDesSituationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configLanceurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerLaListeDesTypesDeLanceursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configPayloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerLaListeDesTypesDePayloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configKerbonauteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerLaListeDesProfessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autresConfigsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerLaListeDesAstresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerLaListeDesSystèmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerLaListeDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tStripLbl_connectionState = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donnéesToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.paramètresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donnéesToolStripMenuItem
            // 
            this.donnéesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.missionsToolStripMenuItem,
            this.lanceursToolStripMenuItem,
            this.payloadToolStripMenuItem,
            this.kerbonautesToolStripMenuItem});
            this.donnéesToolStripMenuItem.Name = "donnéesToolStripMenuItem";
            this.donnéesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.donnéesToolStripMenuItem.Text = "Données";
            // 
            // missionsToolStripMenuItem
            // 
            this.missionsToolStripMenuItem.Name = "missionsToolStripMenuItem";
            this.missionsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.missionsToolStripMenuItem.Text = "Missions";
            this.missionsToolStripMenuItem.Click += new System.EventHandler(this.missionsToolStripMenuItem_Click);
            // 
            // lanceursToolStripMenuItem
            // 
            this.lanceursToolStripMenuItem.Name = "lanceursToolStripMenuItem";
            this.lanceursToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.lanceursToolStripMenuItem.Text = "Lanceurs";
            this.lanceursToolStripMenuItem.Click += new System.EventHandler(this.lanceursToolStripMenuItem_Click);
            // 
            // payloadToolStripMenuItem
            // 
            this.payloadToolStripMenuItem.Name = "payloadToolStripMenuItem";
            this.payloadToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.payloadToolStripMenuItem.Text = "Payloads";
            this.payloadToolStripMenuItem.Click += new System.EventHandler(this.payloadToolStripMenuItem_Click);
            // 
            // kerbonautesToolStripMenuItem
            // 
            this.kerbonautesToolStripMenuItem.Name = "kerbonautesToolStripMenuItem";
            this.kerbonautesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.kerbonautesToolStripMenuItem.Text = "Astronautes";
            this.kerbonautesToolStripMenuItem.Click += new System.EventHandler(this.kerbonautesToolStripMenuItem_Click);
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateurLKOToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // calculateurLKOToolStripMenuItem
            // 
            this.calculateurLKOToolStripMenuItem.Name = "calculateurLKOToolStripMenuItem";
            this.calculateurLKOToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.calculateurLKOToolStripMenuItem.Text = "Calculateur LKO";
            this.calculateurLKOToolStripMenuItem.Click += new System.EventHandler(this.calculateurLKOToolStripMenuItem_Click);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configMissionToolStripMenuItem,
            this.configLanceurToolStripMenuItem,
            this.configPayloadToolStripMenuItem,
            this.configKerbonauteToolStripMenuItem,
            this.autresConfigsToolStripMenuItem});
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            // 
            // configMissionToolStripMenuItem
            // 
            this.configMissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editerLaListeDesStatusMissionToolStripMenuItem,
            this.editerLaListeDesSituationsToolStripMenuItem});
            this.configMissionToolStripMenuItem.Name = "configMissionToolStripMenuItem";
            this.configMissionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configMissionToolStripMenuItem.Text = "Config Mission";
            // 
            // editerLaListeDesStatusMissionToolStripMenuItem
            // 
            this.editerLaListeDesStatusMissionToolStripMenuItem.Name = "editerLaListeDesStatusMissionToolStripMenuItem";
            this.editerLaListeDesStatusMissionToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.editerLaListeDesStatusMissionToolStripMenuItem.Text = "Editer la liste des status mission";
            this.editerLaListeDesStatusMissionToolStripMenuItem.Click += new System.EventHandler(this.editerLaListeDesStatusMissionToolStripMenuItem_Click);
            // 
            // editerLaListeDesSituationsToolStripMenuItem
            // 
            this.editerLaListeDesSituationsToolStripMenuItem.Name = "editerLaListeDesSituationsToolStripMenuItem";
            this.editerLaListeDesSituationsToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.editerLaListeDesSituationsToolStripMenuItem.Text = "Editer la liste des situations";
            this.editerLaListeDesSituationsToolStripMenuItem.Click += new System.EventHandler(this.editerLaListeDesSituationsToolStripMenuItem_Click);
            // 
            // configLanceurToolStripMenuItem
            // 
            this.configLanceurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editerLaListeDesTypesDeLanceursToolStripMenuItem});
            this.configLanceurToolStripMenuItem.Name = "configLanceurToolStripMenuItem";
            this.configLanceurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configLanceurToolStripMenuItem.Text = "Config Lanceur";
            // 
            // editerLaListeDesTypesDeLanceursToolStripMenuItem
            // 
            this.editerLaListeDesTypesDeLanceursToolStripMenuItem.Name = "editerLaListeDesTypesDeLanceursToolStripMenuItem";
            this.editerLaListeDesTypesDeLanceursToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.editerLaListeDesTypesDeLanceursToolStripMenuItem.Text = "Editer la liste des types de lanceurs";
            this.editerLaListeDesTypesDeLanceursToolStripMenuItem.Click += new System.EventHandler(this.editerLaListeDesTypesDeLanceursToolStripMenuItem_Click);
            // 
            // configPayloadToolStripMenuItem
            // 
            this.configPayloadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editerLaListeDesTypesDePayloadsToolStripMenuItem});
            this.configPayloadToolStripMenuItem.Name = "configPayloadToolStripMenuItem";
            this.configPayloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configPayloadToolStripMenuItem.Text = "Config Payload";
            // 
            // editerLaListeDesTypesDePayloadsToolStripMenuItem
            // 
            this.editerLaListeDesTypesDePayloadsToolStripMenuItem.Name = "editerLaListeDesTypesDePayloadsToolStripMenuItem";
            this.editerLaListeDesTypesDePayloadsToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.editerLaListeDesTypesDePayloadsToolStripMenuItem.Text = "Editer la liste des types de payloads";
            this.editerLaListeDesTypesDePayloadsToolStripMenuItem.Click += new System.EventHandler(this.editerLaListeDesTypesDePayloadsToolStripMenuItem_Click);
            // 
            // configKerbonauteToolStripMenuItem
            // 
            this.configKerbonauteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editerLaListeDesProfessionsToolStripMenuItem});
            this.configKerbonauteToolStripMenuItem.Name = "configKerbonauteToolStripMenuItem";
            this.configKerbonauteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configKerbonauteToolStripMenuItem.Text = "Config Astronaute";
            // 
            // editerLaListeDesProfessionsToolStripMenuItem
            // 
            this.editerLaListeDesProfessionsToolStripMenuItem.Name = "editerLaListeDesProfessionsToolStripMenuItem";
            this.editerLaListeDesProfessionsToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.editerLaListeDesProfessionsToolStripMenuItem.Text = "Editer la liste des professions";
            this.editerLaListeDesProfessionsToolStripMenuItem.Click += new System.EventHandler(this.editerLaListeDesProfessionsToolStripMenuItem_Click);
            // 
            // autresConfigsToolStripMenuItem
            // 
            this.autresConfigsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editerLaListeDesAstresToolStripMenuItem,
            this.editerLaListeDesSystèmesToolStripMenuItem,
            this.editerLaListeDesUtilisateursToolStripMenuItem});
            this.autresConfigsToolStripMenuItem.Name = "autresConfigsToolStripMenuItem";
            this.autresConfigsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autresConfigsToolStripMenuItem.Text = "Autres configs";
            // 
            // editerLaListeDesAstresToolStripMenuItem
            // 
            this.editerLaListeDesAstresToolStripMenuItem.Name = "editerLaListeDesAstresToolStripMenuItem";
            this.editerLaListeDesAstresToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.editerLaListeDesAstresToolStripMenuItem.Text = "Editer la liste des astres";
            this.editerLaListeDesAstresToolStripMenuItem.Click += new System.EventHandler(this.editerLaListeDesAstresToolStripMenuItem_Click);
            // 
            // editerLaListeDesSystèmesToolStripMenuItem
            // 
            this.editerLaListeDesSystèmesToolStripMenuItem.Name = "editerLaListeDesSystèmesToolStripMenuItem";
            this.editerLaListeDesSystèmesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.editerLaListeDesSystèmesToolStripMenuItem.Text = "Editer la liste des systèmes";
            this.editerLaListeDesSystèmesToolStripMenuItem.Click += new System.EventHandler(this.editerLaListeDesSystèmesToolStripMenuItem_Click);
            // 
            // editerLaListeDesUtilisateursToolStripMenuItem
            // 
            this.editerLaListeDesUtilisateursToolStripMenuItem.Name = "editerLaListeDesUtilisateursToolStripMenuItem";
            this.editerLaListeDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.editerLaListeDesUtilisateursToolStripMenuItem.Text = "Editer la liste des utilisateurs";
            this.editerLaListeDesUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.editerLaListeDesUtilisateursToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripLbl_connectionState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tStripLbl_connectionState
            // 
            this.tStripLbl_connectionState.Name = "tStripLbl_connectionState";
            this.tStripLbl_connectionState.Size = new System.Drawing.Size(16, 17);
            this.tStripLbl_connectionState.Text = "...";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frDashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Dashboard";
            this.Load += new System.EventHandler(this.frDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem missionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lanceursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kerbonautesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateurLKOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configMissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configLanceurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configPayloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configKerbonauteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerLaListeDesStatusMissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerLaListeDesSituationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerLaListeDesTypesDeLanceursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerLaListeDesTypesDePayloadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerLaListeDesProfessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autresConfigsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerLaListeDesAstresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerLaListeDesSystèmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerLaListeDesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tStripLbl_connectionState;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

