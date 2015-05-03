using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI_FINAL
{
    enum Frekvencija { REDAK, CEST, UNIVERZALAN };
    enum JedinicaMere { MERICA, BAREL, TONA, KG };

    [Serializable]
    class Rsc
    {
        public String naziv;
        public String oznaka;
        public String opis;
        public TR tip;
        public bool obnovljiv;
        public bool eskploativ;
        public bool str_vaznost;
        public String datum;                            //TREBA UBACITI
        public System.Drawing.Image ikonica;
        public List<Et> etikete;
        public int cena;
        public Frekvencija frekv;
        public JedinicaMere jm;

        public Rsc()
        {
            etikete = new List<Et>();
        }

        public Object[] toString()
        {
            String _naziv = naziv;
            String _oznaka = oznaka;
            String _tip = tip.naziv;
            String _frekv;
            if (frekv == Frekvencija.CEST)
                _frekv = "Cest";
            else
                if (frekv == Frekvencija.REDAK)
                    _frekv = "Redak";
                else
                    _frekv = "Univerzalan";
            String _obnovljiv = (obnovljiv) ? "Obnovljiv" : "Neobnovljiv";
            String _cena = cena.ToString();

            return new Object[] { _naziv, _oznaka, _tip, _frekv, _obnovljiv, _cena, "Izmeni", "Obrisi" };
        }

        public bool check(String tip, String naziv, String cena)
        {
            int cnt = 0;
            int crit = 0;

            if (!tip.Equals(""))
                crit++;
            if (!naziv.Equals(""))
                crit++;
            if (!cena.Equals(""))
                crit++;

            if (!tip.Equals(""))
                if (this.tip.naziv.IndexOf(tip) != -1)
                    cnt++;
            if (!naziv.Equals(""))
                if (this.naziv.IndexOf(naziv) != -1)
                    cnt++;
            if (!cena.Equals(""))
                if (this.cena <= int.Parse(cena))
                    cnt++;

            if (cnt == crit)
                return true;

            return false;

        }

    }
}
