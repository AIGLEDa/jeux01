using Jeux01.EnumArme;
using Jeux01.Monstre;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux01.Personnage
{
    public class BasePersonnage
    {
        public  int NombreDeFlèche { get; set; }
        public  Personnage2 Personnage2 { get; set; }
        public  Personnage1 Personnage1 { get; set; }
       // public static BaseMonstre MonstreN { get; set; }
        public string TypeDeCombattant { get; set; }
        public string Nom { get; set; }
        //public NomPersonnage NomPersonnage { get; set; }
        public bool ValeurBool { get; set; }
        public EnumTypeArme arme { get; set; }
        public  Monstre1 PointAttaque { get; set; }
        public  int PointAttaqueJulie { get; set; }
        public int PointAttaqueJulieGlace { get; set; }
        public int NombreDeGlace { get; set; }
        public int PointAttaqueJulieFeu { get; set; }
        public int NombreDeFeu { get; set; }
       // public static int PointDeVie { get; set; } = 10000;
        public int PointDeBouclier { get; set; }
        public int Boisson { get; set; }
        public int CompteurBoisson { get; set; }
        // public int CompteurNombreAttaqueRapide { get; set; }
        public int NombreAttaqueRapidePerso1 { get; set; }
        public int PointAttaquePerso1 { get; set; } = 20;
        public Monstre1 Monstre1 { get; set; }
        public BaseMonstre BaseMonstre { get; set; }
        public static De De { get; set; }
        //Monstre1 monstre1x = new Monstre1();

        public BasePersonnage()
        {
            De = new De();
        }

        public BasePersonnage(string nomPersonnage, string typeDeCombattant)
        {
            Nom = nomPersonnage;
            TypeDeCombattant = typeDeCombattant;
        }

        public virtual void AttaquerMonstre(Monstre1 Monstre1)
        {

            
            Random aleatoire = new Random();
            int entierUnChiffre = aleatoire.Next(0, 10); //Génère un entier compris entre 0 et 9
            int PointAttaqueFinalPerso1 = PointAttaquePerso1 * entierUnChiffre;
            //Console.WriteLine($"L'attaque du personnage1 est de : {PointAttaqueFinalPerso1}");
            Monstre1.PointDeVieMonstre = Monstre1.PointDeVieMonstre - PointAttaqueFinalPerso1;
            Console.WriteLine($"L'attaque du personnage1 fait des dégats de {PointAttaqueFinalPerso1} " +
                $"et reste en vie sur le monstre : {Monstre1.PointDeVieMonstre}");
        }

        /*
        public virtual void Action(BaseMonstre monstre)
        {
            Console.WriteLine("Menu:0 attaque normal");
            Console.WriteLine("Menu:1 attaque rapide");
            Console.WriteLine("Menu:2 attaque cibler");
            Console.WriteLine("Menu:3 attaque magie glace ");
            Console.WriteLine("Menu:4 attaque magie feu");
            Console.WriteLine("Menu:5 attaque soigner allié");
            Console.WriteLine("Menu:6 attaque boire potion");

            // string ChosirDansMenu = Console.ReadLine();
        }
        */

        public int LanceLeDe()
        {
            return BasePersonnage.De.LanceLeDe();
        }

        public virtual int AttaqueAleatoire()
        {

            Random tourAleatoire = new Random();
            int nombreAleatoire = tourAleatoire.Next(4, 7);
            return nombreAleatoire;
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

