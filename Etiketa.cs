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
    partial class Etiketa : Form
    {
        public System.Drawing.Color color;
        public List<Et> etikete;

        public Etiketa(List<Et> etikete)
        {
            InitializeComponent();
            color = Color.Aqua;
            this.etikete = etikete;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            cd.AllowFullOpen = false;
            cd.AnyColor = true;
            cd.SolidColorOnly = false;
            cd.Color = Color.Red;

            if (cd.ShowDialog() == DialogResult.OK)
                color = cd.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String oznaka = this.oznaka_tb.Text;
            String opis = this.opis_tb.Text;

            Et et = new Et();
            et.opis = opis;
            et.oznaka = oznaka;
            et.color = color;

            etikete.Add(et);

            this.Close();

        }

    }
}
