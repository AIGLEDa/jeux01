using Jeux01.EnumArme;
using Jeux01.Monstre;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux01.Personnage
{
    public class BasePersonnage
    {
        public static int NombreDeFlèche { get; set; }
        public static Personnage2 Personnage2 { get; set; }
        public static Personnage1 Personnage1 { get; set; }
       // public static BaseMonstre MonstreN { get; set; }
        public string TypeDeCombattant { get; set; }
        public string Nom { get; set; }
        //public NomPersonnage NomPersonnage { get; set; }
        public bool ValeurBool { get; set; }
        public EnumTypeArme arme { get; set; }
        public static Monstre1 PointAttaque { get; set; }
        public static int PointAttaqueJulie { get; set; }
        public static int PointAttaqueJulieGlace { get; set; }
        public static int NombreDeGlace { get; set; }
        public static int PointAttaqueJulieFeu { get; set; }
        public static int NombreDeFeu { get; set; }
       // public static int PointDeVie { get; set; } = 10000;
        public int PointDeBouclier { get; set; }
        public int Boisson { get; set; }
        public static int CompteurBoisson { get; set; }
        // public int CompteurNombreAttaqueRapide { get; set; }
        public int NombreAttaqueRapidePerso1 { get; set; }


        public BasePersonnage()
        {

        }

        public BasePersonnage(string nomPersonnage, string typeDeCombattant)
        {
            Nom = nomPersonnage;
            TypeDeCombattant = typeDeCombattant;
        }

        public virtual void Attaquer()
        {
            {
               // PointAttaque = 15;

                Random aleatoire = new Random();
                int entierUnChiffre = aleatoire.Next(1, 10); //Génère un entier compris entre 1 et 9
                int PointAttaqueFinalPerso1 = Monstre1.PointAttaqueMonstre1 * entierUnChiffre;
                Monstre1.PointDeVie = Monstre1.PointDeVie - PointAttaqueFinalPerso1;
                Console.WriteLine($"Dégats du personnage {PointAttaqueFinalPerso1} et la vie du monstre1 : {Monstre1.PointDeVie}");

            }
        }

        public virtual void BoirePotionVie(bool boissonBu)
        {
        }

        public virtual void ParerBouclier(bool parer)
        {
        }

        public virtual void Vie()
        {
        }


        public virtual void Mort()
        {
        }

        public void SubirDegat()
        {
        }


    }
}

