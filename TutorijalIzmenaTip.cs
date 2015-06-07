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
    partial class TutorijalIzmenaTip : Form
    {
        Tutorijal t;
        TutorijalTabelaTip tt;

        public TutorijalIzmenaTip(Tutorijal t, TutorijalTabelaTip tt)
        {
            InitializeComponent();
            this.t = t;
            this.tt = tt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspesno ste izmenili tip resursa");
            this.Close();
            t.Close();
            tt.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            od.Title = "Izaberite ikonicu";
            od.Multiselect = false;

            if (od.ShowDialog() == DialogResult.OK) ;
        }


    }
}
