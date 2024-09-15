using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_OOP.Inkapsling
{
    public class Bil
    {
        // Privata fält - dessa är inte direkt tillgängliga utanför klassen
        private string modell;
        private int hastighet;

        // Egenskaper (Properties) för att ge kontrollerad åtkomst till de privata fälten
        public string Modell
        {
            get { return modell; }
            set { modell = value; }
        }

        public int Hastighet
        {
            get { return hastighet; }
            set
            {
                // Vi kan lägga till logik för att säkerställa att hastigheten inte blir negativ
                if (value < 0)
                {
                    Console.WriteLine("Hastighet kan inte vara negativ.");
                }
                else
                {
                    hastighet = value;
                }
            }
        }

        // En metod för att öka hastigheten
        public void ÖkaHastighet(int värde)
        {
            if (värde > 0)
            {
                hastighet += värde;
                Console.WriteLine("Hastigheten har ökat med " + värde + " km/h. Ny hastighet: " + hastighet + " km/h.");
            }
            else
            {
                Console.WriteLine("Värdet måste vara positivt för att öka hastigheten.");
            }
        }
    }
}
