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

        private System.Text.RegularExpressions.Regex text_rx;
        private bool valid;

        public Etiketa(List<Et> etikete)
        {
            InitializeComponent();
            color = Color.Aqua;
            this.etikete = etikete;
            text_rx = new System.Text.RegularExpressions.Regex("[a-z, A-Z]+$");
            valid = true;
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
            valid = true;
            this.ValidateChildren();
            if (valid)
            {
                String oznaka = this.oznaka_tb.Text;
                String opis = this.opis_tb.Text;
                bool tmp = true;

                foreach (Et etiketa in etikete)
                {
                    if (etiketa.oznaka.Equals(oznaka))
                    {
                        tmp = false;
                        MessageBox.Show("Postoji etiketa sa unetom oznakom");
                        break;
                    }
                }
                if (tmp)
                {
                    Et et = new Et();
                    et.opis = opis;
                    et.oznaka = oznaka;
                    et.color = color;

                    etikete.Add(et);

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Nije moguc unos, jer neko od polja nije u dozvoljenom formatu");
            }

        }

        private void oznaka_tb_Validating(object sender, CancelEventArgs e)
        {
            if (text_rx.Match(oznaka_tb.Text).Success)
            {
                eep.SetError(oznaka_tb, "");
                oznaka_tb.ForeColor = Color.Black;
            }
            else
            {
                eep.SetError(oznaka_tb, "Oznaka nije u dozvoljenom formatu");
                valid = false;
                oznaka_tb.ForeColor = Color.Red;
            }
        }

        private void opis_tb_Validating(object sender, CancelEventArgs e)
        {
            if (text_rx.Match(opis_tb.Text).Success)
            {
                eep.SetError(opis_tb, "");
                opis_tb.ForeColor = Color.Black;
            }
            else
            {
                eep.SetError(opis_tb, "Opis nije u dozvoljenom formatu");
                valid = false;
                opis_tb.ForeColor = Color.Red;
            }
        }

    }
}
