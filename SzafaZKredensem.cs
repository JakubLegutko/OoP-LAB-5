using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_5
{
    class SzafaZKredensem : Szafa
    {
        protected bool Window;
        public SzafaZKredensem( string SzafaColor, bool HasWindow) : base( SzafaColor)
        {

            if (HasWindow)
            {
                this.Color = SzafaColor;
                this.Price = 2000;
                this.Window = HasWindow;
            }
            else 
            {
                
                Price = 1200;
                this.Color = SzafaColor;
                this.Window = HasWindow;
            }
            
        }
    }
}

