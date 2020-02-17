using Jeux01.Personnage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux01.Monstre
{
    public class BaseMonstre
    {
        public BasePersonnage BasePersonnage { get; set; }
        public Personnage2 Personnage2 { get; set; }
        public string Nom { get; set; }
        public int CompteurNombreAttaqueRapide { get; set; }
        public int PointDeVieMonstre { get; set; }

        public BaseMonstre()
        {
        }


        public BaseMonstre(string nom)
        {
            Nom = nom;
        }

        public virtual void attaqueRapideMonstre()
        {
            int PointAttaqueMonstre = 2;
            int nombreAttaqueRapide = 1;
            CompteurNombreAttaqueRapide = 0;
            if (CompteurNombreAttaqueRapide <= 1)
            {
                CompteurNombreAttaqueRapide = nombreAttaqueRapide - 1;
                Random aleatoire = new Random();
                int entierUnChiffre = aleatoire.Next(0, 25); 
                int PointAttaqueFinalMonstre = PointAttaqueMonstre * entierUnChiffre;
                Personnage1.PointDeViePersonnage1 = Personnage1.PointDeViePersonnage1 - PointAttaqueFinalMonstre;
                Console.WriteLine($" L'attaque rapide du monstre est de : {PointAttaqueFinalMonstre} et dégats sur personnage1 : {Personnage1.PointDeViePersonnage1}");
            }
        }
    }
}
