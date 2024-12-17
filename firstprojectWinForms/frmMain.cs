using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnshorpart1_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void btnshowmessage_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMessageBox();
            frm1.ShowDialog();

        }

        private void btncheckandradio_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmchkradiogroup();
            frm1.ShowDialog();
        }

        private void btnmoreabouttextbox_Click(object sender, EventArgs e)
        {
            Form frm1 = new Frmtextbox();
            frm1.ShowDialog();
        }

        private void btnPictuerBox_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmPictuerBox();
            frm1.ShowDialog();

        }

        private void btndraw_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmdraw();
            frm1.ShowDialog();

        }

        private void btnMask_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMask();
            frm1.ShowDialog();
        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmCombobox();
            frm1.ShowDialog();
        }

        private void btnLinkLable_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmLinkLable();
            frm1.ShowDialog();
        }

        private void btnCheckedListBox_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmCheckedListBox();
            frm1.ShowDialog();
        }

        private void btnDateTimePicker_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmDateTimePicker();
            frm1.ShowDialog();
        }

        private void btnMonthCalandar_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMonthCalandar();
            frm1.ShowDialog();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmTimer();
            frm1.ShowDialog();
        }

        private void btnNotifyIcon_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmNotifyIcon();
            frm1.ShowDialog();
        }

        private void btnTreeViewandImageList_Click(object sender, EventArgs e)
        {
            /*Form frm1 = new frmTreeViewandImageList();
            frm1.ShowDialog();*/
        }

        private void btnProgressBar_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmProgressBar();
            frm1.ShowDialog();
        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmListView();
            frm1.ShowDialog();
        }

        private void btnErrorProvider_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmErrorProvider();
            frm1.ShowDialog();
        }

        private void btnTrackBar_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmTrackBar();
            frm1.ShowDialog();

        }

        private void btnNumericUpDown_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmNumericUpDown();
            frm1.ShowDialog();
        }

        private void btnTabControl_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmTabControl();
            frm1.ShowDialog();
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmDialog();
            frm1.ShowDialog();
        }
    }
}
