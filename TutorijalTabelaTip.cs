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
    partial class TutorijalTabelaTip : Form
    {
        private Tutorijal t;
        private int state;

        public TutorijalTabelaTip(Tutorijal t, int state)
        {
            InitializeComponent();
            this.t = t;
            this.state = state;
        }

        protected override void OnLoad(EventArgs e)                             //ucitavanje tabele**********/
        {
            TR tr = new TR();
            tr.naziv = "naziv";
            tr.opis = "opis";
            tr.oznaka = "oznaka";

            table.Rows.Add(tr.toString());

            if (state == 1)
                table.Rows[0].Cells[3].Style.BackColor = Color.Red;
            else if (state == 2)
                table.Rows[0].Cells[4].Style.BackColor = Color.Red;
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (state == 1 && e.ColumnIndex == 3)
            {
                TutorijalIzmenaTip tit = new TutorijalIzmenaTip(t, this);
                tit.Show();
            }
            else if (state == 2 && e.ColumnIndex == 4)
            {
                MessageBox.Show("Uspesno ste obrisali tip resursa");
                this.Close();
                t.Close();
            }
        }
    }
}
