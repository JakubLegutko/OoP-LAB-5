using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_5
{
    class BiurkoDrewniane : Biurko
    {
        protected string WoodType;

        public BiurkoDrewniane(string BiurkoColor, string WoodType) : base(BiurkoColor)
        {

            if (WoodType == "Mahogany")
            {
                this.Color = BiurkoColor;
                this.WoodType = WoodType;
                this.Price = 1000;
            }
            else if (WoodType == "Pine")
            {
                this.Color = BiurkoColor;
                this.WoodType = WoodType;
                this.Price = 250;
            }
            else if (WoodType == "Chipboard")
            {
                this.Color = BiurkoColor;
                this.WoodType = WoodType;
                this.Price = 100;
            }
            else
            {
                Console.WriteLine("Invalid WoodType, can't build.. ");
                return;
            }


        }
    }
}
    
