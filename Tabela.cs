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

        public Tabela(List<Rsc> resursi)
        {
            InitializeComponent();
            this.resursi = resursi;
        }

        private void Tabela_Load(object sender, EventArgs e)
        {
            foreach (Rsc resurs in resursi)
            {
                table.Rows.Add(resurs.toString());
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            foreach (Rsc resurs in resursi)
            {
                //table.Rows.Add(resurs.toString());
            }
        }

    }
}
