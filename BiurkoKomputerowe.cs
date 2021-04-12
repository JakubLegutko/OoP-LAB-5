using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_5
{
    class BiurkoKomputerowe : Biurko
    {
        public BiurkoKomputerowe(string BiurkoColor) : base(BiurkoColor)
        {
            if (BiurkoColor == "Grey")
            {
                this.Color = BiurkoColor;
                this.Price = 1200;
            }
            else if (BiurkoColor == "White")
                this.Price = 400;
            else
            {
                Console.WriteLine("Invalid Color, Can't build...");
                return;
            }
        }
    }
}

