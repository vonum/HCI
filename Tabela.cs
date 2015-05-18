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
                else
                {
                    Rsc tmp = resursi.ElementAt(table.CurrentRow.Index);
                    oznaka_tb.Text = tmp.oznaka;
                    naziv_tb.Text = tmp.naziv;
                    opis_tb.Text = tmp.opis;
                    tip_tb.Text = tmp.tip.naziv;
                    if (tmp.obnovljiv)
                        obn_tb.Text = "Obnovljiv";
                    else
                        obn_tb.Text = "Neobnovljiv";
                    if (tmp.str_vaznost)
                        strv_tb.Text = "Bitan";
                    else
                        strv_tb.Text = "Nebitan";
                    jm_tb.Text = tmp.jm.ToString();
                    if (tmp.eskploativ)
                        ekspl_tb.Text = "Eksploativ";
                    else
                        ekspl_tb.Text = "Neeksploativ";
                    cena_tb.Text = tmp.cena.ToString();
                    frekv_tb.Text = tmp.frekv.ToString();
                }

        }

    }
}
