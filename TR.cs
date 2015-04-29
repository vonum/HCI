using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI_FINAL
{
    class TR
    {
        public String naziv;
        public String oznaka;
        public String opis;
        public System.Drawing.Image ikonica;

        public TR() { }
        public TR(String naziv, String oznaka, String opis, System.Drawing.Image ikonica)
        {
            this.naziv = naziv;
            this.oznaka = oznaka;
            this.opis = opis;
            this.ikonica = ikonica;
        }

    }
}
