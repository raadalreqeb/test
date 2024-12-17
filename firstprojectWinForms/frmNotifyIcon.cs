﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstprojectWinForms
{
    public partial class frmNotifyIcon : Form
    {
        public frmNotifyIcon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            notifyIcon1.BalloonTipTitle = "This is titel";
            notifyIcon1.BalloonTipText = "this is message";
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }
    }
}
