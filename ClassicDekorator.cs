using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_5
{
    class ClassicDekorator : DekoratorWnetrz
    {
        public override Biurko WyprodukujBiurko(int limitCeny)
        {
            BiurkoDrewniane biurko = new BiurkoDrewniane("White", "Mahogany");
            if (biurko.Price > limitCeny)
                return null;
            else
                return biurko;
        }

        public override Szafa WyprodukujSzafe(int limitCeny)
        {
            SzafaDrewniana szafa = new SzafaDrewniana("White", "Pine");
            if (szafa.Price > limitCeny)
                return null;
            else
                return szafa;
        }
    }
}
