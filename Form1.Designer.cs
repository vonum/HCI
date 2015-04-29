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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipResursaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etiketaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.tabelaToolStripMenuItem,
            this.pretragaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
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
            this.tabelaToolStripMenuItem.Name = "tabelaToolStripMenuItem";
            this.tabelaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tabelaToolStripMenuItem.Text = "Tabela";
            this.tabelaToolStripMenuItem.Click += new System.EventHandler(this.tabelaToolStripMenuItem_Click);
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HCI_FINAL.Properties.Resources.LOL;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 636);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;

    }
}

