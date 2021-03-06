﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCI_FINAL
{
    partial class TabelaTipovi : Form
    {
        public List<TR> tipovi;
        public List<Rsc> resursi;

        public TabelaTipovi(List<TR> tipovi, List<Rsc> resursi)
        {
            InitializeComponent();
            this.tipovi = tipovi;
            this.resursi = resursi;
        }

        protected override void OnLoad(EventArgs e)                             //ucitavanje tabele**********/
        {
            refresh();
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                TR tip = tipovi.ElementAt(table.CurrentRow.Index);

                bool tmp = true;
                String poruka = "Nije moguce obrisati tip resursa, jer su sledeci resursi tog tipa:\n";

                foreach (Rsc resurs in resursi)
                {
                    if (resurs.tip.naziv.Equals(tip.naziv))
                    {
                        poruka += resurs.naziv + " " + resurs.oznaka + "\n";
                        tmp = false;
                        continue;
                    }
                }

                if (tmp)
                {
                    tipovi.RemoveAt(table.CurrentRow.Index);
                    table.Rows.Remove(table.Rows[table.CurrentRow.Index]);
                }
                else
                    MessageBox.Show(poruka);
            }
            else if (e.ColumnIndex == 3)
            {
                IzmenaTip izmtip = new IzmenaTip(tipovi.ElementAt(table.CurrentRow.Index), this, resursi);
                izmtip.Show();
            }
        }

        public void refresh()
        {
            table.Rows.Clear();
            foreach (TR tr in tipovi)
            {
                table.Rows.Add(tr.toString());
            }
        }


    }
}
