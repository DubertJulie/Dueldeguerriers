
using System;
using System.Security.Cryptography.X509Certificates;
using dueldeguerriers.Classes;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            void AfficherMenu()
            {
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("1 - Ajouter un guerrier \n2 - Lancer un duel \n3 - Lancer un tournoi");
                ConsoleKeyInfo key;

                key = Console.ReadKey();
                Console.WriteLine("Touche du clavier = " + key.Key);

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.F1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        AjouterGuerrier();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.F2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        AfficherListeGuerriers();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.F3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        LancerTournoi();
                        break;
                }
            }

            AfficherMenu();


            void AjouterGuerrier()
            {
                Console.WriteLine("test menu 1");
            }

            void AfficherListeGuerriers()
            {
                Console.WriteLine("test menu 2");
            }

            void LancerTournoi()
            {
                Console.WriteLine("test menu 3");
            }

            ////Guerrier britney = new Guerrier("Britney", 35, 3);
            ////Guerrier kourtney = new Guerrier("Kourtney", 30, 4);
            //Nain whitney = new Nain("Whitney", 28, 3, true);
            //Elfe sydney = new Elfe("Sydney", 28, 3);

            //////britney.AfficherInfos();
            //////britney.SubirDegats(kourtney.Attaquer()); // Brit subit les débats de l'attaque de Kourt
            //////britney.AfficherInfos();

            //////kourtney.AfficherInfos();
            //////kourtney.SubirDegats(britney.Attaquer());
            //////kourtney.AfficherInfos();

            //whitney.AfficherInfos();
            //whitney.SubirDegats(sydney.Attaquer());
            //whitney.AfficherInfos();
        }




    }
}
