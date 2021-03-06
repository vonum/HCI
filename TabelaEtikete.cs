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
    partial class TabelaEtikete : Form
    {
        public List<Et> etikete;
        public List<Rsc> resursi;

        public TabelaEtikete(List<Et> etikete, List<Rsc> resursi)
        {
            InitializeComponent();
            this.etikete = etikete;
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
                Et et = etikete.ElementAt(table.CurrentRow.Index);

                bool tmp = true;
                String poruka = "Nije moguce obrisati etiketu, jer sledeci resursi sadrze etiketu:\n";

                foreach (Rsc resurs in resursi)
                {
                    foreach(Et etiketa in resurs.etikete)
                    {
                        if (etiketa.oznaka.Equals(et.oznaka))
                        {
                            poruka += resurs.naziv + " " + resurs.oznaka + "\n";
                            tmp = false;
                            break;
                        }
                    }
                }
                if (tmp)
                {
                    etikete.RemoveAt(table.CurrentRow.Index);
                    table.Rows.Remove(table.Rows[table.CurrentRow.Index]);

                }
                else
                    MessageBox.Show(poruka);
            }
            else
                if (e.ColumnIndex == 3)
                {
                    IzmenaEtikete izmet = new IzmenaEtikete(etikete.ElementAt(table.CurrentRow.Index), this);
                    izmet.Show();
                }
        }

        public void refresh()
        {
            table.Rows.Clear();
            int i = 0;
            foreach (Et et in etikete)
            {
                table.Rows.Add(et.toString());
                table.Rows[i].Cells[2].Style.BackColor = et.color;
                i++;
            }

        }

    }
}
