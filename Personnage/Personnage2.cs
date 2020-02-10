using Jeux01.EnumArme;
using Jeux01.Monstre;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux01.Personnage
{
    public class Personnage2 : BasePersonnage
    {
        public static Personnage1 Personnage1 { get; set; }
        public static Monstre1 Monstre1 { get; set; }
        public Personnage2 Personnage2x { get; set; }
        public static int CompteurSoin { get; set; }
        public static int CompteurDecoupCibler { get; set; }
        public static int PointDeViePersonnage2 { get; set; } = 6000;

        public Personnage2()
        {

        }

        public Personnage2(string nomPersonnage, string typeDeCombattant) : base(nomPersonnage, typeDeCombattant)
        {
        }

        public override void Attaquer()
        {

            //PointAttaque = 15;
            PointAttaqueJulieFeu = 20;
            PointAttaqueJulieGlace = 21;
           // NombreDeFlèche = 5;
            PointAttaqueJulie = 17;
            NombreDeGlace = 5;
            NombreDeFeu = 6;

            Random aleatoireJulieAttaque = new Random();
            int entierUnChiffreJulieattaqueIntervient1 = aleatoireJulieAttaque.Next(0, 4);

            if (entierUnChiffreJulieattaqueIntervient1 == 1 && NombreDeFlèche < 6)
            {
                NombreDeFlèche = NombreDeFlèche + 1;
                Random aleatoireJulie = new Random();
                int entierUnChiffreJulie = aleatoireJulie.Next(0, 11); //Génère un entier compris entre 0 et 10
                int PointAttaqueFinalPerso2 = Monstre1.PointAttaqueMonstre1 * entierUnChiffreJulie;
                // Console.WriteLine($"L'attaque du personnage2 est de : {PointAttaqueFinalPerso2}");
                Monstre1.PointDeVie = Monstre1.PointDeVie - PointAttaqueFinalPerso2;
                Console.WriteLine($"Dégats du Julie {PointAttaqueFinalPerso2} et la vie du monstre1 : {Monstre1.PointDeVie}");
            }

            if (entierUnChiffreJulieattaqueIntervient1 == 1 && NombreDeFlèche == 5)
            {
                Console.WriteLine("Julie vous aide également mais elle n'a plus de flèche," +
                    " elle doit changer d'arme. taper 1 pour le baton de magie");
                string DemanderChangementArme = Console.ReadLine();

                if (Int32.TryParse(DemanderChangementArme, out int typeArme))
                {
                }
                else
                {
                    Console.WriteLine($"il y a une erreur dans l'action du personnage ");
                }

                if (typeArme == 1)
                {
                    Console.WriteLine("Julie la magie de glace(tapper 1) ou de feu (tapper 2)");
                    string DemanderTypeArme = Console.ReadLine();

                    if (Int32.TryParse(DemanderTypeArme, out int typeElementaireArme))
                    {
                        // Console.WriteLine("Ok");
                    }
                    else
                    {
                        Console.WriteLine($"il y a une erreur dans l'action du personnage ");
                    }
                    if (typeElementaireArme == 1 && NombreDeGlace < 6)
                    {
                        // Console.WriteLine("Julie utilise la magie glace ");
                        NombreDeGlace = NombreDeGlace + 1;
                        Random aleatoireJulieGlace = new Random();
                        int entierUnChiffreJulieGlace = aleatoireJulieGlace.Next(0, 19); //Génère un entier compris entre 0 et 10
                        int PointAttaqueFinalPerso2Glace = Monstre1.PointAttaqueMonstre1 * entierUnChiffreJulieGlace;
                        // Console.WriteLine($"L'attaque du personnage2 est de : {PointAttaqueFinalPerso2}");
                        Monstre1.PointDeVie = Monstre1.PointDeVie - PointAttaqueFinalPerso2Glace;
                        Console.WriteLine($"Dégats de glace de Julie {PointAttaqueFinalPerso2Glace} et la vie du monstre1 : {Monstre1.PointDeVie}");

                    }

                    if (typeElementaireArme == 1 && NombreDeFeu < 6)
                    {
                        // Console.WriteLine("Julie utilise la magie glace ");
                        NombreDeFeu = NombreDeFeu + 1;
                        Random aleatoireJulieFeu = new Random();
                        int entierUnChiffreJulieFeu = aleatoireJulieFeu.Next(0, 16); //Génère un entier compris entre 0 et 10
                        int PointAttaqueFinalPerso2Feu = Monstre1.PointAttaqueMonstre1 * entierUnChiffreJulieFeu;
                        // Console.WriteLine($"L'attaque du personnage2 est de : {PointAttaqueFinalPerso2}");
                        Monstre1.PointDeVie = Monstre1.PointDeVie - PointAttaqueFinalPerso2Feu;
                        Console.WriteLine($"Dégats de feu de Julie {PointAttaqueFinalPerso2Feu} et la vie du monstre1 : {Monstre1.PointDeVie}");
                    }
                }

            }
        }
    }
}