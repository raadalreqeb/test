namespace firstprojectWinForms
{
    partial class frmMessageBox
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
            this.btnshowmass = new System.Windows.Forms.Button();
            this.btnmessagewithtitel = new System.Windows.Forms.Button();
            this.btnshowwithtitelandbutt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnshowmass
            // 
            this.btnshowmass.Location = new System.Drawing.Point(50, 41);
            this.btnshowmass.Name = "btnshowmass";
            this.btnshowmass.Size = new System.Drawing.Size(146, 66);
            this.btnshowmass.TabIndex = 0;
            this.btnshowmass.Text = "show message";
            this.btnshowmass.UseVisualStyleBackColor = true;
            this.btnshowmass.Click += new System.EventHandler(this.btnshowmass_Click);
            // 
            // btnmessagewithtitel
            // 
            this.btnmessagewithtitel.Location = new System.Drawing.Point(50, 115);
            this.btnmessagewithtitel.Name = "btnmessagewithtitel";
            this.btnmessagewithtitel.Size = new System.Drawing.Size(146, 66);
            this.btnmessagewithtitel.TabIndex = 1;
            this.btnmessagewithtitel.Text = "show message with titel";
            this.btnmessagewithtitel.UseVisualStyleBackColor = true;
            this.btnmessagewithtitel.Click += new System.EventHandler(this.btnmessagewithtitel_Click);
            // 
            // btnshowwithtitelandbutt
            // 
            this.btnshowwithtitelandbutt.Location = new System.Drawing.Point(50, 187);
            this.btnshowwithtitelandbutt.Name = "btnshowwithtitelandbutt";
            this.btnshowwithtitelandbutt.Size = new System.Drawing.Size(146, 66);
            this.btnshowwithtitelandbutt.TabIndex = 2;
            this.btnshowwithtitelandbutt.Text = "show message with titel and buttn";
            this.btnshowwithtitelandbutt.UseVisualStyleBackColor = true;
            this.btnshowwithtitelandbutt.Click += new System.EventHandler(this.btnshowwithtitelandbutt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "show message with titel and button and imege";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 66);
            this.button2.TabIndex = 4;
            this.button2.Text = "show message with titel and button and imege defulte button";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnshowwithtitelandbutt);
            this.Controls.Add(this.btnmessagewithtitel);
            this.Controls.Add(this.btnshowmass);
            this.Name = "frmMessageBox";
            this.Text = "frmMessageBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnshowmass;
        private System.Windows.Forms.Button btnmessagewithtitel;
        private System.Windows.Forms.Button btnshowwithtitelandbutt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}