namespace HCI_FINAL
{
    partial class Tabela
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpodaci_gb = new System.Windows.Forms.GroupBox();
            this.frekv_tb = new System.Windows.Forms.TextBox();
            this.obn_tb = new System.Windows.Forms.TextBox();
            this.jm_tb = new System.Windows.Forms.TextBox();
            this.ekspl_tb = new System.Windows.Forms.TextBox();
            this.strv_tb = new System.Windows.Forms.TextBox();
            this.cena_tb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.opodaci_gb = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tip_tb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.opis_tb = new System.Windows.Forms.TextBox();
            this.naziv_tb = new System.Windows.Forms.TextBox();
            this.oznaka_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cena_pretraga = new System.Windows.Forms.TextBox();
            this.naziv_pretraga = new System.Windows.Forms.TextBox();
            this.tip_pretraga = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.dpodaci_gb.SuspendLayout();
            this.opodaci_gb.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.table.TabIndex = 0;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dpodaci_gb);
            this.groupBox1.Controls.Add(this.opodaci_gb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resurs";
            // 
            // dpodaci_gb
            // 
            this.dpodaci_gb.Controls.Add(this.frekv_tb);
            this.dpodaci_gb.Controls.Add(this.obn_tb);
            this.dpodaci_gb.Controls.Add(this.jm_tb);
            this.dpodaci_gb.Controls.Add(this.ekspl_tb);
            this.dpodaci_gb.Controls.Add(this.strv_tb);
            this.dpodaci_gb.Controls.Add(this.cena_tb);
            this.dpodaci_gb.Controls.Add(this.label11);
            this.dpodaci_gb.Controls.Add(this.label10);
            this.dpodaci_gb.Controls.Add(this.label9);
            this.dpodaci_gb.Controls.Add(this.label8);
            this.dpodaci_gb.Controls.Add(this.label7);
            this.dpodaci_gb.Controls.Add(this.label6);
            this.dpodaci_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpodaci_gb.Location = new System.Drawing.Point(294, 34);
            this.dpodaci_gb.Name = "dpodaci_gb";
            this.dpodaci_gb.Size = new System.Drawing.Size(284, 208);
            this.dpodaci_gb.TabIndex = 11;
            this.dpodaci_gb.TabStop = false;
            this.dpodaci_gb.Text = "Dodatni Podaci";
            // 
            // frekv_tb
            // 
            this.frekv_tb.Enabled = false;
            this.frekv_tb.Location = new System.Drawing.Point(150, 164);
            this.frekv_tb.Name = "frekv_tb";
            this.frekv_tb.Size = new System.Drawing.Size(107, 23);
            this.frekv_tb.TabIndex = 12;
            // 
            // obn_tb
            // 
            this.obn_tb.Enabled = false;
            this.obn_tb.Location = new System.Drawing.Point(150, 27);
            this.obn_tb.Name = "obn_tb";
            this.obn_tb.Size = new System.Drawing.Size(107, 23);
            this.obn_tb.TabIndex = 13;
            // 
            // jm_tb
            // 
            this.jm_tb.Enabled = false;
            this.jm_tb.Location = new System.Drawing.Point(150, 110);
            this.jm_tb.Name = "jm_tb";
            this.jm_tb.Size = new System.Drawing.Size(107, 23);
            this.jm_tb.TabIndex = 9;
            // 
            // ekspl_tb
            // 
            this.ekspl_tb.Enabled = false;
            this.ekspl_tb.Location = new System.Drawing.Point(150, 84);
            this.ekspl_tb.Name = "ekspl_tb";
            this.ekspl_tb.Size = new System.Drawing.Size(107, 23);
            this.ekspl_tb.TabIndex = 8;
            // 
            // strv_tb
            // 
            this.strv_tb.Enabled = false;
            this.strv_tb.Location = new System.Drawing.Point(150, 55);
            this.strv_tb.Name = "strv_tb";
            this.strv_tb.Size = new System.Drawing.Size(107, 23);
            this.strv_tb.TabIndex = 7;
            // 
            // cena_tb
            // 
            this.cena_tb.Enabled = false;
            this.cena_tb.Location = new System.Drawing.Point(150, 135);
            this.cena_tb.Name = "cena_tb";
            this.cena_tb.Size = new System.Drawing.Size(107, 23);
            this.cena_tb.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Frekvencija:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cena:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Jedinica mere:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Eksploativnost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Strateska vaznost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Obnovljivost:";
            // 
            // opodaci_gb
            // 
            this.opodaci_gb.Controls.Add(this.listView1);
            this.opodaci_gb.Controls.Add(this.tip_tb);
            this.opodaci_gb.Controls.Add(this.label15);
            this.opodaci_gb.Controls.Add(this.opis_tb);
            this.opodaci_gb.Controls.Add(this.naziv_tb);
            this.opodaci_gb.Controls.Add(this.oznaka_tb);
            this.opodaci_gb.Controls.Add(this.label3);
            this.opodaci_gb.Controls.Add(this.label1);
            this.opodaci_gb.Controls.Add(this.label4);
            this.opodaci_gb.Controls.Add(this.label2);
            this.opodaci_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opodaci_gb.Location = new System.Drawing.Point(21, 34);
            this.opodaci_gb.Name = "opodaci_gb";
            this.opodaci_gb.Size = new System.Drawing.Size(267, 208);
            this.opodaci_gb.TabIndex = 10;
            this.opodaci_gb.TabStop = false;
            this.opodaci_gb.Text = "Osnovni Podaci";
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(116, 144);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(114, 58);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // tip_tb
            // 
            this.tip_tb.Enabled = false;
            this.tip_tb.Location = new System.Drawing.Point(116, 110);
            this.tip_tb.Name = "tip_tb";
            this.tip_tb.Size = new System.Drawing.Size(114, 23);
            this.tip_tb.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Etikete:";
            // 
            // opis_tb
            // 
            this.opis_tb.Enabled = false;
            this.opis_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opis_tb.Location = new System.Drawing.Point(116, 84);
            this.opis_tb.Name = "opis_tb";
            this.opis_tb.Size = new System.Drawing.Size(114, 20);
            this.opis_tb.TabIndex = 9;
            // 
            // naziv_tb
            // 
            this.naziv_tb.Enabled = false;
            this.naziv_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naziv_tb.Location = new System.Drawing.Point(116, 58);
            this.naziv_tb.Name = "naziv_tb";
            this.naziv_tb.Size = new System.Drawing.Size(113, 20);
            this.naziv_tb.TabIndex = 8;
            // 
            // oznaka_tb
            // 
            this.oznaka_tb.Enabled = false;
            this.oznaka_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oznaka_tb.Location = new System.Drawing.Point(116, 32);
            this.oznaka_tb.Name = "oznaka_tb";
            this.oznaka_tb.Size = new System.Drawing.Size(114, 20);
            this.oznaka_tb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Oznaka:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.cena_pretraga);
            this.groupBox2.Controls.Add(this.naziv_pretraga);
            this.groupBox2.Controls.Add(this.tip_pretraga);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(617, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 270);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(87, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cena_pretraga
            // 
            this.cena_pretraga.Location = new System.Drawing.Point(121, 108);
            this.cena_pretraga.Name = "cena_pretraga";
            this.cena_pretraga.Size = new System.Drawing.Size(100, 20);
            this.cena_pretraga.TabIndex = 6;
            // 
            // naziv_pretraga
            // 
            this.naziv_pretraga.Location = new System.Drawing.Point(121, 83);
            this.naziv_pretraga.Name = "naziv_pretraga";
            this.naziv_pretraga.Size = new System.Drawing.Size(100, 20);
            this.naziv_pretraga.TabIndex = 5;
            // 
            // tip_pretraga
            // 
            this.tip_pretraga.Location = new System.Drawing.Point(121, 57);
            this.tip_pretraga.Name = "tip_pretraga";
            this.tip_pretraga.Size = new System.Drawing.Size(100, 20);
            this.tip_pretraga.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Cena(<=):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Naziv:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Tip resursa:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pretraga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(864, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.table);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Tabela";
            this.Text = "Resursi";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.dpodaci_gb.ResumeLayout(false);
            this.dpodaci_gb.PerformLayout();
            this.opodaci_gb.ResumeLayout(false);
            this.opodaci_gb.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox dpodaci_gb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox opodaci_gb;
        private System.Windows.Forms.TextBox opis_tb;
        private System.Windows.Forms.TextBox naziv_tb;
        private System.Windows.Forms.TextBox oznaka_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cena_pretraga;
        private System.Windows.Forms.TextBox naziv_pretraga;
        private System.Windows.Forms.TextBox tip_pretraga;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznaka_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn obn_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn jm_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena_c;
        private System.Windows.Forms.DataGridViewButtonColumn izmeni_c;
        private System.Windows.Forms.DataGridViewButtonColumn obrisi_c;
        private System.Windows.Forms.TextBox frekv_tb;
        private System.Windows.Forms.TextBox obn_tb;
        private System.Windows.Forms.TextBox jm_tb;
        private System.Windows.Forms.TextBox ekspl_tb;
        private System.Windows.Forms.TextBox strv_tb;
        private System.Windows.Forms.TextBox cena_tb;
        private System.Windows.Forms.TextBox tip_tb;
        private System.Windows.Forms.ListView listView1;
    }
}