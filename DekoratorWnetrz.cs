using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_5
{
    abstract class DekoratorWnetrz
    {
        public abstract Biurko WyprodukujBiurko(int limitCeny);

        public abstract Szafa WyprodukujSzafe(int limitCeny);
    }
}
