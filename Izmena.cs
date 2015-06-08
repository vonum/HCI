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
    partial class Izmena : Form
    {
        public System.Drawing.Image img;
        public Rsc resurs;
        public List<TR> tipovi;
        public Tabela table;
        public Form1 form;
        public List<Et> etikete;

        private System.Text.RegularExpressions.Regex text_rx;
        private System.Text.RegularExpressions.Regex num_rx;
        private bool valid;
        private String name;
        private List<TR> tipovi_2;
        private Resurs resurs_2;
        private Tabela tabela;
        private List<Et> etikete_2;
        private Form1 form1;

        public Izmena(List<TR> tipovi, Rsc resurs, Tabela table, List<Et> etikete, Form1 form)
        {
            this.resurs = resurs;
            this.tipovi = tipovi;
            this.table = table;
            InitializeComponent();
            text_rx = new System.Text.RegularExpressions.Regex("^[a-z, A-Z]+$");
            num_rx = new System.Text.RegularExpressions.Regex("^[0-9]+$");
            valid = true;
            img = resurs.ikonica;
            this.etikete = etikete;
            this.form = form;
            this.name = resurs.naziv;
        }

        public Izmena(List<TR> tipovi_2, Resurs resurs_2, Tabela tabela, List<Et> etikete_2, Form1 form1)
        {
            // TODO: Complete member initialization
            this.tipovi_2 = tipovi_2;
            this.resurs_2 = resurs_2;
            this.tabela = tabela;
            this.etikete_2 = etikete_2;
            this.form1 = form1;
        }

        protected override void OnLoad(EventArgs e)                             //ucitavanje tabele**********/
        {
            foreach (TR tip in tipovi)
            {
                tip_cb.Items.Add(tip.naziv);
            }

            naziv_tb.Text = resurs.naziv;
            opis_tb.Text = resurs.opis;
            oznaka_tb.Text = resurs.oznaka;
            tip_cb.Text = resurs.tip.naziv;
            jm_cb.SelectedIndex = (int)resurs.jm;
            obn_cb.Text = (resurs.obnovljiv) ? "Obnovljiv" : "Neobnovljiv";
            frekv_cb.SelectedIndex = (int)resurs.frekv;
            ekspl_cb.Text = (resurs.eskploativ) ? "Eksploativ" : "Neeksploativ";
            cena_tb.Text = resurs.cena.ToString();
            strv_cb.Text = (resurs.str_vaznost) ? "Bitan" : "Nebitan";

            foreach (Et et in etikete)
            {
                checkedListBox1.Items.Add(et.oznaka);
                if (resurs.etikete.Contains(et))
                {
                    checkedListBox1.SetItemChecked(checkedListBox1.Items.Count - 1, true);
                }
            }


        }


        private void button1_Click(object sender, EventArgs e)              //povratak*****************//
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)              //biranje ikonice*********//
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            od.Title = "Izaberite ikonicu";
            od.Multiselect = false;

            if (od.ShowDialog() == DialogResult.OK)
                img = Image.FromFile(od.FileName);
        }

        private void button2_Click(object sender, EventArgs e)              //izmena
        {
            valid = true;
            ValidateChildren();

            if (valid)
            {
                bool tmp = true;

                foreach (Rsc r in table.resursi)
                {
                    if (r.naziv.Equals(naziv_tb.Text) || r.oznaka.Equals(oznaka_tb.Text))
                    {
                        if (r == resurs)
                            continue;
                        tmp = false;
                        MessageBox.Show("Postoji resurs sa unetim nazivom ili oznakom");
                        break;
                    }

                }

                if (tmp)
                {
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

                    resurs.ikonica = img;

                    resurs.etikete.Clear();
                    foreach (int idx in checkedListBox1.CheckedIndices)
                    {
                        resurs.etikete.Add(etikete.ElementAt(idx));
                    }

                    table.refresh();
                    //form.reloadForm();
                    //form.changeImage(resurs);

                    this.Close();
                }
            }
        }

        private void oznaka_tb_Validating(object sender, CancelEventArgs e)
        {
            if (text_rx.Match(oznaka_tb.Text).Success)
            {
                oznaka_tb.ForeColor = Color.Black;
                ep.SetError(oznaka_tb, "");
            }
            else
            {
                ep.SetError(oznaka_tb, "Oznaka nije u odgovarajucem formatu");
                oznaka_tb.ForeColor = Color.Red;
                valid = false;
            }
        }

        private void naziv_tb_Validating(object sender, CancelEventArgs e)
        {
            if (text_rx.Match(naziv_tb.Text).Success)
            {
                naziv_tb.ForeColor = Color.Black;
                ep.SetError(naziv_tb, "");
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
                opis_tb.ForeColor = Color.Black;
                ep.SetError(opis_tb, "");
            }
            else
            {
                ep.SetError(opis_tb, "Opis nije u odgovarajucem formatu");
                opis_tb.ForeColor = Color.Red;
                valid = false;
            }
        }

        private void tip_cb_Validating(object sender, CancelEventArgs e)
        {
            if (tip_cb.SelectedIndex != -1)
            {
                ep.SetError(tip_cb, "");
                tip_cb.ForeColor = Color.Black;
            }
            else
            {
                ep.SetError(tip_cb, "Izaberite tip resursa");
                tip_cb.ForeColor = Color.Red;
                valid = false;
            }
        }

        private void obn_cb_Validating(object sender, CancelEventArgs e)
        {
            if (obn_cb.SelectedIndex != -1)
            {
                ep.SetError(obn_cb, "");
                obn_cb.ForeColor = Color.Black;
            }
            else
            {
                ep.SetError(obn_cb, "Odredite obnovljivost resursa");
                obn_cb.ForeColor = Color.Red;
                valid = false;
            }
        }

        private void strv_cb_Validating(object sender, CancelEventArgs e)
        {
            if (strv_cb.SelectedIndex != -1)
            {
                ep.SetError(strv_cb, "");
                strv_cb.ForeColor = Color.Black;
            }
            else
            {
                ep.SetError(strv_cb, "Odredite stratesku vaznost resursa");
                strv_cb.ForeColor = Color.Red;
                valid = false;
            }
        }

        private void ekspl_cb_Validating(object sender, CancelEventArgs e)
        {
            if (ekspl_cb.SelectedIndex != -1)
            {
                ep.SetError(ekspl_cb, "");
                ekspl_cb.ForeColor = Color.Black;
            }
            else
            {
                ep.SetError(ekspl_cb, "Odredite eksploativnost");
                ekspl_cb.ForeColor = Color.Red;
                valid = false;
            }
        }   

        private void jm_cb_Validating(object sender, CancelEventArgs e)
        {
            if (jm_cb.SelectedIndex != -1)
            {
                ep.SetError(jm_cb, "");
                jm_cb.ForeColor = Color.Black;
            }
            else
            {
                ep.SetError(jm_cb, "Odredite jedinicu mere resursa");
                jm_cb.ForeColor = Color.Red;
                valid = false;
            }
        }

        private void cena_tb_Validating(object sender, CancelEventArgs e)
        {
            if (num_rx.Match(cena_tb.Text).Success)
            {
                cena_tb.ForeColor = Color.Black;
                ep.SetError(cena_tb, "");
            }
            else
            {
                ep.SetError(cena_tb, "Cena nije u odgovarajucem formatu");
                cena_tb.ForeColor = Color.Red;
                valid = false;
            }
        }

        private void frekv_cb_Validating(object sender, CancelEventArgs e)
        {
            if (frekv_cb.SelectedIndex != -1)
            {
                ep.SetError(frekv_cb, "");
                frekv_cb.ForeColor = Color.Black;
            }
            else
            {
                ep.SetError(frekv_cb, "Odredite frekvenciju pojavljivanja resursa");
                frekv_cb.ForeColor = Color.Red;
                valid = false;
            }
        }

        private void Izmena_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(SerIkonica si in form.ikonice)
            {
                if (si.naziv.Equals(name))
                {
                    si.naziv = resurs.naziv;
                }
            }

            foreach (PictureBox pb in form.panel1.Controls)
            {
                if (pb.Name.Equals(name))
                {
                    pb.Name = resurs.naziv;
                }
            }
        }
    }
}
