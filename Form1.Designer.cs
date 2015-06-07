namespace HCI_FINAL
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Resursi");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipResursaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etiketaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resursiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoviResursaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etiketeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorijalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipResursaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.etiketaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resursToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipResursaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.etiketaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resursToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipResursaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.etiketaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stablo = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.tabelaToolStripMenuItem,
            this.tutorijalToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resursToolStripMenuItem,
            this.tipResursaToolStripMenuItem,
            this.etiketaToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // resursToolStripMenuItem
            // 
            this.resursToolStripMenuItem.Name = "resursToolStripMenuItem";
            this.resursToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resursToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.resursToolStripMenuItem.Text = "Resurs";
            this.resursToolStripMenuItem.Click += new System.EventHandler(this.resursToolStripMenuItem_Click);
            // 
            // tipResursaToolStripMenuItem
            // 
            this.tipResursaToolStripMenuItem.Name = "tipResursaToolStripMenuItem";
            this.tipResursaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tipResursaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.tipResursaToolStripMenuItem.Text = "Tip resursa";
            this.tipResursaToolStripMenuItem.Click += new System.EventHandler(this.tipResursaToolStripMenuItem_Click);
            // 
            // etiketaToolStripMenuItem
            // 
            this.etiketaToolStripMenuItem.Name = "etiketaToolStripMenuItem";
            this.etiketaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.etiketaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.etiketaToolStripMenuItem.Text = "Etiketa";
            this.etiketaToolStripMenuItem.Click += new System.EventHandler(this.etiketaToolStripMenuItem_Click);
            // 
            // tabelaToolStripMenuItem
            // 
            this.tabelaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resursiToolStripMenuItem,
            this.tipoviResursaToolStripMenuItem,
            this.etiketeToolStripMenuItem});
            this.tabelaToolStripMenuItem.Name = "tabelaToolStripMenuItem";
            this.tabelaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tabelaToolStripMenuItem.Text = "Tabela";
            this.tabelaToolStripMenuItem.Click += new System.EventHandler(this.tabelaToolStripMenuItem_Click);
            // 
            // resursiToolStripMenuItem
            // 
            this.resursiToolStripMenuItem.Name = "resursiToolStripMenuItem";
            this.resursiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.R)));
            this.resursiToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.resursiToolStripMenuItem.Text = "Resursi";
            this.resursiToolStripMenuItem.Click += new System.EventHandler(this.resursiToolStripMenuItem_Click);
            // 
            // tipoviResursaToolStripMenuItem
            // 
            this.tipoviResursaToolStripMenuItem.Name = "tipoviResursaToolStripMenuItem";
            this.tipoviResursaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.T)));
            this.tipoviResursaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.tipoviResursaToolStripMenuItem.Text = "Tipovi resursa";
            this.tipoviResursaToolStripMenuItem.Click += new System.EventHandler(this.tipoviResursaToolStripMenuItem_Click);
            // 
            // etiketeToolStripMenuItem
            // 
            this.etiketeToolStripMenuItem.Name = "etiketeToolStripMenuItem";
            this.etiketeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.E)));
            this.etiketeToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.etiketeToolStripMenuItem.Text = "Etikete";
            this.etiketeToolStripMenuItem.Click += new System.EventHandler(this.etiketeToolStripMenuItem_Click);
            // 
            // tutorijalToolStripMenuItem
            // 
            this.tutorijalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem1,
            this.izmenaToolStripMenuItem,
            this.brisanjeToolStripMenuItem});
            this.tutorijalToolStripMenuItem.Name = "tutorijalToolStripMenuItem";
            this.tutorijalToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.tutorijalToolStripMenuItem.Text = "Tutorijal";
            // 
            // dodajToolStripMenuItem1
            // 
            this.dodajToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resursToolStripMenuItem1,
            this.tipResursaToolStripMenuItem1,
            this.etiketaToolStripMenuItem1});
            this.dodajToolStripMenuItem1.Name = "dodajToolStripMenuItem1";
            this.dodajToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.dodajToolStripMenuItem1.Text = "Dodaj";
            // 
            // resursToolStripMenuItem1
            // 
            this.resursToolStripMenuItem1.Name = "resursToolStripMenuItem1";
            this.resursToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.resursToolStripMenuItem1.Text = "Resurs";
            this.resursToolStripMenuItem1.Click += new System.EventHandler(this.resursToolStripMenuItem1_Click);
            // 
            // tipResursaToolStripMenuItem1
            // 
            this.tipResursaToolStripMenuItem1.Name = "tipResursaToolStripMenuItem1";
            this.tipResursaToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.tipResursaToolStripMenuItem1.Text = "Tip resursa";
            this.tipResursaToolStripMenuItem1.Click += new System.EventHandler(this.tipResursaToolStripMenuItem1_Click);
            // 
            // etiketaToolStripMenuItem1
            // 
            this.etiketaToolStripMenuItem1.Name = "etiketaToolStripMenuItem1";
            this.etiketaToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.etiketaToolStripMenuItem1.Text = "Etiketa";
            this.etiketaToolStripMenuItem1.Click += new System.EventHandler(this.etiketaToolStripMenuItem1_Click);
            // 
            // izmenaToolStripMenuItem
            // 
            this.izmenaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resursToolStripMenuItem2,
            this.tipResursaToolStripMenuItem2,
            this.etiketaToolStripMenuItem2});
            this.izmenaToolStripMenuItem.Name = "izmenaToolStripMenuItem";
            this.izmenaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.izmenaToolStripMenuItem.Text = "Izmena";
            // 
            // resursToolStripMenuItem2
            // 
            this.resursToolStripMenuItem2.Name = "resursToolStripMenuItem2";
            this.resursToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
            this.resursToolStripMenuItem2.Text = "Resurs";
            this.resursToolStripMenuItem2.Click += new System.EventHandler(this.resursToolStripMenuItem2_Click);
            // 
            // tipResursaToolStripMenuItem2
            // 
            this.tipResursaToolStripMenuItem2.Name = "tipResursaToolStripMenuItem2";
            this.tipResursaToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
            this.tipResursaToolStripMenuItem2.Text = "Tip resursa";
            this.tipResursaToolStripMenuItem2.Click += new System.EventHandler(this.tipResursaToolStripMenuItem2_Click);
            // 
            // etiketaToolStripMenuItem2
            // 
            this.etiketaToolStripMenuItem2.Name = "etiketaToolStripMenuItem2";
            this.etiketaToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
            this.etiketaToolStripMenuItem2.Text = "Etiketa";
            this.etiketaToolStripMenuItem2.Click += new System.EventHandler(this.etiketaToolStripMenuItem2_Click);
            // 
            // brisanjeToolStripMenuItem
            // 
            this.brisanjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resursToolStripMenuItem3,
            this.tipResursaToolStripMenuItem3,
            this.etiketaToolStripMenuItem3});
            this.brisanjeToolStripMenuItem.Name = "brisanjeToolStripMenuItem";
            this.brisanjeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.brisanjeToolStripMenuItem.Text = "Brisanje";
            // 
            // resursToolStripMenuItem3
            // 
            this.resursToolStripMenuItem3.Name = "resursToolStripMenuItem3";
            this.resursToolStripMenuItem3.Size = new System.Drawing.Size(131, 22);
            this.resursToolStripMenuItem3.Text = "Resurs";
            this.resursToolStripMenuItem3.Click += new System.EventHandler(this.resursToolStripMenuItem3_Click);
            // 
            // tipResursaToolStripMenuItem3
            // 
            this.tipResursaToolStripMenuItem3.Name = "tipResursaToolStripMenuItem3";
            this.tipResursaToolStripMenuItem3.Size = new System.Drawing.Size(131, 22);
            this.tipResursaToolStripMenuItem3.Text = "Tip resursa";
            this.tipResursaToolStripMenuItem3.Click += new System.EventHandler(this.tipResursaToolStripMenuItem3_Click);
            // 
            // etiketaToolStripMenuItem3
            // 
            this.etiketaToolStripMenuItem3.Name = "etiketaToolStripMenuItem3";
            this.etiketaToolStripMenuItem3.Size = new System.Drawing.Size(131, 22);
            this.etiketaToolStripMenuItem3.Text = "Etiketa";
            this.etiketaToolStripMenuItem3.Click += new System.EventHandler(this.etiketaToolStripMenuItem3_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // stablo
            // 
            this.stablo.ImageIndex = 0;
            this.stablo.ImageList = this.imageList1;
            this.stablo.Location = new System.Drawing.Point(0, 27);
            this.stablo.Name = "stablo";
            treeNode1.Name = "resursi";
            treeNode1.Text = "Resursi";
            this.stablo.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.stablo.SelectedImageIndex = 0;
            this.stablo.Size = new System.Drawing.Size(121, 609);
            this.stablo.TabIndex = 1;
            this.stablo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stablo_MouseClick);
            this.stablo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stablo_MouseDown);
            this.stablo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.stablo_MouseMove);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "rsc.png");
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackgroundImage = global::HCI_FINAL.Properties.Resources.LOL;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(118, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 609);
            this.panel1.TabIndex = 2;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::HCI_FINAL.Properties.Resources.trash;
            this.pictureBox1.Location = new System.Drawing.Point(578, 547);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Owner\\Desktop\\hci\\HCI_FINAL\\bin\\Debug\\HelpPls.chm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stablo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipResursaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etiketaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resursiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoviResursaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etiketeToolStripMenuItem;
        private System.Windows.Forms.TreeView stablo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tutorijalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izmenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resursToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tipResursaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem etiketaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resursToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tipResursaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem etiketaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem resursToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tipResursaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem etiketaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        public System.Windows.Forms.Panel panel1;

    }
}

