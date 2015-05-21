using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI_FINAL
{
    [Serializable]
    class SerIkonica
    {
        public String naziv;
        public System.Drawing.Point lokacija;
        public System.Drawing.Image ikonica;

        public SerIkonica(String naziv, System.Drawing.Point lokacija, System.Drawing.Image ikonica)
        {
            this.naziv = naziv;
            this.lokacija = lokacija;
            this.ikonica = ikonica;
        }

    }
}
