namespace firstprojectWinForms
{
    partial class frmPictuerBox
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
            this.btnkillua = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btngon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkillua
            // 
            this.btnkillua.Location = new System.Drawing.Point(274, 343);
            this.btnkillua.Name = "btnkillua";
            this.btnkillua.Size = new System.Drawing.Size(92, 50);
            this.btnkillua.TabIndex = 1;
            this.btnkillua.Text = "killua";
            this.btnkillua.UseVisualStyleBackColor = true;
            this.btnkillua.Click += new System.EventHandler(this.btnkillua_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::firstprojectWinForms.Properties.Resources.gon;
            this.pictureBox1.Location = new System.Drawing.Point(238, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btngon
            // 
            this.btngon.Location = new System.Drawing.Point(386, 343);
            this.btngon.Name = "btngon";
            this.btngon.Size = new System.Drawing.Size(92, 50);
            this.btngon.TabIndex = 3;
            this.btngon.Text = "gon";
            this.btngon.UseVisualStyleBackColor = true;
            this.btngon.Click += new System.EventHandler(this.btngon_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "from in file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPictuerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btngon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnkillua);
            this.Name = "frmPictuerBox";
            this.Text = "frmPictuerBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnkillua;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btngon;
        private System.Windows.Forms.Button button1;
    }
}