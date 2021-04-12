using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_5
{
    class BiurkoStalowe : Biurko
    {
        protected int Weight;
        public BiurkoStalowe(string BiurkoColor, int Weight) : base(BiurkoColor)
        {

            if (Weight < 400)
            {
                this.Color = BiurkoColor;
                this.Weight = Weight;
                this.Price = Weight * 7;
            }
            else if (Weight < 100)
            {
                Console.WriteLine("Too Light.");
                return;
            }
            else if (Weight > 400)
            {
                this.Weight = 400;
                Price = 1600;
                this.Color = BiurkoColor;
            }
            
        }
    }
}
