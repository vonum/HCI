namespace HCI_FINAL
{
    partial class TutorijalTabelaTip
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
            this.table = new System.Windows.Forms.DataGridView();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oznaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izmeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackgroundColor = System.Drawing.Color.LightPink;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv,
            this.oznaka,
            this.opis,
            this.izmeni,
            this.obrisi});
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(546, 331);
            this.table.TabIndex = 1;
            this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellContentClick);
            // 
            // naziv
            // 
            this.naziv.HeaderText = "Naziv";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            // 
            // oznaka
            // 
            this.oznaka.HeaderText = "Oznaka";
            this.oznaka.Name = "oznaka";
            this.oznaka.ReadOnly = true;
            // 
            // opis
            // 
            this.opis.HeaderText = "Opis";
            this.opis.Name = "opis";
            this.opis.ReadOnly = true;
            // 
            // izmeni
            // 
            this.izmeni.HeaderText = "Izmeni";
            this.izmeni.Name = "izmeni";
            // 
            // obrisi
            // 
            this.obrisi.HeaderText = "Obrisi";
            this.obrisi.Name = "obrisi";
            // 
            // TutorijalTabelaTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(567, 353);
            this.Controls.Add(this.table);
            this.Name = "TutorijalTabelaTip";
            this.Text = "TutorijalTabelaTip";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
        private System.Windows.Forms.DataGridViewButtonColumn izmeni;
        private System.Windows.Forms.DataGridViewButtonColumn obrisi;
    }
}