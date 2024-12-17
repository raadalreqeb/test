namespace Pizza
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radLarg = new System.Windows.Forms.RadioButton();
            this.redMeduim = new System.Windows.Forms.RadioButton();
            this.redSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.redThinkcurst = new System.Windows.Forms.RadioButton();
            this.redThincrust = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cheTomatoes = new System.Windows.Forms.CheckBox();
            this.cheMushrooms = new System.Windows.Forms.CheckBox();
            this.cheGreenPeppers = new System.Windows.Forms.CheckBox();
            this.cheExtraChees = new System.Windows.Forms.CheckBox();
            this.cheOnion = new System.Windows.Forms.CheckBox();
            this.cheOlives = new System.Windows.Forms.CheckBox();
            this.redtoeat = new System.Windows.Forms.GroupBox();
            this.redTakeout = new System.Windows.Forms.RadioButton();
            this.radEatIn = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labtotal2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labEat2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labCrust2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labToppings2 = new System.Windows.Forms.Label();
            this.labToppibgs = new System.Windows.Forms.Label();
            this.labsize2 = new System.Windows.Forms.Label();
            this.labSize = new System.Windows.Forms.Label();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.redtoeat.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radLarg);
            this.groupBox1.Controls.Add(this.redMeduim);
            this.groupBox1.Controls.Add(this.redSmall);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 161);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Size";
            // 
            // radLarg
            // 
            this.radLarg.AutoSize = true;
            this.radLarg.Font = new System.Drawing.Font("Tahoma", 9F);
            this.radLarg.Location = new System.Drawing.Point(6, 114);
            this.radLarg.Name = "radLarg";
            this.radLarg.Size = new System.Drawing.Size(48, 18);
            this.radLarg.TabIndex = 5;
            this.radLarg.TabStop = true;
            this.radLarg.Tag = "30";
            this.radLarg.Text = "Larg";
            this.radLarg.UseVisualStyleBackColor = true;
            this.radLarg.CheckedChanged += new System.EventHandler(this.radLarg_CheckedChanged);
            // 
            // redMeduim
            // 
            this.redMeduim.AutoSize = true;
            this.redMeduim.Font = new System.Drawing.Font("Tahoma", 9F);
            this.redMeduim.Location = new System.Drawing.Point(6, 72);
            this.redMeduim.Name = "redMeduim";
            this.redMeduim.Size = new System.Drawing.Size(67, 18);
            this.redMeduim.TabIndex = 4;
            this.redMeduim.TabStop = true;
            this.redMeduim.Tag = "25";
            this.redMeduim.Text = "Meduim";
            this.redMeduim.UseVisualStyleBackColor = true;
            this.redMeduim.CheckedChanged += new System.EventHandler(this.redMeduim_CheckedChanged);
            // 
            // redSmall
            // 
            this.redSmall.AutoSize = true;
            this.redSmall.Font = new System.Drawing.Font("Tahoma", 9F);
            this.redSmall.Location = new System.Drawing.Point(6, 36);
            this.redSmall.Name = "redSmall";
            this.redSmall.Size = new System.Drawing.Size(52, 18);
            this.redSmall.TabIndex = 3;
            this.redSmall.TabStop = true;
            this.redSmall.Tag = "20";
            this.redSmall.Text = "Small";
            this.redSmall.UseVisualStyleBackColor = true;
            this.redSmall.CheckedChanged += new System.EventHandler(this.redSmall_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.redThinkcurst);
            this.groupBox2.Controls.Add(this.redThincrust);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox2.Location = new System.Drawing.Point(12, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 125);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crust Type";
            // 
            // redThinkcurst
            // 
            this.redThinkcurst.AutoSize = true;
            this.redThinkcurst.Font = new System.Drawing.Font("Tahoma", 9F);
            this.redThinkcurst.Location = new System.Drawing.Point(6, 81);
            this.redThinkcurst.Name = "redThinkcurst";
            this.redThinkcurst.Size = new System.Drawing.Size(87, 18);
            this.redThinkcurst.TabIndex = 7;
            this.redThinkcurst.TabStop = true;
            this.redThinkcurst.Tag = "5";
            this.redThinkcurst.Text = "Think Crust";
            this.redThinkcurst.UseVisualStyleBackColor = true;
            this.redThinkcurst.CheckedChanged += new System.EventHandler(this.redThinkcurst_CheckedChanged);
            // 
            // redThincrust
            // 
            this.redThincrust.AutoSize = true;
            this.redThincrust.Font = new System.Drawing.Font("Tahoma", 9F);
            this.redThincrust.Location = new System.Drawing.Point(6, 39);
            this.redThincrust.Name = "redThincrust";
            this.redThincrust.Size = new System.Drawing.Size(81, 18);
            this.redThincrust.TabIndex = 6;
            this.redThincrust.TabStop = true;
            this.redThincrust.Tag = "0";
            this.redThincrust.Text = "Thin Crust";
            this.redThincrust.UseVisualStyleBackColor = true;
            this.redThincrust.CheckedChanged += new System.EventHandler(this.redThincrust_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cheTomatoes);
            this.groupBox3.Controls.Add(this.cheMushrooms);
            this.groupBox3.Controls.Add(this.cheGreenPeppers);
            this.groupBox3.Controls.Add(this.cheExtraChees);
            this.groupBox3.Controls.Add(this.cheOnion);
            this.groupBox3.Controls.Add(this.cheOlives);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(290, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 161);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toppings";
            // 
            // cheTomatoes
            // 
            this.cheTomatoes.AutoSize = true;
            this.cheTomatoes.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cheTomatoes.Location = new System.Drawing.Point(6, 111);
            this.cheTomatoes.Name = "cheTomatoes";
            this.cheTomatoes.Size = new System.Drawing.Size(81, 18);
            this.cheTomatoes.TabIndex = 10;
            this.cheTomatoes.Tag = "5";
            this.cheTomatoes.Text = "Tomatoes";
            this.cheTomatoes.UseVisualStyleBackColor = true;
            this.cheTomatoes.CheckedChanged += new System.EventHandler(this.cheTomatoes_CheckedChanged);
            // 
            // cheMushrooms
            // 
            this.cheMushrooms.AutoSize = true;
            this.cheMushrooms.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cheMushrooms.Location = new System.Drawing.Point(6, 72);
            this.cheMushrooms.Name = "cheMushrooms";
            this.cheMushrooms.Size = new System.Drawing.Size(87, 18);
            this.cheMushrooms.TabIndex = 8;
            this.cheMushrooms.Tag = "5";
            this.cheMushrooms.Text = "Mushrooms";
            this.cheMushrooms.UseVisualStyleBackColor = true;
            this.cheMushrooms.CheckedChanged += new System.EventHandler(this.cheMushrooms_CheckedChanged);
            // 
            // cheGreenPeppers
            // 
            this.cheGreenPeppers.AutoSize = true;
            this.cheGreenPeppers.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cheGreenPeppers.Location = new System.Drawing.Point(117, 111);
            this.cheGreenPeppers.Name = "cheGreenPeppers";
            this.cheGreenPeppers.Size = new System.Drawing.Size(107, 18);
            this.cheGreenPeppers.TabIndex = 11;
            this.cheGreenPeppers.Tag = "5";
            this.cheGreenPeppers.Text = "Green Peppers";
            this.cheGreenPeppers.UseVisualStyleBackColor = true;
            this.cheGreenPeppers.CheckedChanged += new System.EventHandler(this.cheGreenPeppers_CheckedChanged);
            // 
            // cheExtraChees
            // 
            this.cheExtraChees.AutoSize = true;
            this.cheExtraChees.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cheExtraChees.Location = new System.Drawing.Point(6, 33);
            this.cheExtraChees.Name = "cheExtraChees";
            this.cheExtraChees.Size = new System.Drawing.Size(91, 18);
            this.cheExtraChees.TabIndex = 0;
            this.cheExtraChees.Tag = "5";
            this.cheExtraChees.Text = "Extra Chees";
            this.cheExtraChees.UseVisualStyleBackColor = true;
            this.cheExtraChees.CheckedChanged += new System.EventHandler(this.cheExtraChees_CheckedChanged);
            // 
            // cheOnion
            // 
            this.cheOnion.AutoSize = true;
            this.cheOnion.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cheOnion.Location = new System.Drawing.Point(117, 31);
            this.cheOnion.Name = "cheOnion";
            this.cheOnion.Size = new System.Drawing.Size(58, 18);
            this.cheOnion.TabIndex = 7;
            this.cheOnion.Tag = "5";
            this.cheOnion.Text = "Onion";
            this.cheOnion.UseVisualStyleBackColor = true;
            this.cheOnion.CheckedChanged += new System.EventHandler(this.cheOnion_CheckedChanged);
            // 
            // cheOlives
            // 
            this.cheOlives.AutoSize = true;
            this.cheOlives.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cheOlives.Location = new System.Drawing.Point(117, 71);
            this.cheOlives.Name = "cheOlives";
            this.cheOlives.Size = new System.Drawing.Size(57, 18);
            this.cheOlives.TabIndex = 9;
            this.cheOlives.Tag = "5";
            this.cheOlives.Text = "Olives";
            this.cheOlives.UseVisualStyleBackColor = true;
            this.cheOlives.CheckedChanged += new System.EventHandler(this.cheOlives_CheckedChanged);
            // 
            // redtoeat
            // 
            this.redtoeat.Controls.Add(this.redTakeout);
            this.redtoeat.Controls.Add(this.radEatIn);
            this.redtoeat.Font = new System.Drawing.Font("Tahoma", 10F);
            this.redtoeat.Location = new System.Drawing.Point(282, 294);
            this.redtoeat.Name = "redtoeat";
            this.redtoeat.Size = new System.Drawing.Size(232, 100);
            this.redtoeat.TabIndex = 7;
            this.redtoeat.TabStop = false;
            this.redtoeat.Text = "Where To Eat";
            // 
            // redTakeout
            // 
            this.redTakeout.AutoSize = true;
            this.redTakeout.Font = new System.Drawing.Font("Tahoma", 8F);
            this.redTakeout.Location = new System.Drawing.Point(127, 61);
            this.redTakeout.Name = "redTakeout";
            this.redTakeout.Size = new System.Drawing.Size(67, 17);
            this.redTakeout.TabIndex = 8;
            this.redTakeout.TabStop = true;
            this.redTakeout.Text = "Take out";
            this.redTakeout.UseVisualStyleBackColor = true;
            this.redTakeout.CheckedChanged += new System.EventHandler(this.redTakeout_CheckedChanged);
            // 
            // radEatIn
            // 
            this.radEatIn.AutoSize = true;
            this.radEatIn.Font = new System.Drawing.Font("Tahoma", 8F);
            this.radEatIn.Location = new System.Drawing.Point(6, 61);
            this.radEatIn.Name = "radEatIn";
            this.radEatIn.Size = new System.Drawing.Size(54, 17);
            this.radEatIn.TabIndex = 0;
            this.radEatIn.TabStop = true;
            this.radEatIn.Text = "Eat In";
            this.radEatIn.UseVisualStyleBackColor = true;
            this.radEatIn.CheckedChanged += new System.EventHandler(this.radEatIn_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labtotal2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.labEat2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.labCrust2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.labToppings2);
            this.groupBox4.Controls.Add(this.labToppibgs);
            this.groupBox4.Controls.Add(this.labsize2);
            this.groupBox4.Controls.Add(this.labSize);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(592, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 352);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order Summery";
            // 
            // labtotal2
            // 
            this.labtotal2.AutoSize = true;
            this.labtotal2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labtotal2.Font = new System.Drawing.Font("Imprint MT Shadow", 15F);
            this.labtotal2.ForeColor = System.Drawing.Color.Green;
            this.labtotal2.Location = new System.Drawing.Point(106, 312);
            this.labtotal2.Name = "labtotal2";
            this.labtotal2.Size = new System.Drawing.Size(0, 24);
            this.labtotal2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Price:";
            // 
            // labEat2
            // 
            this.labEat2.AutoSize = true;
            this.labEat2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labEat2.Location = new System.Drawing.Point(106, 243);
            this.labEat2.Name = "labEat2";
            this.labEat2.Size = new System.Drawing.Size(0, 14);
            this.labEat2.TabIndex = 7;
            this.labEat2.Click += new System.EventHandler(this.labEat2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wher to Eat :";
            // 
            // labCrust2
            // 
            this.labCrust2.AutoSize = true;
            this.labCrust2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labCrust2.Location = new System.Drawing.Point(95, 170);
            this.labCrust2.Name = "labCrust2";
            this.labCrust2.Size = new System.Drawing.Size(77, 14);
            this.labCrust2.TabIndex = 5;
            this.labCrust2.Text = "Crust Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Crust Type:";
            // 
            // labToppings2
            // 
            this.labToppings2.AutoSize = true;
            this.labToppings2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labToppings2.Location = new System.Drawing.Point(23, 99);
            this.labToppings2.Name = "labToppings2";
            this.labToppings2.Size = new System.Drawing.Size(0, 14);
            this.labToppings2.TabIndex = 3;
            // 
            // labToppibgs
            // 
            this.labToppibgs.AutoSize = true;
            this.labToppibgs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labToppibgs.Location = new System.Drawing.Point(23, 70);
            this.labToppibgs.Name = "labToppibgs";
            this.labToppibgs.Size = new System.Drawing.Size(71, 14);
            this.labToppibgs.TabIndex = 2;
            this.labToppibgs.Text = "Toppings :";
            // 
            // labsize2
            // 
            this.labsize2.AutoSize = true;
            this.labsize2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labsize2.Location = new System.Drawing.Point(68, 34);
            this.labsize2.Name = "labsize2";
            this.labsize2.Size = new System.Drawing.Size(0, 13);
            this.labsize2.TabIndex = 1;
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labSize.Location = new System.Drawing.Point(23, 34);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(39, 14);
            this.labSize.TabIndex = 0;
            this.labSize.Text = "Size :";
            // 
            // btnorder
            // 
            this.btnorder.Location = new System.Drawing.Point(290, 424);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(75, 46);
            this.btnorder.TabIndex = 9;
            this.btnorder.Text = "order pizza";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(409, 424);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 46);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset Order";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 492);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.redtoeat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.redtoeat.ResumeLayout(false);
            this.redtoeat.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radLarg;
        private System.Windows.Forms.RadioButton redMeduim;
        private System.Windows.Forms.RadioButton redSmall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton redThinkcurst;
        private System.Windows.Forms.RadioButton redThincrust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cheExtraChees;
        private System.Windows.Forms.CheckBox cheOnion;
        private System.Windows.Forms.CheckBox cheMushrooms;
        private System.Windows.Forms.CheckBox cheOlives;
        private System.Windows.Forms.CheckBox cheTomatoes;
        private System.Windows.Forms.CheckBox cheGreenPeppers;
        private System.Windows.Forms.GroupBox redtoeat;
        private System.Windows.Forms.RadioButton redTakeout;
        private System.Windows.Forms.RadioButton radEatIn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labsize2;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Label labToppings2;
        private System.Windows.Forms.Label labToppibgs;
        private System.Windows.Forms.Label labEat2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labCrust2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labtotal2;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnReset;
    }
}

