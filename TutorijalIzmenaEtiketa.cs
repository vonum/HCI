using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCI_FINAL
{
    partial class TutorijalIzmenaEtiketa : Form
    {
        private Tutorijal t;
        private TutorijalTabelaEtiketa tt;

        public TutorijalIzmenaEtiketa(Tutorijal t, TutorijalTabelaEtiketa tt)
        {
            InitializeComponent();
            this.t = t;
            this.tt = tt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspesno ste izmenili etiketu");
            this.Close();
            tt.Close();
            t.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            cd.AllowFullOpen = false;
            cd.AnyColor = true;
            cd.SolidColorOnly = false;
            cd.Color = Color.Red;

            if (cd.ShowDialog() == DialogResult.OK) ;
        }
    }
}
