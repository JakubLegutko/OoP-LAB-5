using System;
using System.Collections.Generic;

namespace OoP_LAB_5
{
    class Program
    {
        static void Main(string[] args)
        {
  
           
            Console.WriteLine();
            List<DekoratorWnetrz> factories = new List<DekoratorWnetrz>() { new ScandinavianDekorator(), new AbstractDekorator(), new ClassicDekorator() };
            int i = 1;
            foreach (DekoratorWnetrz factory in factories)
            {
                
                Szafa s = factory.WyprodukujSzafe(2000 * i);
                Biurko b = factory.WyprodukujBiurko(2000 * i);
                Console.WriteLine(s);
                Console.WriteLine(b);
                Console.WriteLine("Price of " + s + " " + s.Price);
                Console.WriteLine("Price of " + b + " " + b.Price);
                i++;
            }
			

        }
    }
}
