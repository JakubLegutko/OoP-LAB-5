using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_5
{
    class BiurkoBiurowe : Biurko
    {
        protected bool Lift;
        public BiurkoBiurowe(string BiurkoColor, bool HasLift) : base(BiurkoColor)
        {

            if (HasLift)
            {
                this.Color = BiurkoColor;
                this.Price = 1200;
                this.Lift = HasLift;
            }
            else if (BiurkoColor == "White")
            {
                this.Price = 800;
                this.Color = BiurkoColor;
                this.Lift = HasLift;
            }
            else
            {
                Console.WriteLine(" Can't build Biurko that isn't White and has no lift.");
                return;
            }

        }

    }
}
