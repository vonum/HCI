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
    partial class TutorijalTabelaEtiketa : Form
    {
        private Tutorijal t;
        private int state;

        public TutorijalTabelaEtiketa(Tutorijal t, int state)
        {
            InitializeComponent();
            this.t = t;
            this.state = state;
        }

        protected override void OnLoad(EventArgs e)                             //ucitavanje tabele**********/
        {
            Et et = new Et();

            et.color = Color.Magenta;
            et.opis = "opis";
            et.oznaka = "oznaka";

            table.Rows.Add(et.toString());
            table.Rows[0].Cells[2].Style.BackColor = et.color;

            if (state == 1)
                table.Rows[0].Cells[3].Style.BackColor = Color.Red;
            else if (state == 2)
                table.Rows[0].Cells[4].Style.BackColor = Color.Red;
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (state == 1 && e.ColumnIndex == 3)
            {
                TutorijalIzmenaEtiketa tie = new TutorijalIzmenaEtiketa(t, this);
                tie.Show();
            }
            else if (state == 2 && e.ColumnIndex == 4)
            {
                MessageBox.Show("Uspesno ste obrisali etiketu");
                this.Close();
                t.Close();
            }
        }


    }
}
