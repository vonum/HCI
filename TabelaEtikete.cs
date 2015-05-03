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
    partial class TabelaEtikete : Form
    {
        public List<Et> etikete;

        public TabelaEtikete(List<Et> etikete)
        {
            InitializeComponent();
            this.etikete = etikete;
        }

        protected override void OnLoad(EventArgs e)                             //ucitavanje tabele**********/
        {
            foreach (Et et in etikete)
            {
                table.Rows.Add(et.toString());
            }
        }

    }
}
