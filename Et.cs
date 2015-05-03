using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI_FINAL
{
    [Serializable]
    class Et
    {
        public String oznaka;
        public String opis;
        public System.Drawing.Color color;

        public Et() {}
        public Et(String oznaka, String opis, System.Drawing.Color color)
        {
            this.color = color;
            this.oznaka = oznaka;
            this.opis = opis;
        }

        public Object[] toString()
        {
            return new String[] { oznaka, opis, color.ToString(), "Izmeni", "Obrisi" };
        }

    }
}
