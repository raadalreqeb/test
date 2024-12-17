using firstprojectWinForms.Properties;
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
    public partial class frmPictuerBox : Form
    {
        public frmPictuerBox()
        {
            InitializeComponent();
        }

        private void btnkillua_Click(object sender, EventArgs e)
        {
            pictureBox1.Image=Resources.killua;
        }

        private void btngon_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.gon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\2024\kurapika.jpeg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
