using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_5
{
    class SzafaIkea : Szafa
    {
        public SzafaIkea(string SzafaColor) : base( SzafaColor)
        {

            if (SzafaColor == "Grey")
            {
                this.Color = SzafaColor;
                this.Price = 120;
            }
            else if (SzafaColor == "White")
                this.Price = 40;
            else
            {
                Console.WriteLine("Invalid Color, Can't build...");
                return;
            }

        }
    }
}

