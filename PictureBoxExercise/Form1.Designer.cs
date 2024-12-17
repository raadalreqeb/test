namespace PictureBoxExercise
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radboy = new System.Windows.Forms.RadioButton();
            this.radgirl = new System.Windows.Forms.RadioButton();
            this.radbook = new System.Windows.Forms.RadioButton();
            this.radpen = new System.Windows.Forms.RadioButton();
            this.labtitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PictureBoxExercise.Properties.Resources.download_removebg_preview__1_;
            this.pictureBox1.Location = new System.Drawing.Point(264, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // radboy
            // 
            this.radboy.AutoSize = true;
            this.radboy.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.radboy.Location = new System.Drawing.Point(264, 330);
            this.radboy.Name = "radboy";
            this.radboy.Size = new System.Drawing.Size(53, 21);
            this.radboy.TabIndex = 1;
            this.radboy.TabStop = true;
            this.radboy.Text = "Boy";
            this.radboy.UseVisualStyleBackColor = true;
            this.radboy.CheckedChanged += new System.EventHandler(this.radboy_CheckedChanged);
            // 
            // radgirl
            // 
            this.radgirl.AutoSize = true;
            this.radgirl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.radgirl.Location = new System.Drawing.Point(345, 330);
            this.radgirl.Name = "radgirl";
            this.radgirl.Size = new System.Drawing.Size(48, 21);
            this.radgirl.TabIndex = 2;
            this.radgirl.TabStop = true;
            this.radgirl.Text = "Girl";
            this.radgirl.UseVisualStyleBackColor = true;
            this.radgirl.CheckedChanged += new System.EventHandler(this.radgirl_CheckedChanged);
            // 
            // radbook
            // 
            this.radbook.AutoSize = true;
            this.radbook.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.radbook.Location = new System.Drawing.Point(417, 330);
            this.radbook.Name = "radbook";
            this.radbook.Size = new System.Drawing.Size(62, 21);
            this.radbook.TabIndex = 3;
            this.radbook.TabStop = true;
            this.radbook.Text = "Book";
            this.radbook.UseVisualStyleBackColor = true;
            this.radbook.CheckedChanged += new System.EventHandler(this.radbook_CheckedChanged);
            // 
            // radpen
            // 
            this.radpen.AutoSize = true;
            this.radpen.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.radpen.Location = new System.Drawing.Point(509, 330);
            this.radpen.Name = "radpen";
            this.radpen.Size = new System.Drawing.Size(52, 21);
            this.radpen.TabIndex = 4;
            this.radpen.TabStop = true;
            this.radpen.Text = "Pen";
            this.radpen.UseVisualStyleBackColor = true;
            this.radpen.CheckedChanged += new System.EventHandler(this.radpen_CheckedChanged);
            // 
            // labtitle
            // 
            this.labtitle.AutoSize = true;
            this.labtitle.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labtitle.Location = new System.Drawing.Point(375, 27);
            this.labtitle.Name = "labtitle";
            this.labtitle.Size = new System.Drawing.Size(73, 34);
            this.labtitle.TabIndex = 5;
            this.labtitle.Text = "TITLE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labtitle);
            this.Controls.Add(this.radpen);
            this.Controls.Add(this.radbook);
            this.Controls.Add(this.radgirl);
            this.Controls.Add(this.radboy);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radboy;
        private System.Windows.Forms.RadioButton radgirl;
        private System.Windows.Forms.RadioButton radbook;
        private System.Windows.Forms.RadioButton radpen;
        private System.Windows.Forms.Label labtitle;
    }
}

