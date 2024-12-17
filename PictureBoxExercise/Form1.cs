using PictureBoxExercise.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Updateimege()
        {
            if (radboy.Checked)
            {
                pictureBox1.Image = Resources.download_removebg_preview__1_;
                labtitle.Text = " Boy ";
            }
            else if (radgirl.Checked)
            {
                pictureBox1.Image = Resources.download_removebg_preview__2_;
                labtitle.Text = " Girl ";
            }else if(radbook.Checked)
            {
                pictureBox1.Image = Resources.download_removebg_preview__3_;
                labtitle.Text = " Book ";
            }
            else
            {
                pictureBox1.Image = Resources.download_removebg_preview__4_;
                labtitle.Text = " Pen ";
            }
        }

        private void radboy_CheckedChanged(object sender, EventArgs e)
        {
            Updateimege();
        }

        private void radgirl_CheckedChanged(object sender, EventArgs e)
        {
            Updateimege();
        }

        private void radbook_CheckedChanged(object sender, EventArgs e)
        {
            Updateimege();
        }

        private void radpen_CheckedChanged(object sender, EventArgs e)
        {
            Updateimege();
        }
    }
}
