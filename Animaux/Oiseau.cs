using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboAutoAnimalerie.Animaux
{
    public enum Couleur
    {
        Rouge,
        Bleu,
        Blanc,
        Orange,
    }
    public enum Cage
    {
        Grande,
        Petite
    }
    public class Oiseau : Animal
    {

        public Oiseau(string nom, string sexe, DateTime dateArrivee)
        {
            Random r = new Random();
            Nom = nom;
            Poids = r.Next(1, 3) + 1;
            Taille = r.Next(5, 30) + 1;
            Sexe = sexe;
            Age = r.Next(0, 150);
            DateArrivee = dateArrivee;
            Cage = (Cage)r.Next(0, 2);
            Couleur = (Couleur)r.Next(0, 10);
            ProbaMort = 3;
        }
        public Cage Cage { get; set; }
        public Couleur Couleur { get; set; }
        public bool GrandeCage { get; set; }  
        public override void Crier()
        {
            Console.WriteLine("Libérez-moi!");
        }
        public override string ToString()
        {
            Crier();
            return $"Nom : {Nom}\n" +
                   $"Sexe : {Sexe}\n" +
                   $"Couleur : {Couleur} \n" +
                   $"Poids : {Poids} kg\n" +
                   $"Age : {Age / 12} ans\n" +
                   $"Taille : {Taille} cm\n" +
                   $"Taille de la cage : {Cage} \n" +
                   $"Date d'arrivée : {DateArrivee}\n" +
                   "--------------------------------------------";
        }
    }
}
