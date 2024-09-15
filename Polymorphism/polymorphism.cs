using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_OOP.Polymorphism
{
    public class Djur  // Bas-klass
    {
        public string Namn;

        public virtual void Ljud()  // Virtuell metod som kan skrivas över
        {
            Console.WriteLine("Detta djur gör ett ljud.");
        }
    }

    public class Hund : Djur  // Hund ärver från Djur
    {
        public override void Ljud()  // Metoden Ljud skrivs över för Hund
        {
            Console.WriteLine("Hunden skäller: Voff voff!");
        }
    }

    public class Katt : Djur  // Katt ärver från Djur
    {
        public override void Ljud()  // Metoden Ljud skrivs över för Katt
        {
            Console.WriteLine("Katten jamar: Mjau mjau!");
        }
    }
}
