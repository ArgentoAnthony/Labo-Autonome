using LaboAutoAnimalerie.Animaux;
using LaboAutoAnimalerie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboAutoAnimalerie
{
    public class Animalerie
    {
        public static void Menu()
        {
            Console.WriteLine("Bonjour");
            bool arret = false;
            do
            {
                Console.WriteLine("Que voulez vous faire?\n" +
                                  "1. Encoder un nouvel animal\n" +
                                  "2. Lister tous les animaux\n" +
                                  "3. Afficher le nombre de chats, chiens et oiseaux\n" +
                                  "4. Vérifier si certains animaux ne sont pas décédés\n" +
                                  "5. Quitter");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        AjouterAnimal();
                        break;
                    case "2":
                        Console.Clear();
                        ListeAnimaux();
                        break;
                    case "3":
                        Console.Clear();
                        CompteurAnimaux();
                        break;
                    case "4":
                        Console.Clear();
                        PasserLaNuit();
                        break;
                    default:
                        arret = true;
                        break;
                }
            } while (!arret);
        }
        public static void CompteurAnimaux()
        {
            int cptchat = 0, cptchien = 0, cptoiseau = 0;
            foreach (Animal cheptel in FakeDB.animaux)
            {
                switch (cheptel)
                {
                    case Chat:
                        cptchat++;
                        break;
                    case Chien:
                        cptchien++;
                        break;
                    case Oiseau:
                        cptoiseau++;
                        break;

                }
            }
            Console.WriteLine("Il y a dans cette animalerie:\n" +
                               $"{cptchat} {(cptchat == 1 ? "chat" : "chats")}\n" +
                               $"{cptchien} {(cptchien == 1 ? "chien" : "chiens")}\n" +
                               $"{cptoiseau} {(cptoiseau == 1 ? "oiseau" : "oiseaux")}\n");
        }

        public static void ListeAnimaux()
        {
            foreach (Animal ch in FakeDB.animaux)
            {
                Console.WriteLine(ch);
            }
        }

        public static void AjouterAnimal()
        {
            Animal? c = Animal.Encoder();
            if (c != null)
            {
                FakeDB.animaux.Add(c);
            }
        }
        public static void PasserLaNuit()
        {
            List<Animal> AnimauxMorts = new List<Animal>();

            foreach (Animal an in FakeDB.animaux)
            {
                Random r = new Random();
                /* Exemple chien: 
                 Si (NbAleat entre 0 et 100) Mod 100 == 0 alors l'animal meurt */
                if (r.Next(0, (int)(100 / an.ProbaMort)) == 0)
                {                   
                    AnimauxMorts.Add(an);
                    //FakeDB.animaux.Remove(an);
                }
            }

            foreach (Animal cheptel in AnimauxMorts)
            {
                FakeDB.animaux.Remove(cheptel);
                Console.WriteLine(cheptel.Nom + " est malheureusement décédé cette nuit :'(\n");
            }
        }
    }
}
