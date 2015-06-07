namespace HCI_FINAL
{
    partial class Tutorijal
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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Resurs1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Resurs2");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("resursi", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutorijal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodaj = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajresurs = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajtip = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajetiketu = new System.Windows.Forms.ToolStripMenuItem();
            this.tabela = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaresursi = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelatipovi = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaetikete = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodaj,
            this.tabela,
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodaj
            // 
            this.dodaj.BackColor = System.Drawing.Color.White;
            this.dodaj.Checked = true;
            this.dodaj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dodaj.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajresurs,
            this.dodajtip,
            this.dodajetiketu});
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(50, 20);
            this.dodaj.Text = "Dodaj";
            // 
            // dodajresurs
            // 
            this.dodajresurs.Name = "dodajresurs";
            this.dodajresurs.Size = new System.Drawing.Size(131, 22);
            this.dodajresurs.Text = "Resurs";
            this.dodajresurs.Click += new System.EventHandler(this.resursToolStripMenuItem_Click);
            // 
            // dodajtip
            // 
            this.dodajtip.Name = "dodajtip";
            this.dodajtip.Size = new System.Drawing.Size(131, 22);
            this.dodajtip.Text = "Tip resursa";
            this.dodajtip.Click += new System.EventHandler(this.tipResursaToolStripMenuItem_Click);
            // 
            // dodajetiketu
            // 
            this.dodajetiketu.Name = "dodajetiketu";
            this.dodajetiketu.Size = new System.Drawing.Size(131, 22);
            this.dodajetiketu.Text = "Etiketa";
            this.dodajetiketu.Click += new System.EventHandler(this.etiketaToolStripMenuItem_Click);
            // 
            // tabela
            // 
            this.tabela.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaresursi,
            this.tabelatipovi,
            this.tabelaetikete});
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(54, 20);
            this.tabela.Text = "Tabela";
            // 
            // tabelaresursi
            // 
            this.tabelaresursi.Name = "tabelaresursi";
            this.tabelaresursi.Size = new System.Drawing.Size(152, 22);
            this.tabelaresursi.Text = "Resursi";
            this.tabelaresursi.Click += new System.EventHandler(this.tabelaresursi_Click);
            // 
            // tabelatipovi
            // 
            this.tabelatipovi.Name = "tabelatipovi";
            this.tabelatipovi.Size = new System.Drawing.Size(152, 22);
            this.tabelatipovi.Text = "Tipovi resursa";
            this.tabelatipovi.Click += new System.EventHandler(this.tabelatipovi_Click);
            // 
            // tabelaetikete
            // 
            this.tabelaetikete.Name = "tabelaetikete";
            this.tabelaetikete.Size = new System.Drawing.Size(152, 22);
            this.tabelaetikete.Text = "Etikete";
            this.tabelaetikete.Click += new System.EventHandler(this.tabelaetikete_Click);
            // 
            // help
            // 
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(44, 20);
            this.help.Text = "Help";
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 27);
            this.treeView1.Name = "treeView1";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "Node1";
            treeNode4.Text = "Resurs1";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "name2";
            treeNode5.Text = "Resurs2";
            treeNode6.Name = "Node0";
            treeNode6.Text = "resursi";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(121, 382);
            this.treeView1.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "rsc.png");
            this.imageList1.Images.SetKeyName(1, "image.png");
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HCI_FINAL.Properties.Resources.LOL;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(118, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 382);
            this.panel1.TabIndex = 2;
            // 
            // Tutorijal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 409);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tutorijal";
            this.Text = "Tutorijal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodaj;
        private System.Windows.Forms.ToolStripMenuItem dodajresurs;
        private System.Windows.Forms.ToolStripMenuItem dodajtip;
        private System.Windows.Forms.ToolStripMenuItem dodajetiketu;
        private System.Windows.Forms.ToolStripMenuItem tabela;
        private System.Windows.Forms.ToolStripMenuItem tabelaresursi;
        private System.Windows.Forms.ToolStripMenuItem tabelatipovi;
        private System.Windows.Forms.ToolStripMenuItem tabelaetikete;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
    }
}