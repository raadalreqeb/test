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
    public partial class frmdraw : Form
    {
        public frmdraw()
        {
            InitializeComponent();
        }

        private void frmdraw_Paint(object sender, PaintEventArgs e)
        {
            Color red = Color.FromArgb(255, 0, 0);
            Pen Pen = new Pen(red);
            Pen.Width = 10;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.AnchorMask;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(Pen, 100, 100, 100, 200);
            e.Graphics.DrawRectangle(Pen, 200, 200, 300, 300);
            e.Graphics.DrawEllipse(Pen, 200, 50, 200, 120);
        }
    }
}
