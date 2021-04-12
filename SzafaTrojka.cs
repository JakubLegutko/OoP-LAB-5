using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_5
{
    class SzafaTrojka : Szafa
    {
       protected int Width;
        public SzafaTrojka( string SzafaColor, int Width) : base( SzafaColor)
        {
            
            if (Width  < 400)
            {
                this.Color = SzafaColor;
                this.Width = Width;
                this.Price = Width * 4;
            }
            else if (Width < 100)
            {
                Console.WriteLine("Too Small.");
                return;
            }
            else if (Width > 400)
            {
                this.Width = 400;
                Price = 1600;
                this.Color = SzafaColor;
            }
           
        }
    }
}
