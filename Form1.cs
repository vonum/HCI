using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HCI_FINAL
{
    partial class Form1 : Form
    {
        public List<Et> etikete;
        public List<TR> tipovi;
        public List<Rsc> resursi;

        public Form1()
        {
            etikete = new List<Et>();
            tipovi = new List<TR>();
            resursi = new List<Rsc>();
            InitializeComponent();
            //komentar

            BinaryFormatter bin = new BinaryFormatter();
            
            Stream stream = File.Open("etikete.bin", FileMode.Open);
            if(stream.Length != 0)
			    etikete = (List<Et>)bin.Deserialize(stream);
            stream.Close();

            stream = File.Open("tipovi.bin", FileMode.Open);
                if (stream.Length != 0)
            tipovi = (List<TR>)bin.Deserialize(stream);
            stream.Close();

            stream = File.Open("resursi.bin", FileMode.Open);
            if (stream.Length != 0)
                resursi = (List<Rsc>)bin.Deserialize(stream);
            stream.Close();


        }

        private void resursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resurs r = new Resurs(tipovi, etikete, resursi);
            r.Show();
        }

        private void tipResursaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipResursa tr = new TipResursa(tipovi);
            tr.Show();
        }

        private void etiketaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etiketa et = new Etiketa(etikete);
            et.Show();
        }

        private void tabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tabela t = new Tabela(resursi, tipovi);
            //t.Show();
        }

        private void sacuvajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream = File.Open("etikete.bin", FileMode.Create);
			BinaryFormatter bin = new BinaryFormatter();
			bin.Serialize(stream, etikete);
            stream.Close();

            stream = File.Open("tipovi.bin", FileMode.Create);
            bin.Serialize(stream, tipovi);
            stream.Close();

            stream = File.Open("resursi.bin", FileMode.Create);
            bin.Serialize(stream, resursi);
            stream.Close();

        }

        private void etiketeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaEtikete te = new TabelaEtikete(etikete, resursi);
            te.Show();
        }

        private void tipoviResursaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaTipovi tt = new TabelaTipovi(tipovi, resursi);
            tt.Show();
        }

        private void resursiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabela t = new Tabela(resursi, tipovi);
            t.Show();
        }
    }
}
