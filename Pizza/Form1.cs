using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void UpdateSize()
        {
            UpdetTotalPrice();
            if (redSmall.Checked)
            {
                labsize2.Text = "Small";
            }
            else if (redMeduim.Checked)
            {
                labsize2.Text = "Mesuim";
            }
            else if (radLarg.Checked) {
                labsize2.Text = "Larg";
            }
        }

        void UpdetCrust()
        {
            UpdetTotalPrice();
            if (redThincrust.Checked)
                labCrust2.Text = "Thin crust";
            else
                labCrust2.Text = "Think curst";
        }

        void UpdetToppings()
        {
            UpdetTotalPrice();
            string sToppings = "";
            if (cheExtraChees.Checked)
                sToppings = "ExtraChees ";
             if (cheOnion.Checked)
                sToppings += ", Onion";
             if (cheMushrooms.Checked)
                sToppings += " , Mushrooms";
             if (cheOlives.Checked)
                sToppings +=" , Olives";
             if (cheTomatoes.Checked)
                sToppings += " , Tomatoes";
            if(cheGreenPeppers.Checked)
                sToppings += " , GreenPeppers";

            if (sToppings.StartsWith(","))
            {
                sToppings=sToppings.Substring(1,sToppings.Length-1).Trim();
            }
            if (sToppings == "")
            {
                labToppings2.Text = "No toppinds";
            }
            labToppings2.Text = sToppings;
          //  return sToppings;
        }

        void Resetfrom()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled=true;
            redtoeat.Enabled = true;


            redMeduim.Checked = true;


            cheExtraChees.Checked = false;
            cheOnion.Checked= false;
            cheOlives.Checked = false;
            cheMushrooms.Checked = false;   
            cheGreenPeppers.Checked= false;
            cheTomatoes.Checked= false;

            redThincrust.Checked = true;

            radEatIn.Checked = true;

            btnorder.Enabled = true;
        }
        void UpdetEat()
        {
            if (radEatIn.Checked)
            {
                labEat2.Text = "Eat In";
            }
            else
            {
                labEat2.Text = " Take out";
            }
        }
        float GetSelectedSizePrice()
        {
            if (redSmall.Checked)
                return Convert.ToSingle(redSmall.Tag);
            else if (redMeduim.Checked)
                return Convert.ToSingle(redMeduim.Tag);
            else
                return Convert.ToSingle(radLarg.Tag);
        }

        float GetSelectedToppingsPrice()
        {

            float TotalToppingsprice = 0;
            if (cheExtraChees.Checked)
                TotalToppingsprice += Convert.ToSingle(cheExtraChees.Tag);
             if (cheOnion.Checked)
                TotalToppingsprice += Convert.ToSingle(cheOnion.Tag);
             if (cheMushrooms.Checked)
                TotalToppingsprice += Convert.ToSingle(cheMushrooms.Tag);
             if (cheOlives.Checked)
                TotalToppingsprice += Convert.ToSingle(cheOlives.Tag);
            if (cheTomatoes.Checked)
                TotalToppingsprice += Convert.ToSingle(cheTomatoes.Tag);
            if(cheGreenPeppers.Checked)
                TotalToppingsprice += Convert.ToSingle(cheGreenPeppers.Tag);
            return TotalToppingsprice;
        }

        float GetSelctedCrustPrice()
        {
            if (redThincrust.Checked)
                return Convert.ToSingle(redThincrust.Tag);
            else
                return Convert.ToSingle(redThinkcurst.Tag);

        }

        float CalculetTotalPrice()
        {
            return GetSelectedSizePrice()+GetSelectedToppingsPrice()+
                GetSelctedCrustPrice();
        }

        void UpdetTotalPrice()
        {
           labtotal2.Text = "$" + CalculetTotalPrice().ToString();
        }
        private void redSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void redMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void radLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void redThincrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdetCrust();
        }

        private void redThinkcurst_CheckedChanged(object sender, EventArgs e)
        {
            UpdetCrust();
        }

        private void cheExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdetToppings();
        }

        private void cheOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdetToppings();
        }

        private void cheMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdetToppings();
        }

        private void cheOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdetToppings();
        }

        private void cheTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdetToppings();
        }

        private void cheGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdetToppings();
        }

        private void radEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdetEat();
        }

        private void redTakeout_CheckedChanged(object sender, EventArgs e)
        {
            UpdetEat();
        }

        private void labEat2_Click(object sender, EventArgs e)
        {

        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("confrom order", "confrom", MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                if(MessageBox.Show("order placed successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                    redtoeat.Enabled = false;
                }
               
            }
        }

        void UpdetOrderSummary()
        {
            UpdateSize();
            UpdetToppings();
            UpdetEat();
            UpdetCrust();
            UpdetTotalPrice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdetOrderSummary();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Resetfrom();

        }
    }
}
