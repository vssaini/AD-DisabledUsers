namespace ADDisabledUsers
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.gcUsers = new DevExpress.XtraGrid.GridControl();
            this.gvUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnRetrieveUsers = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.lblDomainController = new DevExpress.XtraEditors.LabelControl();
            this.bgwUsers = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPath = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDomainController = new DevExpress.XtraEditors.TextEdit();
            this.txtOuPath = new DevExpress.XtraEditors.TextEdit();
            this.txtAdminUser = new DevExpress.XtraEditors.TextEdit();
            this.txtAdminPassword = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomainController.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOuPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdminUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdminPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcUsers
            // 
            this.gcUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcUsers.Location = new System.Drawing.Point(12, 179);
            this.gcUsers.MainView = this.gvUsers;
            this.gcUsers.Name = "gcUsers";
            this.gcUsers.Size = new System.Drawing.Size(542, 231);
            this.gcUsers.TabIndex = 0;
            this.gcUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsers});
            // 
            // gvUsers
            // 
            this.gvUsers.GridControl = this.gcUsers;
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.OptionsView.ShowGroupPanel = false;
            // 
            // btnRetrieveUsers
            // 
            this.btnRetrieveUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnRetrieveUsers.Image")));
            this.btnRetrieveUsers.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnRetrieveUsers.Location = new System.Drawing.Point(460, 150);
            this.btnRetrieveUsers.Name = "btnRetrieveUsers";
            this.btnRetrieveUsers.Size = new System.Drawing.Size(94, 23);
            this.btnRetrieveUsers.TabIndex = 2;
            this.btnRetrieveUsers.Text = "Show Users";
            this.btnRetrieveUsers.Click += new System.EventHandler(this.btnRetrieveUsers_Click);
            // 
            // lblDomainController
            // 
            this.lblDomainController.Location = new System.Drawing.Point(12, 21);
            this.lblDomainController.Name = "lblDomainController";
            this.lblDomainController.Size = new System.Drawing.Size(89, 13);
            this.lblDomainController.TabIndex = 3;
            this.lblDomainController.Text = "Domain Controller:";
            // 
            // bgwUsers
            // 
            this.bgwUsers.WorkerReportsProgress = true;
            this.bgwUsers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwUsers_DoWork);
            this.bgwUsers.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwUsers_ProgressChanged);
            this.bgwUsers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwUsers_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(566, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(26, 17);
            this.lblStatus.Text = "Idle";
            // 
            // lblPath
            // 
            this.lblPath.Location = new System.Drawing.Point(12, 58);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(78, 13);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "Path to look for:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Admin User:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 131);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Admin Password:";
            // 
            // txtDomainController
            // 
            this.txtDomainController.Location = new System.Drawing.Point(116, 14);
            this.txtDomainController.Name = "txtDomainController";
            this.txtDomainController.Size = new System.Drawing.Size(243, 20);
            this.txtDomainController.TabIndex = 8;
            // 
            // txtOuPath
            // 
            this.txtOuPath.Location = new System.Drawing.Point(116, 51);
            this.txtOuPath.Name = "txtOuPath";
            this.txtOuPath.Size = new System.Drawing.Size(243, 20);
            this.txtOuPath.TabIndex = 9;
            // 
            // txtAdminUser
            // 
            this.txtAdminUser.EditValue = "Administrator";
            this.txtAdminUser.Location = new System.Drawing.Point(116, 89);
            this.txtAdminUser.Name = "txtAdminUser";
            this.txtAdminUser.Size = new System.Drawing.Size(243, 20);
            this.txtAdminUser.TabIndex = 10;
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.EditValue = "Pass99";
            this.txtAdminPassword.Location = new System.Drawing.Point(116, 124);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Properties.PasswordChar = '*';
            this.txtAdminPassword.Size = new System.Drawing.Size(243, 20);
            this.txtAdminPassword.TabIndex = 11;
            // 
            // FrmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 457);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.txtAdminUser);
            this.Controls.Add(this.txtOuPath);
            this.Controls.Add(this.txtDomainController);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblDomainController);
            this.Controls.Add(this.btnRetrieveUsers);
            this.Controls.Add(this.gcUsers);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AD Disabled Users";
            ((System.ComponentModel.ISupportInitialize)(this.gcUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomainController.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOuPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdminUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdminPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUsers;
        private DevExpress.XtraEditors.SimpleButton btnRetrieveUsers;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl lblDomainController;
        private System.ComponentModel.BackgroundWorker bgwUsers;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private DevExpress.XtraEditors.LabelControl lblPath;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtDomainController;
        private DevExpress.XtraEditors.TextEdit txtOuPath;
        private DevExpress.XtraEditors.TextEdit txtAdminUser;
        private DevExpress.XtraEditors.TextEdit txtAdminPassword;
    }
}

