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
        

        public BaseMonstre()
        {

        }

        public BaseMonstre(string nom)
        {
            Nom = nom;
        }

        public virtual void AttaqueAleatoire(BasePersonnage personnageNumero0, BaseMonstre MonstreDeBase0)
        {
           // Monstre1.PointAttaqueMonstre = 12;
          //  BasePersonnage.PointAttaque = 10;
            Random aleatoire = new Random();
            int NombrePourquiAttaque = aleatoire.Next(0, 2); //Génère un entier compris entre 0 et 1
            if (NombrePourquiAttaque == 0 && Monstre1.PointDeVie >0)
            {
                personnageNumero0.Attaquer();
            }
            if (NombrePourquiAttaque == 1 && Monstre1.PointDeVie > 0)
            {
                MonstreDeBase0.Attaquer();
            }
        }

        public virtual void Attaquer()
        {
            //PointAttaqueMonstre = 12;
            Random aleatoire = new Random();
            int entierUnChiffre = aleatoire.Next(1, 10); //Génère un entier compris entre 0 et 10
            int PointAttaqueFinal = Monstre1.PointAttaqueMonstre1 * entierUnChiffre;
            Personnage1.PointDeViePersonnage1 = Personnage1.PointDeViePersonnage1 - PointAttaqueFinal;
            Console.WriteLine($"Dégats du personnage1 {PointAttaqueFinal} et la vie du personnage1: {Personnage1.PointDeViePersonnage1}");


            int ValeurAleatoireAttaque = aleatoire.Next(0, 1);
            if (ValeurAleatoireAttaque == 1)
            {
                attaqueRapideMonstre();
            }
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
                int entierUnChiffre = aleatoire.Next(0, 25); //Génère un entier compris entre 0 et 25
                int PointAttaqueFinalMonstre = PointAttaqueMonstre * entierUnChiffre;
                Personnage1.PointDeViePersonnage1 = Personnage1.PointDeViePersonnage1 - PointAttaqueFinalMonstre;
                //Console.WriteLine($"L'attaque rapide du monstre est de : {PointAttaqueFinalMonstre}");
                Console.WriteLine($" L'attaque rapide du monstre est de : {PointAttaqueFinalMonstre} et dégats sur personnage1 : {Personnage1.PointDeViePersonnage1}");
            }
        }
    }
}
