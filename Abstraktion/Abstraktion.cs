using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_OOP.Abstraktion
{
    // Abstrakt klass som representerar ett allmänt fordon
    public abstract class Fordon
    {
        // Egenskap för fordonets namn
        public string Namn { get; set; }

        // Abstrakt metod som tvingar underklasserna att implementera
        public abstract void Kör();

        // En vanlig metod som alla underklasser kan använda
        public void Stanna()
        {
            Console.WriteLine(Namn + " har stannat.");
        }
    }

    // En klass som ärver från Fordon och implementerar den abstrakta metoden
    public class Bil : Fordon
    {
        // Implementering av den abstrakta metoden Kör
        public override void Kör()
        {
            Console.WriteLine(Namn + " kör på vägen.");
        }
    }

    // En annan klass som ärver från Fordon
    public class Båt : Fordon
    {
        // Implementering av den abstrakta metoden Kör
        public override void Kör()
        {
            Console.WriteLine(Namn + " seglar på vattnet.");
        }
    }
}
