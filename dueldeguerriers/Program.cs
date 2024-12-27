
using System;
using System.ComponentModel;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using dueldeguerriers.Classes;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Guerrier> GuerrierListe = new List<Guerrier>();


            void AfficherMenu()
            {
                Console.WriteLine("UN TRUC\n\n");
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("1 - Ajouter un guerrier \n2 - Afficher la liste des guerriers \n3 - Lancer un tournoi");
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
                // while pas esc 
                int compteur = 0;
                while (compteur < 2)
                {
                    Console.WriteLine("--- Ajouter un Guerrier ---\n\n");
                    Console.WriteLine("Quelle est la classe de votre guerrier ?");
                    Console.WriteLine("1 - Guerrier classique \n2 - Nain guerrier \n3 - Elfe Guerrier");
                    int choix = int.Parse(Console.ReadLine());
                    string classe = "";
                    switch(choix)
                    {
                        case 1:
                            classe = "Guerrier";
                            break;
                        case 2:
                            classe = "Nain";
                            break;
                        case 3:
                            classe = "Elfe";
                            break;
                        default:
                            Console.WriteLine("Erreur de saisie");
                            break;
                    }

                    Console.WriteLine("Comment s'apelle votre guerrier ?");
                    string NomGuerrier = Console.ReadLine();

                    Console.WriteLine("Combien de points de vie a-t-il ? (entre 1 et 50)");
                    int PdV = int.Parse(Console.ReadLine());

                    Console.WriteLine("Quel est son nombre d'attaques ?");
                    int NoA = int.Parse(Console.ReadLine());

                    if (classe == "Guerrier")
                    {
                        Guerrier ajout = new Guerrier(NomGuerrier, PdV, NoA);
                        GuerrierListe.Add(ajout);
                        compteur++;
                    } else if (classe == "Nain")
                    {
                        Elfe ajout = new Elfe(NomGuerrier, PdV, NoA);
                        GuerrierListe.Add(ajout);
                        compteur++;
                    } else
                    {
                        Nain ajout = new Nain(NomGuerrier, PdV, NoA, true);
                        GuerrierListe.Add((ajout));
                        compteur++;
                    }
                }

                AfficherMenu();
            }

            void AfficherListeGuerriers()
            {
                foreach (var obj in GuerrierListe)
                {
                    Console.WriteLine(obj.GetType().Name + " " + obj.Nom + " " + obj.PointsDeVie + " " + obj.NbDesAttaques);
                }
                AfficherMenu();

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
