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

        public Resurs(List<TR> tipovi, List<Et> etikete, List<Rsc> resursi, Form1 form)
        {
            this.img = null;
            this.tipovi = tipovi;
            this.etikete = etikete;
            this.resursi = resursi;
            this.form = form;
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

        private void etikete_cb_DropDown(object sender, EventArgs e)
        {

        }

        private void etikete_cb_DropDownClosed(object sender, EventArgs e)
        {

        }

    }
}
