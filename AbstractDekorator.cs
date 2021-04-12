using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_5
{
    class AbstractDekorator : DekoratorWnetrz
    {
        public override Biurko WyprodukujBiurko(int limitCeny)
        {
            BiurkoStalowe biurko = new BiurkoStalowe("White", 300);
            if (biurko.Price > limitCeny)
                return null;
            else
                return biurko;
        }

        public override Szafa WyprodukujSzafe(int limitCeny)
        {
            SzafaTrojka szafa = new SzafaTrojka("White", 252);
            if (szafa.Price > limitCeny)
                return null;
            else
                return szafa;
        }
    }
}
