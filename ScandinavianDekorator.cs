using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_5
{
    class ScandinavianDekorator : DekoratorWnetrz
    {
        public override Biurko WyprodukujBiurko(int limitCeny)
        {
            BiurkoBiurowe biurko = new BiurkoBiurowe("Yellow", true);
            if (biurko.Price > limitCeny)
                return null;
            else 
                return biurko;
        }

        public override Szafa WyprodukujSzafe(int limitCeny)
        {
            SzafaIkea szafa = new SzafaIkea("Grey");
            if (szafa.Price > limitCeny)
                return null;
            else
                return szafa;
        }
    }
}
