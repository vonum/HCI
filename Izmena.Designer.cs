namespace HCI_FINAL
{
    partial class Izmena
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dpodaci_gb = new System.Windows.Forms.GroupBox();
            this.cena_tb = new System.Windows.Forms.TextBox();
            this.frekv_cb = new System.Windows.Forms.ComboBox();
            this.jm_cb = new System.Windows.Forms.ComboBox();
            this.ekspl_cb = new System.Windows.Forms.ComboBox();
            this.strv_cb = new System.Windows.Forms.ComboBox();
            this.obn_cb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.opodaci_gb = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tip_cb = new System.Windows.Forms.ComboBox();
            this.opis_tb = new System.Windows.Forms.TextBox();
            this.naziv_tb = new System.Windows.Forms.TextBox();
            this.oznaka_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.dpodaci_gb.SuspendLayout();
            this.opodaci_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 63);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Izmeni";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(135, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Povratak";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dpodaci_gb
            // 
            this.dpodaci_gb.Controls.Add(this.cena_tb);
            this.dpodaci_gb.Controls.Add(this.frekv_cb);
            this.dpodaci_gb.Controls.Add(this.jm_cb);
            this.dpodaci_gb.Controls.Add(this.ekspl_cb);
            this.dpodaci_gb.Controls.Add(this.strv_cb);
            this.dpodaci_gb.Controls.Add(this.obn_cb);
            this.dpodaci_gb.Controls.Add(this.label11);
            this.dpodaci_gb.Controls.Add(this.label10);
            this.dpodaci_gb.Controls.Add(this.label9);
            this.dpodaci_gb.Controls.Add(this.label8);
            this.dpodaci_gb.Controls.Add(this.label7);
            this.dpodaci_gb.Controls.Add(this.label6);
            this.dpodaci_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpodaci_gb.Location = new System.Drawing.Point(285, 12);
            this.dpodaci_gb.Name = "dpodaci_gb";
            this.dpodaci_gb.Size = new System.Drawing.Size(284, 208);
            this.dpodaci_gb.TabIndex = 11;
            this.dpodaci_gb.TabStop = false;
            this.dpodaci_gb.Text = "Dodatni Podaci";
            // 
            // cena_tb
            // 
            this.cena_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cena_tb.Location = new System.Drawing.Point(158, 132);
            this.cena_tb.Name = "cena_tb";
            this.cena_tb.Size = new System.Drawing.Size(89, 20);
            this.cena_tb.TabIndex = 12;
            this.cena_tb.Validating += new System.ComponentModel.CancelEventHandler(this.cena_tb_Validating);
            // 
            // frekv_cb
            // 
            this.frekv_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frekv_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frekv_cb.FormattingEnabled = true;
            this.frekv_cb.Items.AddRange(new object[] {
            "Cest",
            "Redak",
            "Univerzalan"});
            this.frekv_cb.Location = new System.Drawing.Point(158, 159);
            this.frekv_cb.Name = "frekv_cb";
            this.frekv_cb.Size = new System.Drawing.Size(89, 21);
            this.frekv_cb.TabIndex = 11;
            this.frekv_cb.Validating += new System.ComponentModel.CancelEventHandler(this.frekv_cb_Validating);
            // 
            // jm_cb
            // 
            this.jm_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jm_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jm_cb.FormattingEnabled = true;
            this.jm_cb.Items.AddRange(new object[] {
            "Merica",
            "Barel",
            "Tona",
            "Kilogram"});
            this.jm_cb.Location = new System.Drawing.Point(158, 105);
            this.jm_cb.Name = "jm_cb";
            this.jm_cb.Size = new System.Drawing.Size(89, 21);
            this.jm_cb.TabIndex = 9;
            this.jm_cb.Validating += new System.ComponentModel.CancelEventHandler(this.jm_cb_Validating);
            // 
            // ekspl_cb
            // 
            this.ekspl_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ekspl_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekspl_cb.FormattingEnabled = true;
            this.ekspl_cb.Items.AddRange(new object[] {
            "Eksploativ\t",
            "Neeksploativ"});
            this.ekspl_cb.Location = new System.Drawing.Point(158, 78);
            this.ekspl_cb.Name = "ekspl_cb";
            this.ekspl_cb.Size = new System.Drawing.Size(89, 21);
            this.ekspl_cb.TabIndex = 8;
            this.ekspl_cb.Validating += new System.ComponentModel.CancelEventHandler(this.ekspl_cb_Validating);
            // 
            // strv_cb
            // 
            this.strv_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.strv_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strv_cb.FormattingEnabled = true;
            this.strv_cb.Items.AddRange(new object[] {
            "Bitan",
            "Nebitan"});
            this.strv_cb.Location = new System.Drawing.Point(158, 51);
            this.strv_cb.Name = "strv_cb";
            this.strv_cb.Size = new System.Drawing.Size(89, 21);
            this.strv_cb.TabIndex = 7;
            this.strv_cb.Validating += new System.ComponentModel.CancelEventHandler(this.strv_cb_Validating);
            // 
            // obn_cb
            // 
            this.obn_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.obn_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obn_cb.FormattingEnabled = true;
            this.obn_cb.Items.AddRange(new object[] {
            "Obnovljiv",
            "Neobnovljiv"});
            this.obn_cb.Location = new System.Drawing.Point(158, 24);
            this.obn_cb.Name = "obn_cb";
            this.obn_cb.Size = new System.Drawing.Size(89, 21);
            this.obn_cb.TabIndex = 6;
            this.obn_cb.Validating += new System.ComponentModel.CancelEventHandler(this.obn_cb_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Frekvencija:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cena:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Jedinica mere:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Eksploativnost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 58);
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
            this.opodaci_gb.Controls.Add(this.label12);
            this.opodaci_gb.Controls.Add(this.button3);
            this.opodaci_gb.Controls.Add(this.tip_cb);
            this.opodaci_gb.Controls.Add(this.opis_tb);
            this.opodaci_gb.Controls.Add(this.naziv_tb);
            this.opodaci_gb.Controls.Add(this.oznaka_tb);
            this.opodaci_gb.Controls.Add(this.label3);
            this.opodaci_gb.Controls.Add(this.label1);
            this.opodaci_gb.Controls.Add(this.label5);
            this.opodaci_gb.Controls.Add(this.label4);
            this.opodaci_gb.Controls.Add(this.label2);
            this.opodaci_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opodaci_gb.Location = new System.Drawing.Point(12, 12);
            this.opodaci_gb.Name = "opodaci_gb";
            this.opodaci_gb.Size = new System.Drawing.Size(267, 208);
            this.opodaci_gb.TabIndex = 10;
            this.opodaci_gb.TabStop = false;
            this.opodaci_gb.Text = "Osnovni Podaci";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Etikete";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(135, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Izaberi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tip_cb
            // 
            this.tip_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tip_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip_cb.FormattingEnabled = true;
            this.tip_cb.Location = new System.Drawing.Point(116, 110);
            this.tip_cb.Name = "tip_cb";
            this.tip_cb.Size = new System.Drawing.Size(114, 21);
            this.tip_cb.TabIndex = 10;
            this.tip_cb.Validating += new System.ComponentModel.CancelEventHandler(this.tip_cb_Validating);
            // 
            // opis_tb
            // 
            this.opis_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opis_tb.Location = new System.Drawing.Point(116, 84);
            this.opis_tb.Name = "opis_tb";
            this.opis_tb.Size = new System.Drawing.Size(114, 20);
            this.opis_tb.TabIndex = 9;
            this.opis_tb.Validating += new System.ComponentModel.CancelEventHandler(this.opis_tb_Validating);
            // 
            // naziv_tb
            // 
            this.naziv_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naziv_tb.Location = new System.Drawing.Point(116, 58);
            this.naziv_tb.Name = "naziv_tb";
            this.naziv_tb.Size = new System.Drawing.Size(114, 20);
            this.naziv_tb.TabIndex = 8;
            this.naziv_tb.Validating += new System.ComponentModel.CancelEventHandler(this.naziv_tb_Validating);
            // 
            // oznaka_tb
            // 
            this.oznaka_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oznaka_tb.Location = new System.Drawing.Point(116, 32);
            this.oznaka_tb.Name = "oznaka_tb";
            this.oznaka_tb.Size = new System.Drawing.Size(114, 20);
            this.oznaka_tb.TabIndex = 7;
            this.oznaka_tb.Validating += new System.ComponentModel.CancelEventHandler(this.oznaka_tb_Validating);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ikonica:";
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
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // Izmena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(584, 304);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dpodaci_gb);
            this.Controls.Add(this.opodaci_gb);
            this.Name = "Izmena";
            this.Text = "Izmena";
            this.groupBox1.ResumeLayout(false);
            this.dpodaci_gb.ResumeLayout(false);
            this.dpodaci_gb.PerformLayout();
            this.opodaci_gb.ResumeLayout(false);
            this.opodaci_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox dpodaci_gb;
        private System.Windows.Forms.TextBox cena_tb;
        private System.Windows.Forms.ComboBox frekv_cb;
        private System.Windows.Forms.ComboBox jm_cb;
        private System.Windows.Forms.ComboBox ekspl_cb;
        private System.Windows.Forms.ComboBox strv_cb;
        private System.Windows.Forms.ComboBox obn_cb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox opodaci_gb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox tip_cb;
        private System.Windows.Forms.TextBox opis_tb;
        private System.Windows.Forms.TextBox naziv_tb;
        private System.Windows.Forms.TextBox oznaka_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider ep;
    }
}