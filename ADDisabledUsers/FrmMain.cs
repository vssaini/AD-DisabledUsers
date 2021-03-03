using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ADDisabledUsers.Code;
using DevExpress.XtraEditors;

namespace ADDisabledUsers
{
    public partial class FrmMain : Form
    {
        private int _totalUsers;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnRetrieveUsers_Click(object sender, EventArgs e)
        {
            bgwUsers.RunWorkerAsync();
        }

        private void bgwUsers_DoWork(object sender, DoWorkEventArgs e)
        {
            var paths = txtOuPath.Text.Split(';');
            var dc = txtDomainController.Text.Trim();
            var user = txtAdminUser.Text.Trim();
            var password = txtAdminPassword.Text;

            btnRetrieveUsers.Enabled = false;
            e.Result = ADUtilities.InitiateRetrievingADUsers(dc, paths, user, password, bgwUsers, ref _totalUsers);
        }

        private void bgwUsers_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = (string)e.UserState;
        }

        private void bgwUsers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnRetrieveUsers.Enabled = true;

            if (e.Error != null)
            {
                lblStatus.Text = "Error was reported.";
                XtraMessageBox.Show("Error:- " + e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (_totalUsers > 0)
                {
                    lblStatus.Text = string.Format("{0} users were imported successfully!", _totalUsers);
                    var users = (List<ADUser>)e.Result;
                    gcUsers.DataSource = users;
                }
                else
                    lblStatus.Text = "No user found!";
            }
        }
    }
}
