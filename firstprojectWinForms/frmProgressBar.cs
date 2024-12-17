using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace firstprojectWinForms
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }
        private int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum= 100;
            progressBar1.Minimum= 0;

           
            for (int i=0; i<=10; i++)
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(200);

                    progressBar1.Value += 10;

                    label1.Text=(((float)progressBar1.Value/progressBar1.Maximum)*100)+"%";
                  
                    progressBar1.Refresh();
                    label1.Refresh();
                    

                }
                else
                {
                    button1.Enabled = false;
                }
                
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 10;
                label1.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("finsted");
            }
        }
    }
}
