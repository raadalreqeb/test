namespace firstprojectWinForms
{
    partial class frmTreeViewandImageList
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("naruto", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeViewandImageList));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 1;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(147, 23);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node6";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Text = "Node6";
            treeNode2.Name = "Node7";
            treeNode2.SelectedImageIndex = 3;
            treeNode2.Text = "Node7";
            treeNode3.Name = "Node8";
            treeNode3.SelectedImageIndex = 4;
            treeNode3.Text = "Node8";
            treeNode4.Name = "Node9";
            treeNode4.SelectedImageIndex = 5;
            treeNode4.Text = "Node9";
            treeNode5.Name = "Node0";
            treeNode5.SelectedImageIndex = 0;
            treeNode5.Text = "naruto";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Node2";
            treeNode7.Name = "Node3";
            treeNode7.Text = "Node3";
            treeNode8.Name = "Node4";
            treeNode8.Text = "Node4";
            treeNode9.Name = "Node5";
            treeNode9.Text = "Node5";
            treeNode10.Name = "Node1";
            treeNode10.SelectedImageIndex = 1;
            treeNode10.Text = "Node1";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(450, 293);
            this.treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "naruto.jpg");
            this.imageList1.Images.SetKeyName(1, "Hunter0.jpeg");
            this.imageList1.Images.SetKeyName(2, "images1.jpeg");
            this.imageList1.Images.SetKeyName(3, "images2.jpeg");
            this.imageList1.Images.SetKeyName(4, "images3.jpeg");
            this.imageList1.Images.SetKeyName(5, "images4.jpeg");
            this.imageList1.Images.SetKeyName(6, "images5.jpeg");
            this.imageList1.Images.SetKeyName(7, "images6.jpeg");
            this.imageList1.Images.SetKeyName(8, "images7.jpeg");
            this.imageList1.Images.SetKeyName(9, "images8.jpeg");
            // 
            // frmTreeViewandImageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "frmTreeViewandImageList";
            this.Text = "frmTreeViewandImageList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}