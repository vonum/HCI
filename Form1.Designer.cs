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
            this.sacuvajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stablo = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.tabelaToolStripMenuItem,
            this.sacuvajToolStripMenuItem,
            this.tmpToolStripMenuItem});
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
            this.resursToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.resursToolStripMenuItem.Text = "Resurs";
            this.resursToolStripMenuItem.Click += new System.EventHandler(this.resursToolStripMenuItem_Click);
            // 
            // tipResursaToolStripMenuItem
            // 
            this.tipResursaToolStripMenuItem.Name = "tipResursaToolStripMenuItem";
            this.tipResursaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.tipResursaToolStripMenuItem.Text = "Tip resursa";
            this.tipResursaToolStripMenuItem.Click += new System.EventHandler(this.tipResursaToolStripMenuItem_Click);
            // 
            // etiketaToolStripMenuItem
            // 
            this.etiketaToolStripMenuItem.Name = "etiketaToolStripMenuItem";
            this.etiketaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
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
            this.resursiToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.resursiToolStripMenuItem.Text = "Resursi";
            this.resursiToolStripMenuItem.Click += new System.EventHandler(this.resursiToolStripMenuItem_Click);
            // 
            // tipoviResursaToolStripMenuItem
            // 
            this.tipoviResursaToolStripMenuItem.Name = "tipoviResursaToolStripMenuItem";
            this.tipoviResursaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.tipoviResursaToolStripMenuItem.Text = "Tipovi resursa";
            this.tipoviResursaToolStripMenuItem.Click += new System.EventHandler(this.tipoviResursaToolStripMenuItem_Click);
            // 
            // etiketeToolStripMenuItem
            // 
            this.etiketeToolStripMenuItem.Name = "etiketeToolStripMenuItem";
            this.etiketeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.etiketeToolStripMenuItem.Text = "Etikete";
            this.etiketeToolStripMenuItem.Click += new System.EventHandler(this.etiketeToolStripMenuItem_Click);
            // 
            // sacuvajToolStripMenuItem
            // 
            this.sacuvajToolStripMenuItem.Name = "sacuvajToolStripMenuItem";
            this.sacuvajToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.sacuvajToolStripMenuItem.Text = "Sacuvaj";
            this.sacuvajToolStripMenuItem.Click += new System.EventHandler(this.sacuvajToolStripMenuItem_Click);
            // 
            // tmpToolStripMenuItem
            // 
            this.tmpToolStripMenuItem.Name = "tmpToolStripMenuItem";
            this.tmpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.tmpToolStripMenuItem.Text = "Tmp";
            this.tmpToolStripMenuItem.Click += new System.EventHandler(this.tmpToolStripMenuItem_Click);
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
            this.imageList1.Images.SetKeyName(0, "LOL.jpg");
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackgroundImage = global::HCI_FINAL.Properties.Resources.LOL;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(118, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 609);
            this.panel1.TabIndex = 2;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
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
        private System.Windows.Forms.ToolStripMenuItem sacuvajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resursiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoviResursaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etiketeToolStripMenuItem;
        private System.Windows.Forms.TreeView stablo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem tmpToolStripMenuItem;

    }
}

