using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dueldeguerriers.Classes
{
    public class Guerrier
    {
        // attributs
        private string _nom;
        private int _pointsDeVie;
        private int _nbDesAttaques;

        // propriétés 
        public string Nom { get { return _nom; } set { _nom = value; } }
        public int PointsDeVie { get { return _pointsDeVie; } set { _pointsDeVie = value; } }
        public int NbDesAttaques { get { return _nbDesAttaques; } set { _nbDesAttaques = value; } }
        public static int degats { get; set; } = 0;


        // constructor 
        public Guerrier(string nom, int pointsDeVie, int nbDesAttaques)
        {
            Nom = nom;
            PointsDeVie = pointsDeVie;
            NbDesAttaques = nbDesAttaques;
        }


        public void AfficherInfos() // Afficher dans la console les informations du guerrier
        {
            Console.WriteLine(Nom + "{PV=" + PointsDeVie + "}");
        }

        public int Attaquer()
        {
            Random rng = new Random();

            degats = rng.Next(1, 7); // 1 - 6 
            Console.WriteLine(Nom + " inflige " + degats + " dmg");
            NbDesAttaques--; 
            Console.WriteLine("Il reste " + NbDesAttaques + " attaques à " + Nom);
            return degats;
        }

        public int SubirDegats(int degats)
        {
            Console.WriteLine(Nom + " subit " + degats + " dmg");
            PointsDeVie = PointsDeVie - degats;
            return PointsDeVie;
        }


    }
}
