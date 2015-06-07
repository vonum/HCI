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
    public partial class Tutorijal : Form
    {
        public int state;
        public bool valid;

        public Tutorijal(int i)
        {
            InitializeComponent();

            valid = false;
            state = i;

            if (i == 1)     //dodavanje resursa
            {
                var items = menuStrip1.Items.Find("dodaj", true);
                items[0].BackColor = Color.Red;
                var items1 = menuStrip1.Items.Find("dodajresurs", true);
                items1[0].BackColor = Color.Red;
            }
            else if (i == 2)    //dodavanje tipa
            {
                var items = menuStrip1.Items.Find("dodaj", true);
                items[0].BackColor = Color.Red;
                var items1 = menuStrip1.Items.Find("dodajtip", true);
                items1[0].BackColor = Color.Red;
            }
            else if (i == 3)    //dodavanje etikete
            {
                var items = menuStrip1.Items.Find("dodaj", true);
                items[0].BackColor = Color.Red;
                var items1 = menuStrip1.Items.Find("dodajetiketu", true);
                items1[0].BackColor = Color.Red;
            }
            else if (i == 4 || i == 7)    //izmena i brisanje resursa 
            {
                var items = menuStrip1.Items.Find("tabela", true);
                items[0].BackColor = Color.Red;
                var items1 = menuStrip1.Items.Find("tabelaresursi", true);
                items1[0].BackColor = Color.Red;
            }
            else if (i == 5 || i == 8)    //izmena tipa i brisanje tipa
            {
                var items = menuStrip1.Items.Find("tabela", true);
                items[0].BackColor = Color.Red;
                var items1 = menuStrip1.Items.Find("tabelatipovi", true);
                items1[0].BackColor = Color.Red;
            }
            else if (i == 6 || i == 9)    //izmena i brisanje etikete
            {
                var items = menuStrip1.Items.Find("tabela", true);
                items[0].BackColor = Color.Red;
                var items1 = menuStrip1.Items.Find("tabelaetikete", true);
                items1[0].BackColor = Color.Red;
            }

        }

        private void resursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                valid = true;
                TutorijalResurs tr = new TutorijalResurs(this);
                tr.Show();
            }
        }

        private void tipResursaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (state == 2)
            {
                valid = true;
                TutorijalTip tt = new TutorijalTip(this);
                tt.Show();
            }
        }

        private void etiketaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (state == 3)
            {
                valid = true;
                TutorijalEtiketa te = new TutorijalEtiketa(this);
                te.Show();
            }
        }

        private void tabelaresursi_Click(object sender, EventArgs e)
        {
            if (state == 4)
            {
                TutorijalTabelaResurs ttr = new TutorijalTabelaResurs(this, 1);
                ttr.Show();
            }
            else if (state == 7)
            {
                TutorijalTabelaResurs ttr = new TutorijalTabelaResurs(this, 2);
                ttr.Show();
            }
        }

        private void tabelatipovi_Click(object sender, EventArgs e)
        {
            if (state == 5)
            {
                TutorijalTabelaTip ttt = new TutorijalTabelaTip(this, 1);
                ttt.Show();
            }
            else if (state == 8)
            {
                TutorijalTabelaTip ttt = new TutorijalTabelaTip(this, 2);
                ttt.Show();
            }
        }

        private void tabelaetikete_Click(object sender, EventArgs e)
        {
            if (state == 6)
            {
                TutorijalTabelaEtiketa tte = new TutorijalTabelaEtiketa(this, 1);
                tte.Show();
            }
            else if (state == 9)
            {
                TutorijalTabelaEtiketa tte = new TutorijalTabelaEtiketa(this, 2);
                tte.Show();
            }
        }
    }
}
