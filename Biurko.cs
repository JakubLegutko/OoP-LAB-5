using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_5
{
    abstract class Biurko
    {
        public int Price;
        protected string Color;

       
        public Biurko(string BiurkoColor)
        {

            if (BiurkoColor == "Purple")
            {
                this.Color = BiurkoColor;
                this.Price = 120;
            }
            else if (BiurkoColor == "White")
                this.Price = 40;
            else
            {
                Console.WriteLine("Invalid Color, Can't build...");
                return;
            }

        }
    }
}
