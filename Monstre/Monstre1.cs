using Jeux01.Personnage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux01.Monstre
{
    public class Monstre1 : BaseMonstre
    {
        public static Monstre1 Monstre1x { get; set; }
        public static int PointDeVie { get; set; } = 600;
        public static int PointAttaqueMonstre1 { get; set; } = 12;

        public Monstre1()
        {
        }

        public Monstre1(string nom) : base(nom)
        {
        }

        public override void Attaquer()
        {
            //Monstre1.PointAttaqueMonstre = 12;
            //Monstre1.PointDeVie = 600;
            if (Monstre1.PointDeVie >1)
            {
                //Monstre1.PointAttaqueMonstre = 12;
                Random aleatoireMonstre1 = new Random();
                int entierUnChiffreMonstre1 = aleatoireMonstre1.Next(1, 10); //Génère un entier compris entre 0 et 10
                int PointAttaqueFinalMonstre1 = Monstre1.PointAttaqueMonstre1 * entierUnChiffreMonstre1;
                Personnage1.PointDeViePersonnage1 = Personnage1.PointDeViePersonnage1 - PointAttaqueFinalMonstre1;
                Console.WriteLine($"La vie personnage1 : {Personnage1.PointDeViePersonnage1}, et dégats du monstre1 {PointAttaqueFinalMonstre1}");


                if (entierUnChiffreMonstre1 == 1 || entierUnChiffreMonstre1 == 2)
                {
                    int PointAttaqueFinalMonstre1SurJulie = Monstre1.PointAttaqueMonstre1 * entierUnChiffreMonstre1;
                    Personnage2.PointDeViePersonnage2 = Personnage2.PointDeViePersonnage2 - PointAttaqueFinalMonstre1SurJulie;
                    Console.WriteLine($"La vie restante de Julie : {Personnage2.PointDeViePersonnage2} et dégats du monstre1 {PointAttaqueFinalMonstre1SurJulie}");
                }
            }
        }


        public void AttaqueAleatoireMonstre1()
        {
            Random aleatoireMonstre1 = new Random();
            int entierUnChiffreMonstre1 = aleatoireMonstre1.Next(1, 10); //Génère un entier compris entre 0 et 10

            if (entierUnChiffreMonstre1 == 1 || entierUnChiffreMonstre1 == 2 || entierUnChiffreMonstre1 == 3)
            {
                int PointAttaqueFinalMonstre1 = Monstre1.PointAttaqueMonstre1 * entierUnChiffreMonstre1;
                Personnage1.PointDeViePersonnage1 = Personnage1.PointDeViePersonnage1 - PointAttaqueFinalMonstre1;
                Console.WriteLine($"La vie personnage1 : {Personnage1.PointDeViePersonnage1} et dégats du monstre1 {PointAttaqueFinalMonstre1}");

            }
        }

}
}
