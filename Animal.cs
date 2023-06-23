using LaboAutoAnimalerie.Animaux;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LaboAutoAnimalerie
{
    public abstract class Animal
    {
        public string Nom { get; set; }
        protected int Poids { get; set; }
        protected int Taille { get; set; }
        protected string Sexe { get; set; }
        protected int Age { get; set; }
        protected DateTime DateArrivee { get; set; }
        public double ProbaMort { get; set; }
     
        public virtual void Crier() { }
        public static Animal? Encoder()
        {
            string sexe;
            string nom;
            int jour, mois, annee;
            DateTime DateArrivee;
            Console.WriteLine("Quelle espèce voulez vous ajouter?");
            Console.WriteLine("1: Chat");
            Console.WriteLine("2: Chien");
            Console.WriteLine("3: Oiseau");
            Console.WriteLine("4: Quitter");

            switch (Console.ReadLine())
            {
                case "1":                    
                    NouvelAnimal(out sexe, out nom, out DateArrivee);
                    return new Chat(nom, sexe, DateArrivee);
                case "2":
                    NouvelAnimal(out sexe, out nom, out DateArrivee);
                    return new Chien(nom, sexe, DateArrivee);
                case "3":
                    NouvelAnimal(out sexe, out nom, out DateArrivee);
                    return new Oiseau(nom, sexe, DateArrivee);
                default:
                    return null;
            }
            
        }

        private static void NouvelAnimal(out string sexe, out string nom, out DateTime DateArrivee)
        {
            int mois, jour, annee;
            Console.WriteLine("Quel est son nom?");
            nom = Console.ReadLine();
            do
            {
                Console.WriteLine("Quel est son sexe? M/F");
                sexe = Console.ReadLine().ToUpper();
            } while (sexe != "M" && sexe != "F");
            //demander jour mois année
            Console.WriteLine("Quand est il arrivé?");
            // Jour:
            jour = Enumerable.Range(1, 31).FirstOrDefault(i =>
            {
                Console.WriteLine("Entrez le jour (en chiffre) :");
                return int.TryParse(Console.ReadLine(), out int result) && result >= 1 && result <= 31;
            });
            #region Explication LINQ
            /*Dans cette version, nous utilisons la méthode Enumerable.Range(1, 12) pour créer une séquence de nombres de 1 à 12, représentant les jours valides. 
             * Ensuite, nous utilisons la méthode FirstOrDefault() pour récupérer le premier élément de cette séquence qui satisfait la condition spécifiée.

            La condition spécifiée est définie par la fonction lambda i => { ... }. À l'intérieur de cette fonction, nous affichons le message demandant à l'utilisateur d'entrer le jour, 
            puis nous utilisons int.TryParse() pour convertir la saisie de l'utilisateur en entier.La condition de la fonction lambda vérifie si la conversion est réussie et si le résultat est un mois valide entre 1 et 12.

            Si l'utilisateur entre un mois valide, la valeur correspondante est affectée à la variable jour et la boucle se termine. 
            Sinon, si l'utilisateur entre un jour invalide ou si la conversion échoue, la boucle continue jusqu'à ce qu'un jour valide soit entré.

            Une fois que la boucle est terminée, vous pouvez utiliser la variable jour pour effectuer les actions souhaitées en fonction du jour entré.

            Cette version utilise LINQ pour simplifier la logique de validation de l'entrée de l'utilisateur en utilisant une seule ligne de code.*/
            #endregion
            // Mois:
            do
            {
                Console.WriteLine("Mois (en chiffre) :");
                string input = Console.ReadLine();

                if (int.TryParse(input, out mois))
                {
                    // L'entrée est un entier valide, nous pouvons sortir de la boucle
                    break;
                }

                Console.WriteLine("Mois invalide. Veuillez réessayer.");
            } while (true);
            //Année:
            do
            {
                Console.WriteLine("Mois (en chiffre) :");
                string input = Console.ReadLine();

                if (int.TryParse(input, out annee))
                {
                    // L'entrée est un entier valide, nous pouvons sortir de la boucle
                    break;
                }

                Console.WriteLine("Mois invalide. Veuillez réessayer.");
            } while (true);


            DateArrivee = new DateTime(annee, mois, jour);
        }
    }
}
