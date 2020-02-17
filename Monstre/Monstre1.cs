using Jeux01.Personnage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux01.Monstre
{
    public class Monstre1 : BaseMonstre
    {
        public  Monstre1 Monstre1x { get; set; }
        public int PointDeVieMonstre1 { get; set; } = 1000;
        public int PointAttaqueMonstre1 { get; set; } = 25;

        public Monstre1()
        {

        }

        public Monstre1(string nom) : base(nom)
        {
        }

        public virtual void AttaquerMonstre1()
        {
            {
                Random aleatoire = new Random();
                int entierUnChiffre = aleatoire.Next(1, 10); //Génère un entier compris entre 1 et 9
                int PointAttaqueFinalPerso1 = PointAttaqueMonstre1 * entierUnChiffre;
                PointDeVieMonstre1 = PointDeVieMonstre1 - PointAttaqueFinalPerso1;
                Console.WriteLine($"Dégats du personnage {PointAttaqueFinalPerso1} et la vie du monstre1 : {PointDeVieMonstre1}");

            }
        }

        public void Attaquer()
        {
                Random aleatoireMonstre1 = new Random();
                int entierUnChiffreMonstre1 = aleatoireMonstre1.Next(1, 5); //Génère un entier compris entre 0 et 10
                int PointAttaqueFinalMonstre1 = PointAttaqueMonstre1 * entierUnChiffreMonstre1;
                Personnage1.PointDeViePersonnage1 = Personnage1.PointDeViePersonnage1 - PointAttaqueFinalMonstre1;
                Console.WriteLine($"La vie personnage1 : {Personnage1.PointDeViePersonnage1}, et dégats du monstre1 {PointAttaqueFinalMonstre1}");


                if (entierUnChiffreMonstre1 == 1 || entierUnChiffreMonstre1 == 2)
                {
                    int PointAttaqueFinalMonstre1SurJulie = PointAttaqueMonstre1 * entierUnChiffreMonstre1;
                    Personnage2.PointDeViePersonnage2 = Personnage2.PointDeViePersonnage2 - PointAttaqueFinalMonstre1SurJulie;
                    Console.WriteLine($"La vie restante de Julie : {Personnage2.PointDeViePersonnage2} et dégats du monstre1 {PointAttaqueFinalMonstre1SurJulie}");
                }
            
        }


        public void AttaqueAleatoireMonstre1()
        {
            Random aleatoireMonstre1 = new Random();
            int entierUnChiffreMonstre1 = aleatoireMonstre1.Next(1, 10); //Génère un entier compris entre 0 et 10

            if (entierUnChiffreMonstre1 == 1 || entierUnChiffreMonstre1 == 2 || entierUnChiffreMonstre1 == 3)
            {
                int PointAttaqueFinalMonstre1 = PointAttaqueMonstre1 * entierUnChiffreMonstre1;
                Personnage1.PointDeViePersonnage1 = Personnage1.PointDeViePersonnage1 - PointAttaqueFinalMonstre1;
                Console.WriteLine($"La vie personnage1 : {Personnage1.PointDeViePersonnage1} et dégats du monstre1 {PointAttaqueFinalMonstre1}");

            }
        }

        public void Mort(Monstre1 monstre1x)
        {
            if(monstre1x.PointDeVieMonstre1 == 0 || monstre1x.PointDeVieMonstre1 < 0)
            {
                Console.WriteLine("Le monstre1 est mort");
                Console.WriteLine("Le monstre2 arrive");
            }
        }

    }
}
