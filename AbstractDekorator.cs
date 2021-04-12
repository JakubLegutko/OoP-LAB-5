using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_5
{
    class AbstractDekorator : DekoratorWnetrz
    {
        public override Biurko WyprodukujBiurko(int limitCeny)
        {
            return null;
        }

        public override Szafa WyprodukujSzafe(int limitCeny)
        {
            return null;
        }
    }
}
