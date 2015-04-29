using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI_FINAL
{
    enum Frekvencija { REDAK, CEST, UNIVERZALAN };
    enum JedinicaMere { MERICA, BAREL, TONA, KG };


    class Rsc
    {
        public String naziv;
        public String oznaka;
        public String opis;
        public TR tip;
        public bool obnovljiv;
        public bool eskploativ;
        public bool str_vaznost;
        public String datum;
        public System.Drawing.Image ikonica;
        public List<Et> etikete;
        public int cena;
        public Frekvencija frekv;
        public JedinicaMere jm;

        public Rsc()
        {
            etikete = new List<Et>();
        }


    }
}
