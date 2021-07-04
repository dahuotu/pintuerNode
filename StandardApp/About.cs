using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace com.DaHuotu
{
    public partial class frmAbout : Form
    {
        string appName = Properties.Settings.Default.appName;
        string appVersion = Properties.Settings.Default.appVersion;
        string appSite = Properties.Settings.Default.appSite;
        string appLink = Properties.Settings.Default.appAbout;

        public frmAbout()
        {
            InitializeComponent();
        }

        private void linkSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(appSite);
        }

        private void linkLabelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(appLink);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            this.labSoftName.Text = appName;
            this.labVsion.Text = "Version " + appVersion;
        }
    }
}
