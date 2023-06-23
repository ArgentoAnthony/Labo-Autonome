using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LaboAutoAnimalerie.Animaux
{
    public enum Caractere
    {
        Energique,
        Farouche,
        Calin,
        Amitieux,
        Peureux
    }
    public class Chat : Animal
    {
        public Chat(string nom, string sexe, DateTime dateArrivee)
        {
            Random r = new Random();
            Nom = nom;
            Poids = r.Next(1, 5) + 1;
            Taille = r.Next(10, 30) + 1;
            Sexe = sexe;
            Age = r.Next(0, 150);
            DateArrivee = dateArrivee;
            Caractere = (Caractere)r.Next(0, 5);
            int GC = r.Next(0, 2);
            if (GC == 0) { GriffesCoupees = true; } else {  GriffesCoupees = false; }
            int PL = r.Next(0, 2);
            if (PL == 0) { PoilsLong = true; } else { PoilsLong = false; }
            ProbaMort = 0.5;
        }
        public Caractere Caractere { get; set; }
        private bool GriffesCoupees { get; set; }
        private bool PoilsLong { get; set; }
        public override void Crier()
        {
            Console.WriteLine("Miaou");
        }
        public override string ToString()
        {
            Crier();
            return $"Nom : {Nom}\n" +
                   $"Sexe : {Sexe}\n" +
                   $"Poids : {Poids} kg\n" +
                   $"Age : {Age / 12} ans\n" +
                   $"Taille : {Taille} cm\n" +
                   $"Caractère : {Caractere} \n" +
                   $"Griffes coupées : {GriffesCoupees} \n" +
                   $"Poils long : {PoilsLong} \n" +
                   $"Date d'arrivée : {DateArrivee}\n" +
                   "--------------------------------------------";

        }
    }
}
