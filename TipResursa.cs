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

        public TipResursa(List<TR> tipovi)
        {
            this.tipovi = tipovi;
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
