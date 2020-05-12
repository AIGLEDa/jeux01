using Jeux01.EnumArme;
using Jeux01.InterfaceMultiple;
using Jeux01.Monstre;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Jeux01.Personnage
{
    public class Manon : BasePersonnage
    {
        public BaseMonstre BaseMonstre { get; set; }
        public Personnage1 Personnage1 { get; set; }
        public Monstre1 Monstre1 { get; set; }
        //public Manon Manonx { get; set; }
        public static int CompteurSoin { get; set; } = 0;
        public static int BoirePotion { get; set; } = 0;
        public int CompteurDecoupCibler { get; set; }
        public static int PointDeVieManon { get; set; } = 18000;
        //public ICalculAttaque AttaquerCalculer { get; set; }
        public static int NombreDeFeu { get; set; } = 0;
        public static int NombreDeGlace { get; set; } = 0;
        public int PointAttaqueManon { get; set; } = 28;
        public int PointAttaqueManonFeu { get; set; } = 18;
        public int PointAttaqueManonGlace { get; set; } = 32;
        public static int NombreDeFlèche { get; set; } = 0;
        public static string optionMenu { get; set; }
        public static int CompteurCoupCritique { get; set; } = 0;
        public static int Endurance { get; set; } = 300;
        public static int FlecheSpecial { get; set; } = 1;
        //public IcalculAttaque CalculAttaque { get; set; }

        public Manon()
        {

        }


        public Manon(string nomPersonnage, string typeDeCombattant) : base(nomPersonnage, typeDeCombattant)
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

        public void AttaqueManon(Monstre1 Monstre1, Personnage1 Personnage1)
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
                    Console.WriteLine("Manon attaque");
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


                    if (typeMenu == (int)EnumMenuPerso2.AttaqueNormal && Manon.NombreDeFlèche < 5)
                    {

                        Manon.NombreDeFlèche = Manon.NombreDeFlèche + 1;
                        int sommeDesFlechesRestante = 6 - Manon.NombreDeFlèche;
                        Console.WriteLine($"Le nombre de flèche utilisé {Manon.NombreDeFlèche}, il reste {sommeDesFlechesRestante}");
                        Random aleatoireJulie = new Random();
                        int entierUnChiffreJulie = aleatoireJulie.Next(0, 11);
                        int PointAttaqueFinalPerso2 = PointAttaqueJulie * entierUnChiffreJulie;
                        Monstre1.PointDeVieMonstre1 = Monstre1.PointDeVieMonstre1 - PointAttaqueFinalPerso2;
                        Console.WriteLine($"Dégats de Manon {PointAttaqueFinalPerso2} et la vie du monstre1 : {Monstre1.PointDeVieMonstre1}");

                    }

                    if (typeMenu == (int)EnumMenuPerso2.AttaqueRapide)
                    {
                        if (Manon.Endurance > 70 && Manon.NombreDeFlèche > 2)
                        {
                            Random aleatoireJulieAttaqueRapide = new Random();
                            int entierUnChiffreJulieRapide = aleatoireJulieAttaqueRapide.Next(0, 13);
                            int PointAttaqueFinalPerso2Rapide = PointAttaqueJulie * entierUnChiffreJulieRapide;
                            Monstre1.PointDeVieMonstre1 = Monstre1.PointDeVieMonstre1 - PointAttaqueFinalPerso2Rapide;
                            Console.WriteLine($"Dégats de Manon {PointAttaqueFinalPerso2Rapide} et la vie du monstre1 : {Monstre1.PointDeVieMonstre1}");
                            Manon.NombreDeFlèche = Manon.NombreDeFlèche - 3;

                        }
                    }

                    if (typeMenu == (int)EnumMenuPerso2.AttaqueCibler)
                    {
                        if (Manon.CompteurCoupCritique % 8 != 1)
                        {
                            Console.WriteLine("Manon ne peut pas encore effectuer un coup critique");
                        }

                        if (Manon.Endurance % 8 == 1 && Manon.NombreDeFlèche < 5)
                        {
                            int CoupCritique = 100;
                            Random aleatoireJulieCritique = new Random();
                            int entierUnChiffreJulie = aleatoireJulieCritique.Next(0, 11) + CoupCritique; //Génère un entier compris entre 0 et 10
                            int sommeDesAttaques = PointAttaqueJulie + CoupCritique;
                            Monstre1.PointDeVieMonstre1 = Monstre1.PointDeVieMonstre1 - sommeDesAttaques;
                            Console.WriteLine($"l'attaque cibler fait {sommeDesAttaques}, et reste au monstre1 {Monstre1.PointDeVieMonstre1}");
                            Manon.CompteurCoupCritique = 0;
                            Manon.Endurance = Manon.Endurance - 70;
                        }
                    }

                    if (typeMenu == (int)EnumMenuPerso2.MagieGlace && Manon.NombreDeGlace < 6)
                    {
                        Manon.Endurance = Manon.Endurance + 10;
                        Manon.NombreDeGlace = Manon.NombreDeGlace + 1;
                        int sommeDesGlaceRestante = 7 - Manon.NombreDeGlace;
                        Console.WriteLine($"Le nombre de glace utilisé {Manon.NombreDeGlace}, il reste {sommeDesGlaceRestante}");
                        Random aleatoireJulieGlace = new Random();
                        int entierUnChiffreJulieGlace = aleatoireJulieGlace.Next(0, 19);
                        int PointAttaqueFinalPerso2Glace = PointAttaqueJulieGlace * entierUnChiffreJulieGlace;
                        Monstre1.PointDeVieMonstre1 = Monstre1.PointDeVieMonstre1 - PointAttaqueFinalPerso2Glace;
                        Console.WriteLine($"Dégats de glace de Manon {PointAttaqueFinalPerso2Glace} et la vie du monstre1 : {Monstre1.PointDeVieMonstre1}");

                    }

                    if (typeMenu == (int)EnumMenuPerso2.MagieFeu && Manon.NombreDeFeu < 5)
                    {
                        Manon.Endurance = Manon.Endurance + 10;
                        Manon.NombreDeFeu = Manon.NombreDeFeu + 1;
                        int sommeDesfeuxRestante = 6 - Manon.NombreDeGlace;
                        Console.WriteLine($"Le nombre de feu utilisé {Manon.NombreDeFeu}, il reste {sommeDesfeuxRestante}");
                        Random aleatoireJulieFeu = new Random();
                        int entierUnChiffreJulieFeu = aleatoireJulieFeu.Next(0, 16);
                        int PointAttaqueFinalPerso2Feu = PointAttaqueJulieFeu * entierUnChiffreJulieFeu;
                        Monstre1.PointDeVieMonstre1 = Monstre1.PointDeVieMonstre1 - PointAttaqueFinalPerso2Feu;
                        Console.WriteLine($"Dégats de feu de Manon {PointAttaqueFinalPerso2Feu} et la vie du monstre1 : {Monstre1.PointDeVieMonstre1}");
                    }

                    if (typeMenu == (int)EnumMenuPerso2.SoignerAllie && Manon.CompteurSoin < 5)
                    {
                        Manon.CompteurSoin = Manon.CompteurSoin + 1;
                        int sommeDesSoin = 6 - Manon.CompteurSoin;
                        Console.WriteLine($"Le nombre de soin utilisé {Manon.NombreDeFeu}, il reste {sommeDesSoin}");
                        Personnage1.PointDeViePersonnage1 = Personnage1.PointDeViePersonnage1 + 1000;
                        Console.WriteLine($"Il reste en point de vie au personnage1 {Personnage1.PointDeViePersonnage1}");

                    }

                    if (typeMenu == (int)EnumMenuPerso2.BoirePotionVie && Manon.BoirePotion < 6)
                    {
                        Manon.Endurance = Manon.Endurance + 30;
                        Manon.BoirePotion = Manon.BoirePotion + 1;
                        int sommeDesPotions = 7 - Manon.BoirePotion;
                        Console.WriteLine($"il reste en potion {sommeDesPotions}");
                        Manon.PointDeVieManon = Manon.PointDeVieManon + 800;
                        Console.WriteLine($"Manon a maitenant en point de vie {Manon.PointDeVieManon}");
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
                Console.WriteLine($"Objet récupérer sur le monstre1, nombre de flèche:{NombreDeFlèche}, nombre de glace:{PointAttaqueJulieGlace}, nombre de feu:{PointAttaqueJulieFeu}");
            }

        }
    }

}
