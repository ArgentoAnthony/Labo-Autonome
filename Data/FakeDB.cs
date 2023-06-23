using LaboAutoAnimalerie.Animaux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboAutoAnimalerie.Data
{
    public static class FakeDB
    {
        public static List<Animal> animaux = new List<Animal>()
        {
            new Chat("Yomi", "M", new DateTime(2023, 06, 21)),
            new Chien("Simba", "M", new DateTime(2023,06,20)),
            new Oiseau("Jean", "F", new DateTime(2023, 06, 19)),
            new Oiseau("Charlie", "M", new DateTime(2023, 06, 24)),
            new Chien("Luna", "F", new DateTime(2023, 06, 23)),
            new Chat("Félix", "M", new DateTime(2023, 06, 22))
        };
    }
}
