﻿using System;
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
        public List<SerIkonica> ikonice;
        public PictureBox selectedPB;


        private Rectangle _mouseDownSelekcioniProzor;
        private Point _ofsetEkrana;
        private TreeNode _indeksPrevucenogCvora;
        private Point pos;
        private bool isSelected;

        public Form1()
        {
            etikete = new List<Et>();
            tipovi = new List<TR>();
            resursi = new List<Rsc>();
            ikonice = new List<SerIkonica>();
            isSelected = false;
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

            stream = File.Open("ikonice.bin", FileMode.Open);
            if (stream.Length != 0)
                ikonice = (List<SerIkonica>)bin.Deserialize(stream);
            stream.Close();



        }

        private void resursToolStripMenuItem_Click(object sender, EventArgs e)                  //dodavanje resursa
        {
            Resurs r = new Resurs(tipovi, etikete, resursi, this);
            r.Show();
        }

        private void tipResursaToolStripMenuItem_Click(object sender, EventArgs e)              //dodavanje tipa resursa
        {
            TipResursa tr = new TipResursa(tipovi);
            tr.Show();
        }

        private void etiketaToolStripMenuItem_Click(object sender, EventArgs e)                 //dodavanje etikete
        {
            Etiketa et = new Etiketa(etikete);
            et.Show();
        }

        private void tabelaToolStripMenuItem_Click(object sender, EventArgs e)                     //my nigga
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

            stream = File.Open("ikonice.bin", FileMode.Create);
            bin.Serialize(stream, ikonice);
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
            Tabela t = new Tabela(resursi, tipovi, this);
            t.Show();
        }

        protected override void OnLoad(EventArgs e)                             //ucitavanje stabla**********/
        {
            foreach(Rsc resurs in resursi)
            {
                stablo.Nodes[0].Nodes.Add(resurs.naziv);
            }

            foreach (SerIkonica ikonica in ikonice)                             //izmeniti ovaj deo
            {
                PictureBox p = new PictureBox();
                p.ContextMenuStrip = contextMenuStrip1;
                p.Image = ikonica.ikonica;
                p.Location = ikonica.lokacija;
                p.Size = new Size(30, 30);
                p.Name = ikonica.naziv;
                p.MouseClick += new MouseEventHandler(selectImage);
                p.MouseHover += new EventHandler(hover);
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.MouseMove += new MouseEventHandler(move);
                p.MouseDown += new MouseEventHandler(down);
                p.MouseUp += new MouseEventHandler(up);
                this.panel1.Controls.Add(p); 
            }
        }

        private void stablo_MouseDown(object sender, MouseEventArgs e)          //pritisak na treenode u stablu
        {
            _indeksPrevucenogCvora = stablo.GetNodeAt(e.Location);
            if (_indeksPrevucenogCvora != null)                                    //ako je kliknuto na treenode
            {
                stablo.SelectedNode = _indeksPrevucenogCvora;
                if (_indeksPrevucenogCvora.GetNodeCount(true) == 0 && _indeksPrevucenogCvora.ForeColor != Color.Gray)
                {

                    System.Drawing.Size dragVelicina = SystemInformation.DragSize;
                    _mouseDownSelekcioniProzor = new Rectangle(new Point(e.X - (dragVelicina.Width / 2), e.Y - (dragVelicina.Height / 2)), dragVelicina);
                }
                else
                {
                    _mouseDownSelekcioniProzor = Rectangle.Empty;
                }

            }
        }

        private void stablo_MouseMove(object sender, MouseEventArgs e)              //pomeranje misa
        {
            if (e.Button == MouseButtons.Left)                                      //postavljanje kursora na odgovarajuci
            {
                if (_mouseDownSelekcioniProzor != Rectangle.Empty && !_mouseDownSelekcioniProzor.Contains(e.X, e.Y))
                {
                    _ofsetEkrana = SystemInformation.WorkingArea.Location;
                    DragDropEffects dropEfekat = stablo.DoDragDrop(_indeksPrevucenogCvora, DragDropEffects.Copy);
                }
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)                       //ulazak kursorom na panel
        {
            Type testTip = new TreeNode().GetType();

            if (e.Data.GetDataPresent(testTip))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)                         //dodavanje ikonice na panel
        {
            Type testTip = new TreeNode().GetType();
            Type testTip2 = new PictureBox().GetType();
            _mouseDownSelekcioniProzor = Rectangle.Empty;

            if (e.Data.GetDataPresent(testTip))
            {
                Point screenCords = Cursor.Position;
                Point panelCords = panel1.PointToClient(screenCords);

                PictureBox p = new PictureBox();

                TreeNode tmp = (TreeNode)e.Data.GetData(testTip);

                foreach (Rsc resurs in resursi)
                {
                    if (resurs.naziv.Equals(tmp.Text))
                    {
                        p.Name = resurs.naziv;
                        p.Image = resurs.ikonica;
                        break;
                    }
                }

                p.ContextMenuStrip = contextMenuStrip1;
                p.MouseClick += new MouseEventHandler(selectImage);
                p.DoubleClick += new EventHandler(editFromMap);
                p.MouseHover += new EventHandler(hover);
                p.MouseMove += new MouseEventHandler(move);
                p.MouseDown += new MouseEventHandler(down);
                p.MouseUp += new MouseEventHandler(up);
                p.Size = new Size(30, 30);
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Location = panelCords;

                panel1.Controls.Add(p);
                ikonice.Add(new SerIkonica(p.Name, p.Location, p.Image)); //dodavanje u listu za serijalizaciju
            }

        }

        private void selectImage(object sender, MouseEventArgs e)           //postavljanje bordera na selectovani picturebox
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (PictureBox p in panel1.Controls)
                {
                    p.BorderStyle = BorderStyle.None;
                }

                selectedPB = (PictureBox)sender;    
                ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                foreach (Rsc resurs in resursi)
                {
                    if (((PictureBox)sender).Name.Equals(resurs.naziv))
                    {
                        Izmena izm = new Izmena(tipovi, resurs, new Tabela(resursi, tipovi, this), etikete, this);
                        izm.Show();
                        break;
                    }
                }
            }

            foreach (TreeNode node in stablo.Nodes[0].Nodes)
            {
                if (((PictureBox)sender).Name.Equals(node.Text))
                    stablo.SelectedNode = node;
            }

            stablo.SelectedImageIndex = stablo.SelectedNode.ImageIndex;

        }

        private void tmpToolStripMenuItem_Click(object sender, EventArgs e)             //brisanje ikonica sa mape
        {   
            if (selectedPB != null)
            {
                panel1.Controls.Remove(selectedPB);
                foreach (SerIkonica ikonica in ikonice)
                {
                    if (ikonica.lokacija.Equals(selectedPB.Location))
                    {
                        ikonice.Remove(ikonica);
                        break;
                    }
                }
                selectedPB = null;
            }
        }

        private void editFromMap(object sender, EventArgs e)
        {
            foreach (Rsc resurs in resursi)
            {
                if (((PictureBox)sender).Name.Equals(resurs.naziv))
                {
                    Izmena izm = new Izmena(tipovi, resurs, new Tabela(resursi, tipovi, this), etikete, this);
                    izm.Show();
                    break;
                }
            }
        }

        private void down(object sender, MouseEventArgs e)                  //klik na picturebox
        {
            if (e.Button != MouseButtons.Left)
                return;
            isSelected = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }

        private void move(object sender, MouseEventArgs e)                  //pomeranje picturebox-a
        {
            if (isSelected)
            {
                //((PictureBox)sender).Location = e.Location;
                ((PictureBox)sender).Top = e.Y + ((PictureBox)sender).Top - pos.Y;
                ((PictureBox)sender).Left = e.X + ((PictureBox)sender).Left - pos.X;
                
            }
        }

        private void up(object sender, MouseEventArgs e)            //NUBOVSKI  pustanje picturebox-a
        {
            isSelected = false;

            List<PictureBox> tmp = new List<PictureBox>();

            foreach (PictureBox pb in panel1.Controls)
            {
                tmp.Add(pb);
            }

            Point pos = panel1.PointToClient(Cursor.Position);

            if (pos.X >= 578 && pos.X <= 628 && pos.Y >= 547 && pos.Y <= 597)
            {
                //578, 547
                int idx = tmp.IndexOf((PictureBox)sender);
                panel1.Controls.Remove((PictureBox)sender);
                ikonice.RemoveAt(idx - 1);
            }
            else
            {
                int idx = tmp.IndexOf((PictureBox)sender);
                ikonice.ElementAt(idx - 1).lokacija = ((PictureBox)sender).Location;
            }
        }

        private void hover(object sender, EventArgs e)
        {


        }

        public void removePB(Rsc resurs)                                //IZMENITI NUBOVSKI KOD
        {
            List<PictureBox> tmp = new List<PictureBox>();

            foreach (PictureBox pb in panel1.Controls)
            {
                if (pb.Name.Equals(resurs.naziv))
                    tmp.Add(pb);
            }

            for (int i = tmp.Count - 1; i >= 0; i--)
            {
                if (tmp.ElementAt(i).Name.Equals(resurs.naziv))
                    panel1.Controls.Remove(tmp.ElementAt(i));
            }


            for (int i = ikonice.Count - 1; i >= 0; i--)
            {
                if (ikonice.ElementAt(i).naziv.Equals(resurs.naziv))
                    ikonice.RemoveAt(i);
            }


        }

        public void changeImage(Rsc resurs)
        {
            foreach (PictureBox pb in panel1.Controls)
            {
                if (pb.Name.Equals(resurs.naziv))
                    pb.Image = resurs.ikonica;
            }
        }

        protected override CreateParams CreateParams                    //nigga
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void stablo_MouseClick(object sender, MouseEventArgs e)            
        {

            if (e.Button == MouseButtons.Left)
            {
                TreeNode sel = stablo.GetNodeAt(e.Location);
                if (sel != null)
                {
                    stablo.SelectedNode = sel;
                    foreach (PictureBox pb in panel1.Controls)
                    {
                        if (pb.Name.Equals(sel.Text))
                        {
                            pb.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            pb.BorderStyle = BorderStyle.None;
                        }
                    }

                    stablo.SelectedImageIndex = stablo.SelectedNode.ImageIndex;

                }
            }
            else
            {
                TreeNode sel = stablo.GetNodeAt(e.Location);
                stablo.SelectedNode = sel;
                stablo.SelectedImageIndex = stablo.SelectedNode.ImageIndex;

                if (sel != null)
                {
                    contextMenuStrip1.Show();
                }
            }
        }

        public void reloadForm()
        {
            imageList1.Images.Clear();
            imageList1.Images.Add(Image.FromFile("rsc.png"));
            stablo.Nodes.Clear();
            stablo.Nodes.Add("resursi");
            int i = 0;
            foreach (Rsc resurs in resursi)
            {
                stablo.Nodes[0].Nodes.Add(resurs.naziv);
                imageList1.Images.Add(resurs.ikonica);
                stablo.Nodes[0].Nodes[i].ImageIndex = ++i;
            }

        }

        public void reloadMap()
        {
            foreach (Rsc r in resursi)
            {
                foreach (SerIkonica i in ikonice)
                {
                    if (i.naziv.Equals(r.naziv))
                    {
                        i.ikonica = r.ikonica;
                    }
                }
                foreach (PictureBox pb in panel1.Controls)
                {
                    if (pb.Name.Equals(r.naziv))
                    {
                        pb.Image = r.ikonica;
                    }
                }
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            reloadForm();
            reloadMap();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)                   //autosave
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

            stream = File.Open("ikonice.bin", FileMode.Create);
            bin.Serialize(stream, ikonice);
            stream.Close();
        }

        private void resursToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tutorijal t = new Tutorijal(1);
            t.Show();
        }

        private void tipResursaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tutorijal t = new Tutorijal(2);
            t.Show();
        }

        private void etiketaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tutorijal t = new Tutorijal(3);
            t.Show();
        }

        private void resursToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Tutorijal t = new Tutorijal(4);
            t.Show();
        }

        private void tipResursaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Tutorijal t = new Tutorijal(5);
            t.Show();
        }

        private void etiketaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Tutorijal t = new Tutorijal(6);
            t.Show();
        }

        private void resursToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Tutorijal t = new Tutorijal(7);
            t.Show();
        }

        private void tipResursaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Tutorijal t = new Tutorijal(8);
            t.Show();
        }

        private void etiketaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Tutorijal t = new Tutorijal(9);
            t.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "HelpPls.chm");
        }

        private void izmeni_Click(object sender, EventArgs e)
        {
            Control sourceControl = null;

            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    sourceControl = owner.SourceControl;
                }
            }

            if (sourceControl.GetType() == typeof(TreeView))
            {
                TreeNode tmp = ((TreeView)sourceControl).SelectedNode;
                Rsc resurs = null;
                if(tmp != null)
                foreach (Rsc r in resursi)
                {
                    if (r.naziv.Equals(tmp.Text))
                    {
                        resurs = r;
                        break;
                    }
                }
                if(resurs != null)
                {
                    Izmena i = new Izmena(tipovi, resurs, new Tabela(resursi, tipovi, this), etikete, this);
                    i.Show();
                }

                reloadForm();
                reloadMap();
            }
            else if (sourceControl.GetType() == typeof(PictureBox))
            {
                Rsc resurs = null;
                PictureBox tmp = (PictureBox)sourceControl;
                foreach (Rsc r in resursi)
                {
                    if (r.naziv.Equals(tmp.Name))
                    {
                        resurs = r;
                        break;
                    }
                }

                if (resurs != null)
                {
                    Izmena i = new Izmena(tipovi, resurs, new Tabela(resursi, tipovi, this), etikete, this);
                    i.Show();
                }

                reloadForm();
                reloadMap();

            }

        }

        private void obrisi_Click(object sender, EventArgs e)
        {
            Control sourceControl = null;

            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    sourceControl = owner.SourceControl;
                }
            }

            if (sourceControl.GetType() == typeof(TreeView))
            {
                TreeNode tmp = ((TreeView)sourceControl).SelectedNode;
                Rsc resurs = null;

                if (tmp != null)
                {
                    foreach (Rsc r in resursi)
                    {
                        if (r.naziv.Equals(tmp.Text))
                        {
                            resurs = r;
                            break;
                        }
                    }

                    List<PictureBox> pbs = new List<PictureBox>();

                    foreach (PictureBox pb in panel1.Controls)
                    {
                        if (pb.Name.Equals(resurs.naziv))
                        {
                            pbs.Add(pb);
                        }
                    }

                    for (int i = pbs.Count - 1; i >= 0; i--)
                    {
                        panel1.Controls.Remove(pbs.ElementAt(i));
                    }

                    for (int i = ikonice.Count - 1; i >= 0; i--)
                    {
                        if (ikonice.ElementAt(i).naziv.Equals(resurs.naziv))
                        {
                            ikonice.RemoveAt(i);
                        }
                    }

                    resursi.Remove(resurs);

                    reloadForm();
                    reloadMap();
                }
            }
            else if (sourceControl.GetType() == typeof(PictureBox))
            {
                PictureBox rm = (PictureBox)sourceControl;
                int idx = panel1.Controls.IndexOf(rm);
                ikonice.RemoveAt(idx - 1);                      //zbog slike kantice, index picturebox-a je jednak indexu u listi za serijalizaciju + 1
                panel1.Controls.Remove(rm);
            }

        }



    }
}
