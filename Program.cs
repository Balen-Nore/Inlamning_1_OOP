using Inlämning_1_OOP.Arv;
using Inlämning_1_OOP.Polymorphism;

namespace Inlämning_1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Djur djur1 = new Djur();
            djur1.Vila();  // Skriver ut "Detta djur vilar för att återhämta energi."

            Djur djur2 = new Djur();
            djur2.Äta();  // Skriver ut "Detta djur äter för att fylla på energi."

            Hund hund = new Hund();
            hund.Äta();  // Skriver ut "Denna hund älskar att äta när den är hungrig!"
        }
    }

}
