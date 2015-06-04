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
    partial class IzmenaTip : Form
    {
        public TR tr;
        public System.Drawing.Image img;
        public TabelaTipovi tt;
        public List<Rsc> resursi;

        private bool valid;
        private System.Text.RegularExpressions.Regex text_rx;

        public IzmenaTip(TR tr, TabelaTipovi tt, List<Rsc> resursi)
        {
            InitializeComponent();
            this.tr = tr;
            img = tr.ikonica;
            this.tt = tt;
            this.resursi = resursi;

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
                bool tmp1 = true;

                foreach (TR tip in tt.tipovi)
                {
                    if (tip.oznaka.Equals(oznaka_tb.Text) || tip.naziv.Equals(naziv_tb.Text))
                    {
                        if (tip == tr)
                            continue;
                        tmp1 = false;
                        MessageBox.Show("Postoji tip sa unetim nazivom ili oznakom");
                        break;
                    }
                }
                if (tmp1)
                {
                    String tmp = tr.naziv;

                    tr.ikonica = img;
                    tr.naziv = naziv_tb.Text;
                    tr.opis = opis_tb.Text;
                    tr.oznaka = oznaka_tb.Text;

                    foreach (Rsc resurs in resursi)
                    {
                        if (resurs.tip.naziv.Equals(tmp))
                            resurs.tip = tr;
                    }

                    tt.refresh();

                    this.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)                  //slika
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            od.Title = "Izaberite ikonicu";
            od.Multiselect = false;

            if (od.ShowDialog() == DialogResult.OK)
                img = Image.FromFile(od.FileName);
        }

        protected override void OnLoad(EventArgs e)
        {
            naziv_tb.Text = tr.naziv;
            opis_tb.Text = tr.opis;
            oznaka_tb.Text = tr.oznaka;
        }

        private void naziv_tb_Validating(object sender, CancelEventArgs e)
        {
            if (text_rx.Match(naziv_tb.Text).Success)
            {
                ep.SetError(naziv_tb, "");
                naziv_tb.ForeColor = Color.Black;
            }
            else
            {
                ep.SetError(naziv_tb, "Naziv nije u odgovarajucem formatu");
                naziv_tb.ForeColor = Color.Red;
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


    }
}
