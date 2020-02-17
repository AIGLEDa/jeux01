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
        public static Monstre1 Monstre1 { get; set; }
        public Personnage1 Personnage { get; set; }
        public BasePersonnage BasePersonnage { get; set; }
        public int PointAttaquePerson1 { get; set; }
        public static int PointDeViePersonnage1 { get; set; } = 10000;
        public static int PointAttaqueEpee { get; set; } = 18;
        public static int BoirePotionChevalier { get; set; } = 0;
        public static int EnduranceChevalier { get; set; } = 300;
        public static int DegatsPourFureur { get; set; } = 0;



        public Personnage1()
        {

        }

        public Personnage1(string nomPersonnage, string typeDeCombattant) : base(nomPersonnage, typeDeCombattant)
        {


        }

        public void AttaqueDuChevalier(Monstre1 Monstre1)
        {
            Console.WriteLine("Le chevalier attaque");
            Console.WriteLine("Menu:0 attaque normal");
            Console.WriteLine("Menu:1 attaque rapide");
            Console.WriteLine("Menu:2 attaque fureur");
            Console.WriteLine("Menu:3 Protéger Alliée ");
            Console.WriteLine("Menu:4 Parer Attaque");
            Console.WriteLine("Menu:5 boire potion");
            Console.WriteLine("Menu:6 appeller Navi pour conseil");


            string optionMenuChevalier = Console.ReadLine();
            if (Int32.TryParse(optionMenuChevalier, out int typeMenuChevalier))
            {
                // Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine($"il y a une erreur dans l'action du personnage ");
            }

            if (typeMenuChevalier == (int)EnumMenuPerso1.AttaqueNormal && Personnage1.EnduranceChevalier > 10)
            {
                Personnage1.EnduranceChevalier = Personnage1.EnduranceChevalier + 5;
                Random aleatoireChevalier = new Random();
                int PointAttaqueFinalPerso1 = Personnage1.PointAttaqueEpee * aleatoireChevalier.Next(0, 16);
                Monstre1.PointDeVieMonstre1 = Monstre1.PointDeVieMonstre1 - PointAttaqueFinalPerso1;
                Console.WriteLine($"Dégats du chevalier {PointAttaqueFinalPerso1} et la vie du monstre1 : {Monstre1.PointDeVieMonstre1}");

            }



            if (typeMenuChevalier == (int)EnumMenuPerso1.AttaqueRapide && Personnage1.EnduranceChevalier > 50)
            {
                Personnage1.EnduranceChevalier = Personnage1.EnduranceChevalier - 50;
                Random aleatoireChevalierAttaqueRapide = new Random();
                int PointAttaqueFinalPerso1Rapide = PointAttaquePerson1 * aleatoireChevalierAttaqueRapide.Next(0, 13);
                // Console.WriteLine($"L'attaque du personnage2 est de : {PointAttaqueFinalPerso2}");
                Monstre1.PointDeVieMonstre1 = Monstre1.PointDeVieMonstre1 - PointAttaqueFinalPerso1Rapide;
                Console.WriteLine($"Dégats du chevalier {PointAttaqueFinalPerso1Rapide} et la vie du monstre1 : {Monstre1.PointDeVieMonstre1}");
                

            }

            if(Monstre1.PointAttaqueMonstre1 > 300)
            {
               Personnage1.DegatsPourFureur = Personnage1.DegatsPourFureur + 300;
            }

            if (typeMenuChevalier == (int)EnumMenuPerso1.AttaqueFureur && Personnage1.DegatsPourFureur >= 300)
            {
                
                Random aleatoireChevalierAttaqueFureur = new Random();
                int sommeDesDegatsChevalier = Personnage1.DegatsPourFureur * aleatoireChevalierAttaqueFureur.Next(0, 25);
                Monstre1.PointDeVieMonstre1 = Monstre1.PointDeVieMonstre1 - sommeDesDegatsChevalier;
                Console.WriteLine($"Le chevalier fait une percée dans les défenses de l'enemie de {sommeDesDegatsChevalier}, le monstre est affaiblie {Monstre1.PointDeVieMonstre1}");

            }

            if(typeMenuChevalier == (int)EnumMenuPerso1.ProtegerAlliee)
            {

            }

            if(typeMenuChevalier == (int)EnumMenuPerso1.ParerAttaque)
            {
                Random aleatoireChevalierParerAttaque = new Random();
                int parerAttaque =  aleatoireChevalierParerAttaque.Next(0, 100);
                Personnage1.PointDeViePersonnage1 = Personnage1.PointDeViePersonnage1 - (Monstre1.PointAttaqueMonstre1 - parerAttaque);
            }

            if (typeMenuChevalier == (int)EnumMenuPerso1.BoirePotion && Personnage1.BoirePotionChevalier < 6)
            {
                Personnage1.EnduranceChevalier = Personnage1.EnduranceChevalier + 30;
                Personnage1.BoirePotionChevalier = Personnage1.BoirePotionChevalier + 1;
                int sommeDesPotionsChevalier = 7 - Personnage1.BoirePotionChevalier;
                Console.WriteLine($"il reste en potion {sommeDesPotionsChevalier}");
                Personnage1.PointDeViePersonnage1 = Personnage1.PointDeViePersonnage1 + 900;
                Console.WriteLine($"le chevalier à maitenant en point de vie {Personnage1.PointDeViePersonnage1}");
            }

            if(typeMenuChevalier == (int)EnumMenuPerso1.Navi)
            {
                Console.WriteLine("Navi à un conseil pour toi ");
            }
        }

    }
}

