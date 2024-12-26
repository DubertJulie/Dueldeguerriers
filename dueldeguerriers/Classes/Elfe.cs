using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dueldeguerriers.Classes
{
    public class Elfe : Guerrier
    {
        private bool ArmureLourde;
        public Elfe(string nom, int pointsDeVie, int nbDesAttaques)
        : base(nom, pointsDeVie, nbDesAttaques) 
        {
        }
        public int Attaquer()
        {
            Random rng = new Random();

            degats = rng.Next(1, 7); // 1 - 6 
           

            if (degats <= 1)
            {
                Console.WriteLine("Retournement de situation ! " + Nom + " inflige " + degats + " dmg");
                degats += 1;
            } else
            {
                Console.WriteLine(Nom + " inflige " + degats + " dmg");
            }
            NbDesAttaques--;
            Console.WriteLine("Il reste " + NbDesAttaques + " attaques à " + Nom);
            return degats;
        }
    }
}
