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
    partial class IzmenaEtikete : Form
    {
        public System.Drawing.Color color;
        public Et etiketa;

        public IzmenaEtikete(Et etiketa)
        {
            InitializeComponent();
            this.etiketa = etiketa;
            color = etiketa.color;
        }

        private void button1_Click(object sender, EventArgs e)                  //povratak
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)                  //izmena
        {
            etiketa.color = color;
            etiketa.opis = opis_tb.Text;
            etiketa.oznaka = oznaka_tb.Text;

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)                  //biranje boja
        {
            ColorDialog cd = new ColorDialog();

            cd.AllowFullOpen = false;
            cd.AnyColor = true;
            cd.SolidColorOnly = false;
            cd.Color = Color.Red;

            if (cd.ShowDialog() == DialogResult.OK)
                color = cd.Color;
        }
    }
}
