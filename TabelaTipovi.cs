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
    partial class TabelaTipovi : Form
    {
        public List<TR> tipovi;
        public List<Rsc> resursi;

        public TabelaTipovi(List<TR> tipovi)
        {
            InitializeComponent();
            this.tipovi = tipovi;
        }

        protected override void OnLoad(EventArgs e)                             //ucitavanje tabele**********/
        {
            foreach (TR tr in tipovi)
            {
                table.Rows.Add(tr.toString());
            }
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                tipovi.RemoveAt(table.CurrentRow.Index);
                table.Rows.Remove(table.Rows[table.CurrentRow.Index]);
            }
        }


    }
}
