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
    partial class TipResursa : Form
    {
        public Image img;
        public List<TR> tipovi;

        private System.Text.RegularExpressions.Regex text_rx;
        private bool valid;

        public TipResursa(List<TR> tipovi)
        {
            this.tipovi = tipovi;
            valid = true;
            text_rx = new System.Text.RegularExpressions.Regex("[a-z, A-Z]+$");
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)                  //izbor slike
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            od.Title = "Izaberite ikonicu";
            od.Multiselect = false;

            if (od.ShowDialog() == DialogResult.OK)
                img = Image.FromFile(od.FileName);
        }

        private void button1_Click(object sender, EventArgs e)                  //povratak(zatvaranje prozora)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)                  //potvrda(dodavanje tipa resursa)
        {
            valid = true;
            this.ValidateChildren();

            if (!valid)
            {
                MessageBox.Show("Polja nisu u dozvoljenom formatu");
            }
            else
            {
                if (img == null)
                    MessageBox.Show("Morate izabrati ikonicu");
                else
                {
                    bool tmp = true;
                    foreach (TR tip in tipovi)
                    {
                        if (tip.naziv.Equals(naziv_tb.Text) || tip.oznaka.Equals(oznaka_tb.Text))
                        {
                            tmp = false;
                            MessageBox.Show("Postoji tip sa unetim nazivom ili oznakom");
                            break;
                        }
                    }
                    if (tmp)
                    {
                        TR tr = new TR();
                        tr.naziv = naziv_tb.Text;
                        tr.opis = opis_tb.Text;
                        tr.oznaka = oznaka_tb.Text;
                        tr.ikonica = img;

                        tipovi.Add(tr);
                        this.Close();
                    }
                }
            }
        }

        private void naziv_tb_Validating(object sender, CancelEventArgs e)
        {
            if (!text_rx.Match(naziv_tb.Text).Success)
            {
                naziv_tb.ForeColor = Color.Red;
                valid = false;
                trep.SetError(naziv_tb, "Naziv nije u dozvoljenom formatu");
            }
            else
            {
                trep.SetError(naziv_tb, "");
                naziv_tb.ForeColor = Color.Black;
            }
        }

        private void opis_tb_Validating(object sender, CancelEventArgs e)
        {
            if (text_rx.Match(opis_tb.Text).Success)
            {
                trep.SetError(opis_tb, "");
                opis_tb.ForeColor = Color.Black;
            }
            else
            {
                opis_tb.ForeColor = Color.Red;
                valid = false;
                trep.SetError(opis_tb, "Opis nije u dozvoljenom formatu");
            }
        }

        private void oznaka_tb_Validating(object sender, CancelEventArgs e)
        {
            if (text_rx.Match(oznaka_tb.Text).Success)
            {
                trep.SetError(oznaka_tb, "");
                oznaka_tb.ForeColor = Color.Black;
            }
            else
            {
                oznaka_tb.ForeColor = Color.Red;
                valid = false;
                trep.SetError(oznaka_tb, "Oznaka nije u dozvoljenom formatu");
            }
        }
    }
}
