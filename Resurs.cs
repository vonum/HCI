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
    partial class Resurs : Form
    {
        public Image img;
        public List<TR> tipovi;
        public List<Et> etikete;
        public List<Rsc> resursi;
        public Form1 form;

        private System.Text.RegularExpressions.Regex text_rx;
        private System.Text.RegularExpressions.Regex num_rx;
        private bool valid;

        public Resurs(List<TR> tipovi, List<Et> etikete, List<Rsc> resursi, Form1 form)
        {
            this.img = null;
            this.tipovi = tipovi;
            this.etikete = etikete;
            this.resursi = resursi;
            this.form = form;
            valid = true;
            text_rx = new System.Text.RegularExpressions.Regex("^[a-z, A-Z]+$");
            num_rx = new System.Text.RegularExpressions.Regex("^[0-9]+$");
            InitializeComponent();
        }

        private void Resurs_Load(object sender, EventArgs e)            //zasto ovo ne radi?****************//
        {
            foreach (TR tr in tipovi)
            {
                tip_cb.Items.Add(tr.naziv);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            foreach (TR tr in tipovi)
            {
                tip_cb.Items.Add(tr.naziv);
            }

            foreach (Et et in etikete)
            {
            }

        }

        private void button3_Click(object sender, EventArgs e)                  //biranje ikonica****************/
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            od.Title = "Izaberite ikonicu";
            od.Multiselect = false;

            if (od.ShowDialog() == DialogResult.OK) 
                img = Image.FromFile(od.FileName);
        }

        private void button1_Click(object sender, EventArgs e)                  //povratak*******************/
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)                  //dodavanje resursa***************/
        {
            valid = true;
            ValidateChildren();

            if (valid)
            {
                Rsc resurs = new Rsc();

                resurs.opis = opis_tb.Text;
                resurs.naziv = naziv_tb.Text;
                resurs.ikonica = img;
                resurs.oznaka = oznaka_tb.Text;

                if (obn_cb.Text.Equals("Obnovljiv"))
                    resurs.obnovljiv = true;
                else
                    resurs.obnovljiv = false;

                if (strv_cb.Text.Equals("Bitan"))
                    resurs.str_vaznost = true;
                else
                    resurs.str_vaznost = false;

                if (ekspl_cb.Text.Equals("Eksploativ"))
                    resurs.eskploativ = true;
                else
                    resurs.eskploativ = false;

                try
                {
                    resurs.cena = Convert.ToInt32(cena_tb.Text);
                }
                catch (FormatException exc)
                {
                    Console.WriteLine("Input string is not a sequence of digits.");
                    resurs.cena = 0;
                }

                if (jm_cb.Text.Equals("Tona"))
                    resurs.jm = JedinicaMere.TONA;
                else
                    if (jm_cb.Text.Equals("KG"))
                        resurs.jm = JedinicaMere.KG;
                    else
                        if (jm_cb.Text.Equals("Merica"))
                            resurs.jm = JedinicaMere.MERICA;
                        else
                            resurs.jm = JedinicaMere.BAREL;

                if (frekv_cb.Text.Equals("Redak"))
                    resurs.frekv = Frekvencija.REDAK;
                else
                    if (frekv_cb.Text.Equals("Cest"))
                        resurs.frekv = Frekvencija.CEST;
                    else
                        resurs.frekv = Frekvencija.UNIVERZALAN;

                String naziv_tipa = tip_cb.Text;

                foreach (TR tip in tipovi)
                {
                    if (tip.naziv.Equals(naziv_tipa))
                    {
                        resurs.tip = tip;
                        break;
                    }
                }

                if (resurs.ikonica == null)
                    resurs.ikonica = resurs.tip.ikonica;

                resursi.Add(resurs);

                form.reloadForm();

                this.Close();
            }

        }

        private void oznaka_tb_Validating(object sender, CancelEventArgs e)
        {
            if (text_rx.Match(oznaka_tb.Text).Success)
            {
                rep.SetError(oznaka_tb, "");
                oznaka_tb.ForeColor = Color.Black;
            }
            else
            {
                rep.SetError(oznaka_tb, "Oznaka nije u odgovarajucem formatu");
                oznaka_tb.ForeColor = Color.Red;
                valid = false;
            }
        }

        private void naziv_tb_Validating(object sender, CancelEventArgs e)
        {
            if (text_rx.Match(naziv_tb.Text).Success)
            {
                rep.SetError(naziv_tb, "");
                naziv_tb.ForeColor = Color.Black;
            }
            else
            {
                rep.SetError(naziv_tb, "Naziv nije u odgovarajucem formatu");
                naziv_tb.ForeColor = Color.Red;
                valid = false;
            }
        }

        private void opis_tb_Validating(object sender, CancelEventArgs e)
        {
            if (text_rx.Match(opis_tb.Text).Success)
            {
                rep.SetError(opis_tb, "");
                opis_tb.ForeColor = Color.Black;
            }
            else
            {
                rep.SetError(opis_tb, "Opis nije u odgovarajucem formatu");
                opis_tb.ForeColor = Color.Red;
                valid = false;
            }
        }

        private void tip_cb_Validating(object sender, CancelEventArgs e)
        {
            if (text_rx.Match(tip_cb.Text).Success)
            {
                rep.SetError(tip_cb, "");
                tip_cb.ForeColor = Color.Black;
            }
            else
            {
                rep.SetError(tip_cb, "Izaberite tip resursa");
                tip_cb.ForeColor = Color.Red;
                valid = false;
            }
        }

        private void obn_cb_Validating(object sender, CancelEventArgs e)
        {
            if (text_rx.Match(obn_cb.Text).Success)
            {
                rep.SetError(obn_cb, "");
                obn_cb.ForeColor = Color.Black;
            }
            else
            {
                rep.SetError(obn_cb, "Odredite obnovljivost resursa");
                obn_cb.ForeColor = Color.Red;
                valid = false;
            }
        }

        private void strv_cb_Validating(object sender, CancelEventArgs e)
        {
            if (text_rx.Match(strv_cb.Text).Success)
            {
                rep.SetError(strv_cb, "");
                strv_cb.ForeColor = Color.Black;
            }
            else
            {
                rep.SetError(strv_cb, "Odredite stratesku vaznost resursa");
                strv_cb.ForeColor = Color.Red;
                valid = false;
            }
        }


        private void jm_cb_Validating(object sender, CancelEventArgs e)
        {
            if (text_rx.Match(jm_cb.Text).Success)
            {
                rep.SetError(jm_cb, "");
                jm_cb.ForeColor = Color.Black;
            }
            else
            {
                rep.SetError(jm_cb, "Odredite jedinicu mere resursa");
                jm_cb.ForeColor = Color.Red;
                valid = false;
            }
        }

        private void cena_tb_Validating(object sender, CancelEventArgs e)
        {
            if (num_rx.Match(cena_tb.Text).Success)
            {
                rep.SetError(cena_tb, "");
                cena_tb.ForeColor = Color.Black;
            }
            else
            {
                rep.SetError(cena_tb, "Cena nije u odgovarajucem formatu");
                cena_tb.ForeColor = Color.Red;
                valid = false;
            }
        }

        private void frekv_cb_Validating(object sender, CancelEventArgs e)
        {
            if (frekv_cb.SelectedIndex != -1)
            {
                rep.SetError(frekv_cb, "");
                frekv_cb.ForeColor = Color.Black;
            }
            else
            {
                rep.SetError(frekv_cb, "Odredite frekvenciju pojavljivanja resursa");
                frekv_cb.ForeColor = Color.Red;
                valid = false;
            }
        }

        private void ekspl_cb_Validating(object sender, CancelEventArgs e)
        {
            if (ekspl_cb.SelectedIndex != -1)
            {
                rep.SetError(ekspl_cb, "");
                ekspl_cb.ForeColor = Color.Black;
            }
            else
            {
                rep.SetError(ekspl_cb, "Odredite eksploativnost");
                ekspl_cb.ForeColor = Color.Red;
                valid = false;
            }
        }   

    }
}
