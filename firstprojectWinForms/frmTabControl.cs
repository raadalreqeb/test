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
    public partial class frmTabControl : Form
    {
        public frmTabControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text)) {

                e.Cancel = true;
                txtID.Focus();
                errorProvider1.SetError(txtID, "TextID should have a value");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtID, "");
            }

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {

                e.Cancel = true;
                txtname.Focus();
                errorProvider1.SetError(txtname, "TextID should have a value");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtname, "");
            }
        }

        private void txtprice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtprice.Text))
            {

                e.Cancel = true;
                txtprice.Focus();
                errorProvider1.SetError(txtprice, "TextID should have a value");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtprice, "");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ListViewItem item = new ListViewItem(txtID.Text.Trim());

            item.SubItems.Add(txtname.Text.Trim());
            item.SubItems.Add(txtprice.Text.Trim());
            listView1.Items.Add(item);

            txtname.Clear();
            txtID.Clear();
            txtprice.Clear();
            txtID.Focus();
        }
    }
}
