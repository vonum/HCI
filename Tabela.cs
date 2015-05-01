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
    partial class Tabela : Form
    {
        public List<Rsc> resursi;
        public List<TR> tipovi;

        public Tabela(List<Rsc> resursi, List<TR> tipovi)
        {
            InitializeComponent();
            this.resursi = resursi;
            this.tipovi = tipovi;
        }

        private void Tabela_Load(object sender, EventArgs e)
        {
            foreach (Rsc resurs in resursi)
            {
                //table.Rows.Add(resurs.toString());
            }
        }

        protected override void OnLoad(EventArgs e)                             //ucitavanje tabele**********/
        {
            foreach (Rsc resurs in resursi)
            {
                table.Rows.Add(resurs.toString());
            }
        }

        private void button4_Click(object sender, EventArgs e)                  //reset tabele**************/
        {
            table.Rows.Clear();
            foreach (Rsc resurs in resursi)
            {
                table.Rows.Add(resurs.toString());
            }
        }

        private void button1_Click(object sender, EventArgs e)                  //pretraga po nazivu, tipu i ceni*******/
        {
            table.Rows.Clear();
            foreach (Rsc resurs in resursi)
            {
                if (resurs.check(tip_pretraga.Text, naziv_pretraga.Text, cena_pretraga.Text))
                    table.Rows.Add(resurs.toString());
            }
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 6)
            {
                Izmena izm = new Izmena(tipovi, resursi.ElementAt(table.CurrentRow.Index), table.CurrentRow.Index);
                izm.Show();
            }
            else
                if (e.ColumnIndex == 7)
                {
                    resursi.RemoveAt(table.CurrentRow.Index);
                    table.Rows.Remove(table.Rows[table.CurrentRow.Index]);
                }
            
        }

    }
}
