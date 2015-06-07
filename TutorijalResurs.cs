﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCI_FINAL
{
    partial class TutorijalResurs : Form
    {
        private Tutorijal t;

        public TutorijalResurs(Tutorijal t)
        {
            InitializeComponent();
            this.t = t;
        }

        protected override void OnLoad(EventArgs e)
        {
            checkedListBox1.Items.Add("Etiketa 1");
            checkedListBox1.Items.Add("Etiketa 2");

            tip_cb.Items.Add("Tip 1");
            tip_cb.Items.Add("Tip 2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspesno ste dodali resurs");
            this.Close();
            t.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
