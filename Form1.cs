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
    partial class Form1 : Form
    {
        public List<Et> etikete;
        public List<TR> tipovi;
        public List<Rsc> resursi;

        public Form1()
        {
            etikete = new List<Et>();
            tipovi = new List<TR>();
            resursi = new List<Rsc>();
            InitializeComponent();
        }

        private void resursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resurs r = new Resurs(tipovi, etikete, resursi);
            r.Show();
        }

        private void tipResursaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipResursa tr = new TipResursa(tipovi);
            tr.Show();
        }

        private void etiketaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etiketa et = new Etiketa(etikete);
            et.Show();
        }

        private void tabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabela t = new Tabela(resursi);
            t.Show();
        }
    }
}
