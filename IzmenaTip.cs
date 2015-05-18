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

        public IzmenaTip(TR tr)
        {
            InitializeComponent();
            this.tr = tr;
            img = tr.ikonica;
        }
            
        private void button1_Click(object sender, EventArgs e)                  //povratak
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)                  //izmena
        {
            tr.ikonica = img;
            tr.naziv = naziv_tb.Text;
            tr.opis = opis_tb.Text;
            tr.oznaka = oznaka_tb.Text;

            this.Close();
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
    }
}
