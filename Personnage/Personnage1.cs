using Jeux01.EnumArme;
using Jeux01.Monstre;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux01.Personnage
{
    public class Personnage1 : BasePersonnage
    {
        public static Personnage2 personnage2 { get; set; }
        public static Monstre1 Monstrex { get; set; }
        public Personnage1 Personnage { get; set; }
        public BasePersonnage BasePersonnage { get; set; }
        public int PointAttaquePerson1 { get; set; }
        public static int PointDeViePersonnage1 { get; set; } = 10000;



        public Personnage1()
        {

        }

        public Personnage1(string nomPersonnage, string typeDeCombattant) : base(nomPersonnage, typeDeCombattant)
        {
        }



    }
}

