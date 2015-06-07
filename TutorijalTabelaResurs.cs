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
    partial class TutorijalTabelaResurs : Form
    {
        Tutorijal t;
        int state;

        public TutorijalTabelaResurs(Tutorijal t, int state)    //1 = izmena, 2 = brisanje
        {
            InitializeComponent();
            this.t = t;
            this.state = state;
        }

        protected override void OnLoad(EventArgs e)                             //ucitavanje tabele**********/
        {
            Rsc tmp = new Rsc();

            tmp.naziv = "naziv";
            tmp.oznaka = "oznaka";
            tmp.opis = "opis";
            tmp.obnovljiv = true;
            tmp.str_vaznost = true;
            tmp.eskploativ = true;
            tmp.cena = 7;
            tmp.frekv = Frekvencija.CEST;
            tmp.jm = JedinicaMere.BAREL;

            TR tr = new TR();

            tr.naziv = "naziv tipa";
            tr.opis = "opis tipa";
            tr.oznaka = "oznaka tipa";

            tmp.tip = tr;

            table.Rows.Add(tmp.toString());

            if (state == 1)
                table.Rows[0].Cells[6].Style.BackColor = Color.Red;
            else if (state == 2)
                table.Rows[0].Cells[7].Style.BackColor = Color.Red;

        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (state == 1 && e.ColumnIndex == 6)
            {
                this.Close();
                t.Close();
            }
            else if (state == 2 && e.ColumnIndex == 7)
            {
                MessageBox.Show("Uspesno ste obrisali resurs");
                this.Close();
                t.Close();
            }
        }
    }
}
