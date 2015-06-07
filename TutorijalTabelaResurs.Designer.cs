namespace HCI_FINAL
{
    partial class TutorijalTabelaResurs
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
            this.naziv_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oznaka_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obn_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jm_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izmeni_c = new System.Windows.Forms.DataGridViewButtonColumn();
            this.obrisi_c = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackgroundColor = System.Drawing.Color.LightPink;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv_c,
            this.oznaka_c,
            this.obn_c,
            this.sv_c,
            this.jm_c,
            this.cena_c,
            this.izmeni_c,
            this.obrisi_c});
            this.table.GridColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(843, 278);
            this.table.TabIndex = 1;
            this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellContentClick);
            // 
            // naziv_c
            // 
            this.naziv_c.HeaderText = "Naziv";
            this.naziv_c.Name = "naziv_c";
            this.naziv_c.ReadOnly = true;
            // 
            // oznaka_c
            // 
            this.oznaka_c.HeaderText = "Oznaka";
            this.oznaka_c.Name = "oznaka_c";
            this.oznaka_c.ReadOnly = true;
            // 
            // obn_c
            // 
            this.obn_c.HeaderText = "Tip";
            this.obn_c.Name = "obn_c";
            this.obn_c.ReadOnly = true;
            this.obn_c.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.obn_c.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sv_c
            // 
            this.sv_c.HeaderText = "Frekvencija";
            this.sv_c.Name = "sv_c";
            this.sv_c.ReadOnly = true;
            this.sv_c.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sv_c.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // jm_c
            // 
            this.jm_c.HeaderText = "Obnovljivost";
            this.jm_c.Name = "jm_c";
            this.jm_c.ReadOnly = true;
            this.jm_c.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.jm_c.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cena_c
            // 
            this.cena_c.HeaderText = "Cena";
            this.cena_c.Name = "cena_c";
            this.cena_c.ReadOnly = true;
            // 
            // izmeni_c
            // 
            this.izmeni_c.HeaderText = "Izmeni";
            this.izmeni_c.Name = "izmeni_c";
            this.izmeni_c.ReadOnly = true;
            // 
            // obrisi_c
            // 
            this.obrisi_c.HeaderText = "Obrisi";
            this.obrisi_c.Name = "obrisi_c";
            this.obrisi_c.ReadOnly = true;
            // 
            // TutorijalTabelaResurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(868, 302);
            this.Controls.Add(this.table);
            this.Name = "TutorijalTabelaResurs";
            this.Text = "TutorijalTabelaResurs";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznaka_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn obn_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn jm_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena_c;
        private System.Windows.Forms.DataGridViewButtonColumn izmeni_c;
        private System.Windows.Forms.DataGridViewButtonColumn obrisi_c;
    }
}