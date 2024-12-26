using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dueldeguerriers.Classes
{
    public class Nain : Guerrier
    {
        private bool ArmureLourde;
        public Nain(string nom, int pointsDeVie, int nbDesAttaques, bool armurelourde)
        : base(nom, pointsDeVie, nbDesAttaques) // Appelle le constructeur de Guerrier
        {
            ArmureLourde = armurelourde;
        }

        public int SubirDegats(int degats)
        {
            if (ArmureLourde == true)
            {
                Console.WriteLine(Nom + " ne subit que " + degats / 2 + " dmg grâce à son armure");
                PointsDeVie = PointsDeVie - (degats / 2);
                return PointsDeVie;
            } else
            {
                Console.WriteLine(Nom + " subit " + degats + " dmg !!");
                PointsDeVie = PointsDeVie - degats;
                return PointsDeVie;
            }
        }
    }
}
