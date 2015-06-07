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
    partial class TutorijalEtiketa : Form
    {
        private Tutorijal t;

        public TutorijalEtiketa(Tutorijal t)
        {
            InitializeComponent();
            this.t = t;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspesno ste dodali novu etiketu");
            this.Close();
            t.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
