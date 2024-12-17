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
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void btnshowmass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is message:)");
        }

        private void btnmessagewithtitel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is message:)","test");
        }

        private void btnshowwithtitelandbutt_Click(object sender, EventArgs e)
        {
            if(
            MessageBox.Show( "are you sury", "confirm!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("user pressed ok");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("are you sury", "confirm!", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("user pressed ok");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("are you sury", "confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("user pressed ok");
            }
        }
    }
}
