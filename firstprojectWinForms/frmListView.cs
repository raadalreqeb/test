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
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtID.Text)) || string.IsNullOrEmpty(txtname.Text)) {
                return;
            }

            ListViewItem item= new ListViewItem(txtID.Text.Trim());
            if (rdmale.Checked)
            {
                item.ImageIndex = 1;
            }
            else
            {
                item.ImageIndex=0;
            }
            item.SubItems.Add(txtname.Text.Trim());
            listView1.Items.Add(item);

            txtname.Clear();
            txtID.Clear();
            txtID.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i= 0; i<10; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());

                if (i % 2 == 0)
                {
                    item.ImageIndex = 1;
                }
                else
                {
                    item.ImageIndex = 0;
                }

                item.SubItems.Add("Persoin" + i);
                listView1.Items.Add(item);
            }
        }

        private void rdDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rdSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rdTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void rdLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rdList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
