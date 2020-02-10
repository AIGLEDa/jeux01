using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux01.Personnage
{
     public class NomPersonnage
    {

        public string TypeDeCombattant { get; set; }
        public string Nom { get; set; }

        public NomPersonnage(string nom, string typeDeCombattant)
        {
            TypeDeCombattant = typeDeCombattant;
            Nom = nom;
        }
    }
}
