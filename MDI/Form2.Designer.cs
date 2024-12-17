namespace MDI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tsmchangecolor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmchangefont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmclaer = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmchangecolor,
            this.tsmchangefont,
            this.tsmclaer});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // tsmchangecolor
            // 
            this.tsmchangecolor.Name = "tsmchangecolor";
            this.tsmchangecolor.Size = new System.Drawing.Size(180, 22);
            this.tsmchangecolor.Text = "change color";
            this.tsmchangecolor.Click += new System.EventHandler(this.tsmchangecolor_Click);
            // 
            // tsmchangefont
            // 
            this.tsmchangefont.Name = "tsmchangefont";
            this.tsmchangefont.Size = new System.Drawing.Size(180, 22);
            this.tsmchangefont.Text = "change font";
            this.tsmchangefont.Click += new System.EventHandler(this.tsmchangefont_Click);
            // 
            // tsmclaer
            // 
            this.tsmclaer.Name = "tsmclaer";
            this.tsmclaer.Size = new System.Drawing.Size(180, 22);
            this.tsmclaer.Text = "claer";
            this.tsmclaer.Click += new System.EventHandler(this.tsmclaer_Click);
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Location = new System.Drawing.Point(278, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmchangecolor;
        private System.Windows.Forms.ToolStripMenuItem tsmchangefont;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem tsmclaer;
        private System.Windows.Forms.TextBox textBox1;
    }
}