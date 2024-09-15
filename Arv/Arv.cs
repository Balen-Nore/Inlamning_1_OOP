using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_OOP.Arv
{

    public class Djur // Huvudklassen för Djur
    {
        // Attributer av klassen Djur
        public string Namn;

        public int Ålder;

        public void Äta()  // Metod
        {
            Console.WriteLine("Detta djur kan äta och fylla på energi");
        }

        public void Vila() // Metod
        {
            Console.WriteLine("Detta djur vilar för att återhämta energi");
        }
    }

    public class Hund : Djur // Nya attributer + alla andra attributer av huvudklassen
    {
        public string Ras;

        public new void Äta() // Ny metod
        {
            Console.WriteLine("Denna hund älskar att äta när den är hungrig!");
        }
    }
}

