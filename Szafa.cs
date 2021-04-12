using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_5
{
   abstract class Szafa
    {
        public int Price;

       protected string Color;
        
        public Szafa( string SzafaColor)
        {

            if (SzafaColor == "Yellow")
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
