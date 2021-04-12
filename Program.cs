using System;
using System.Collections.Generic;

namespace OoP_LAB_5
{
    class Program
    {
        static void Main(string[] args)
        {
  
           
            Console.WriteLine();
            List<DekoratorWnetrz> factories = new List<DekoratorWnetrz>() { new ScandinavianDekorator(), 
               };
            int i = 1;
            foreach (DekoratorWnetrz factory in factories)
            {
                
                Szafa s = factory.WyprodukujSzafe(200 * i);
                Console.WriteLine(s);
                i++;
            }
			

        }
    }
}
