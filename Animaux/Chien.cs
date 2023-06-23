using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboAutoAnimalerie.Animaux
{
    public enum CouleurCollier
    {
        Rouge,
        Noir,
        Blanc,
        Bleu,
        Orange
    }
    public enum Race
    {
        Akita,
        Beagle,
        Berger,
        Bouledogue,
        Chihuahua,
        Dalmatien,
        Dobermann,
        Husky,
        Pitbull,
        Shiba
    }
    public class Chien : Animal
    {
        public Chien(string nom, string sexe, DateTime dateArrivee)
        {
            Random r = new Random();
            Nom = nom;
            Poids = r.Next(5, 55) + 1;
            Taille = r.Next(30, 115) + 1;
            Sexe = sexe;
            Age = r.Next(0, 150);
            DateArrivee = dateArrivee;
            CouleurCollier = (CouleurCollier)r.Next(0, 4);
            int Dress = r.Next(0, 2);
            if (Dress == 0) { Dressage = true; } else { Dressage = false; }
            Race = (Race)r.Next(0, 10);
            ProbaMort = 1;
        }
        public CouleurCollier CouleurCollier { get; set; }
        public bool Dressage { get; set; }
        public Race Race { get; set; }
        public override void Crier()
        {
            Console.WriteLine("Wouf");
        }
        public override string ToString()
        {
            Crier();
            return $"Nom : {Nom}\n" +
                   $"Sexe : {Sexe}\n" +
                   $"Race : {Race} \n" +
                   $"Poids : {Poids} kg\n" +
                   $"Age : {Age / 12} ans\n" +
                   $"Taille : {Taille} cm\n" +
                   $"Couleur du collier : {CouleurCollier} \n" +
                   $"Dressé : {Dressage} \n" +
                   $"Date d'arrivée : {DateArrivee}\n" +
                   "--------------------------------------------";
        }
    }
}
