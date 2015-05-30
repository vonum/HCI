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
        public TabelaEtikete te;

        private System.Text.RegularExpressions.Regex text_rx;
        private bool valid;

        public IzmenaEtikete(Et etiketa, TabelaEtikete te)
        {
            InitializeComponent();
            this.etiketa = etiketa;
            color = etiketa.color;
            this.te = te;

            valid = true;
            text_rx = new System.Text.RegularExpressions.Regex("^[a-z, A-Z]+$");
        }

        private void button1_Click(object sender, EventArgs e)                  //povratak
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)                  //izmena
        {
            valid = true;
            ValidateChildren();

            if (valid)
            {
                bool tmp = true;
                foreach (Et et in te.etikete)
                {
                    if (et.oznaka.Equals(oznaka_tb.Text))
                    {
                        tmp = false;
                        MessageBox.Show("Postoji etiketa sa unetom oznakom");
                        break;
                    }

                }
                if (tmp)
                {
                    etiketa.color = color;
                    etiketa.opis = opis_tb.Text;
                    etiketa.oznaka = oznaka_tb.Text;

                    te.refresh();

                    this.Close();
                }
            }
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

        protected override void OnLoad(EventArgs e)
        {
            opis_tb.Text = etiketa.opis;
            oznaka_tb.Text = etiketa.oznaka;
        }

        private void oznaka_tb_Validating(object sender, CancelEventArgs e)
        {
            if (text_rx.Match(oznaka_tb.Text).Success)
            {
                ep.SetError(oznaka_tb, "");
                oznaka_tb.ForeColor = Color.Black;
            }
            else
            {
                ep.SetError(oznaka_tb, "Oznaka nije u odgovarajucem formatu");
                oznaka_tb.ForeColor = Color.Red;
                valid = false;
            }
        }

        private void opis_tb_Validating(object sender, CancelEventArgs e)
        {
            if (text_rx.Match(opis_tb.Text).Success)
            {
                ep.SetError(opis_tb, "");
                opis_tb.ForeColor = Color.Black;
            }
            else
            {
                ep.SetError(opis_tb, "Opis nije u odgovarajucem formatu");
                opis_tb.ForeColor = Color.Red;
                valid = false;
            }
        }
    }
}
