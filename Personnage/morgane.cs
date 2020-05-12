using Jeux01.EnumArme;
using Jeux01.Monstre;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux01.Personnage
{
    public class morgane : BasePersonnage
    {
        public BaseMonstre BaseMonstre { get; set; }
        public Personnage1 Personnage1 { get; set; }
        public Monstre1 Monstre1 { get; set; }
        public morgane Morgane { get; set; }
        public static int CompteurSoin { get; set; } = 0;
        public static int BoirePotion { get; set; } = 0;
        public int CompteurDecoupCibler { get; set; }
        public static int PointDeVieMorgane { get; set; } = 6000;
        //public ICalculAttaque AttaquerCalculer { get; set; }
        public static int NombreDeFeu { get; set; } = 0;
        public static int NombreDeGlace { get; set; } = 0;
        public int PointAttaqueMorgane { get; set; } = 17;
        public int PointAttaqueMorganeFeu { get; set; } = 20;
        public int PointAttaqueMorganeGlace { get; set; } = 21;
        public static int NombreDeFlèche { get; set; } = 25;
        public static string optionMenu { get; set; }
        public static int CompteurCoupCritique { get; set; } = 0;
        public static int Endurance { get; set; } = 150;
        public static int FlecheSpecial { get; set; } = 1;
        //public IcalculAttaque CalculAttaque { get; set; }

        public morgane()
        {

        }


        public morgane(string nomPersonnage, string typeDeCombattant) : base(nomPersonnage, typeDeCombattant)
        {

        }

        public int Action(string optionMenu)
        {
            if (Int32.TryParse(optionMenu, out int typeMenu))
            {
                // Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine($"il y a une erreur dans l'action du personnage ");
            }
            return typeMenu;

        }

        public void AttaquerMorgane(Monstre1 Monstre1, Personnage1 Personnage1)
        {
            while (Monstre1.PointDeVieMonstre1 > 0)
            {
                int CompteurMonstre1Attaque = 0;
                Random aleatoireJoueurAttaque = new Random();
                int TourAleatoireAttaqueValeur = aleatoireJoueurAttaque.Next(1, 4);

                if (TourAleatoireAttaqueValeur == 1 && CompteurMonstre1Attaque < 1)
                {
                    CompteurMonstre1Attaque = CompteurMonstre1Attaque + 1;
                    Console.WriteLine("le monstre1 attaque");
                    Monstre1.Attaquer();

                    if (TourAleatoireAttaqueValeur == 1 && CompteurMonstre1Attaque == 1)
                    {
                        CompteurMonstre1Attaque = 0;
                    }
                }

                if (TourAleatoireAttaqueValeur == 2)
                {
                    Personnage1.AttaqueDuChevalier(Monstre1);
                }

                if (TourAleatoireAttaqueValeur == 3)
                {

                    CompteurCoupCritique = CompteurCoupCritique + 1;
                    Console.WriteLine("Julie attaque");
                    Console.WriteLine("Menu:0 attaque normal");
                    Console.WriteLine("Menu:1 attaque rapide");
                    Console.WriteLine("Menu:2 attaque cibler");
                    Console.WriteLine("Menu:3 attaque magie glace ");
                    Console.WriteLine("Menu:4 attaque magie feu");
                    Console.WriteLine("Menu:5 soigner allié");
                    Console.WriteLine("Menu:6 boire potion");
                    Console.WriteLine("Menu:7 appeller Navi pour conseil");
                    // Console.WriteLine("Menu:7 flèche spécial");

                    string optionMenu = Console.ReadLine();
                    if (Int32.TryParse(optionMenu, out int typeMenu))
                    {
                        // Console.WriteLine("Ok");
                    }
                    else
                    {
                        Console.WriteLine($"il y a une erreur dans l'action du personnage ");
                    }


                    if (typeMenu == (int)EnumMenuPerso2.AttaqueNormal && Personnage2.NombreDeFlèche < 5)
                    {

                        morgane.NombreDeFlèche = morgane.NombreDeFlèche + 1;
                        int sommeDesFlechesRestante = 6 - morgane.NombreDeFlèche;
                        Console.WriteLine($"Le nombre de flèche utilisé {morgane.NombreDeFlèche}, il reste {sommeDesFlechesRestante}");
                        Random aleatoireMorgane = new Random();
                        int entierUnChiffreJulie = aleatoireMorgane.Next(0, 11);
                        int PointAttaqueFinalPerso2 = PointAttaqueMorgane * entierUnChiffreJulie;
                        Monstre1.PointDeVieMonstre1 = Monstre1.PointDeVieMonstre1 - PointAttaqueFinalPerso2;
                        Console.WriteLine($"Dégats de Morgane {PointAttaqueFinalPerso2} et la vie du monstre1 : {Monstre1.PointDeVieMonstre1}");

                    }

                    if (typeMenu == (int)EnumMenuPerso2.AttaqueRapide)
                    {
                        if (morgane.Endurance > 70 && morgane.NombreDeFlèche > 2)
                        {
                            Random aleatoireMorganeAttaqueRapide = new Random();
                            int entierUnChiffreMorganeRapide = aleatoireMorganeAttaqueRapide.Next(0, 13);
                            int PointAttaqueFinalPerso2Rapide = PointAttaqueMorgane * entierUnChiffreMorganeRapide;
                            Monstre1.PointDeVieMonstre1 = Monstre1.PointDeVieMonstre1 - PointAttaqueFinalPerso2Rapide;
                            Console.WriteLine($"Dégats de Morgane {PointAttaqueFinalPerso2Rapide} et la vie du monstre1 : {Monstre1.PointDeVieMonstre1}");
                            morgane.NombreDeFlèche = morgane.NombreDeFlèche - 3;

                        }
                    }

                    if (typeMenu == (int)EnumMenuPerso2.AttaqueCibler)
                    {
                        if (morgane.CompteurCoupCritique % 8 != 1)
                        {
                            Console.WriteLine("Morgane ne peut pas encore effectuer un coup critique");
                        }

                        if (morgane.Endurance % 8 == 1 && morgane.NombreDeFlèche < 5)
                        {
                            int CoupCritique = 100;
                            Random aleatoireMorganeCritique = new Random();
                            int entierUnChiffreMorgane = aleatoireMorganeCritique.Next(0, 11) + CoupCritique; //Génère un entier compris entre 0 et 10
                            int sommeDesAttaques = PointAttaqueMorgane + CoupCritique;
                            Monstre1.PointDeVieMonstre1 = Monstre1.PointDeVieMonstre1 - sommeDesAttaques;
                            Console.WriteLine($"l'attaque cibler fait {sommeDesAttaques}, et reste au monstre1 {Monstre1.PointDeVieMonstre1}");
                            morgane.CompteurCoupCritique = 0;
                            morgane.Endurance = morgane.Endurance - 70;
                        }
                    }

                    if (typeMenu == (int)EnumMenuPerso2.MagieGlace && morgane.NombreDeGlace < 6)
                    {
                        morgane.Endurance = morgane.Endurance + 10;
                        morgane.NombreDeGlace = morgane.NombreDeGlace + 1;
                        int sommeDesGlaceRestante = 7 - morgane.NombreDeGlace;
                        Console.WriteLine($"Le nombre de glace utilisé {morgane.NombreDeGlace}, il reste {sommeDesGlaceRestante}");
                        Random aleatoireMorganeGlace = new Random();
                        int entierUnChiffreMorganeGlace = aleatoireMorganeGlace.Next(0, 19);
                        int PointAttaqueFinalPerso2Glace = PointAttaqueMorganeGlace * entierUnChiffreMorganeGlace;
                        Monstre1.PointDeVieMonstre1 = Monstre1.PointDeVieMonstre1 - PointAttaqueFinalPerso2Glace;
                        Console.WriteLine($"Dégats de glace de Morgane {PointAttaqueFinalPerso2Glace} et la vie du monstre1 : {Monstre1.PointDeVieMonstre1}");

                    }

                    if (typeMenu == (int)EnumMenuPerso2.MagieFeu && morgane.NombreDeFeu < 5)
                    {
                        morgane.Endurance = morgane.Endurance + 10;
                        morgane.NombreDeFeu = morgane.NombreDeFeu + 1;
                        int sommeDesfeuxRestante = 6 - morgane.NombreDeGlace;
                        Console.WriteLine($"Le nombre de feu utilisé {morgane.NombreDeFeu}, il reste {sommeDesfeuxRestante}");
                        Random aleatoireMorganeFeu = new Random();
                        int entierUnChiffreMorganeFeu = aleatoireMorganeFeu.Next(0, 16);
                        int PointAttaqueFinalPerso2Feu = PointAttaqueMorganeFeu * entierUnChiffreMorganeFeu;
                        Monstre1.PointDeVieMonstre1 = Monstre1.PointDeVieMonstre1 - PointAttaqueFinalPerso2Feu;
                        Console.WriteLine($"Dégats de feu de Morgane {PointAttaqueFinalPerso2Feu} et la vie du monstre1 : {Monstre1.PointDeVieMonstre1}");
                    }

                    if (typeMenu == (int)EnumMenuPerso2.SoignerAllie && morgane.CompteurSoin < 5)
                    {
                        morgane.CompteurSoin = morgane.CompteurSoin + 1;
                        int sommeDesSoin = 6 - morgane.CompteurSoin;
                        Console.WriteLine($"Le nombre de soin utilisé {morgane.NombreDeFeu}, il reste {sommeDesSoin}");
                        Personnage1.PointDeViePersonnage1 = Personnage1.PointDeViePersonnage1 + 1000;
                        Console.WriteLine($"Il reste en point de vie au personnage1 {Personnage1.PointDeViePersonnage1}");

                    }

                    if (typeMenu == (int)EnumMenuPerso2.BoirePotionVie && morgane.BoirePotion < 6)
                    {
                        morgane.Endurance = morgane.Endurance + 30;
                        morgane.BoirePotion = morgane.BoirePotion + 1;
                        int sommeDesPotions = 7 - morgane.BoirePotion;
                        Console.WriteLine($"il reste en potion {sommeDesPotions}");
                        morgane.PointDeVieMorgane = morgane.PointDeVieMorgane + 800;
                        Console.WriteLine($"Morgane à maitenant {Personnage2.PointDeViePersonnage2} points de vie.");
                    }

                    if (typeMenu == (int)EnumMenuPerso2.Navi)
                    {
                        Console.WriteLine("Le conseil de Navi est: ");
                    }

                }
            }

            if (Monstre1.PointDeVieMonstre1 < 1)
            {
                Random aleatoireObjet = new Random();
                NombreDeFlèche = NombreDeFlèche + aleatoireObjet.Next(0, 10);
                NombreDeGlace = NombreDeGlace + aleatoireObjet.Next(0, 20);
                NombreDeFeu = NombreDeFeu + aleatoireObjet.Next(0, 20);
                Console.WriteLine($"Objet récupérer sur le monstre1, nombre de flèche:{NombreDeFlèche}, nombre de glace:{PointAttaqueMorganeGlace}, nombre de feu:{PointAttaqueMorganeFeu}");
            }

        }
    }
}
