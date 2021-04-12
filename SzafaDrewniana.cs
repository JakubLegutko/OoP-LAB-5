using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_5
{
    class SzafaDrewniana : Szafa
    {
      
       protected string WoodType;

        public SzafaDrewniana( string SzafaColor, string WoodType) : base(SzafaColor)
        {
            
            if (WoodType == "Mahogany")
            {
                this.Color = SzafaColor;
                this.WoodType = WoodType;
                this.Price = 1000;
            } else if (WoodType == "Pine")
            {
                this.Color = SzafaColor;
                this.WoodType = WoodType;
                this.Price = 250;
            }
            else if (WoodType == "Chipboard")
            {
                this.Color = SzafaColor;
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
