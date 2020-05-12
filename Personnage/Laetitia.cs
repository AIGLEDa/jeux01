using Jeux01.EnumArme;
using Jeux01.Monstre;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux01.Personnage
{
    class Laetitia
    {

        //public static Personnage2 personnage2 { get; set; }
        //public static Monstre1 Monstre1 { get; set; }
        //public Personnage1 Personnage { get; set; }
        //public BasePersonnage BasePersonnage { get; set; }
        //public int PointAttaquePerson1 { get; set; }
        public static int PointDeViePaillette { get; set; } = 10000;
        public static int PointAttaqueCorne { get; set; } = 18;
        public static int MangerFleurMagique { get; set; } = 0;
        public static int EndurancePaillette { get; set; } = 300;
        public static int DegatsPourPetPaillette { get; set; } = 0;

        public Laetitia()
        {

        }

        public void AttaquePaillette(Monstre1 Monstre1)
        {
            Console.WriteLine("Paillette attaque");
            Console.WriteLine("Menu:0 Attaque Coup de corne");
            Console.WriteLine("Menu:1 Attaque Dash Corne");
            Console.WriteLine("Menu:2 ttaque Pet de paillettes");
            Console.WriteLine("Menu:3 Protéger Alliée ");
            Console.WriteLine("Menu:4 Parer Attaque");
            Console.WriteLine("Menu:5 Manger fleur magique");
            Console.WriteLine("Menu:6 Appeller Navi pour conseil");


            string optionMenuPailette = Console.ReadLine();
            if (Int32.TryParse(optionMenuPailette, out int typeMenuPaillette))
            {
                // Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine($"il y a une erreur dans l'action du personnage ");
            }

            if (typeMenuPaillette == (int)EnumMenuPerso1.AttaqueNormal && Laetitia.EndurancePaillette > 10)
            {
                Laetitia.EndurancePaillette = Laetitia.EndurancePaillette + 5;
                Random aleatoireChevalier = new Random();
                int PointAttaqueFinalPerso = Laetitia.PointAttaqueCorne * aleatoireChevalier.Next(0, 16);
                Monstre1.PointDeVieMonstre1 = Monstre1.PointDeVieMonstre1 - PointAttaqueFinalPerso;
                Console.WriteLine($"Dégats du chevalier {PointAttaqueFinalPerso} et la vie du monstre1 : {Monstre1.PointDeVieMonstre1}");
            }

            if (typeMenuPaillette == (int)EnumMenuPerso1.AttaqueRapide && Personnage1.EnduranceChevalier > 50)
            {
                Laetitia.EndurancePaillette = Laetitia.EndurancePaillette - 50;
                Random aleatoireDashCorne = new Random();
                int PointAttaqueFinalSashCorne = PointAttaqueCorne * aleatoireDashCorne.Next(0, 13);
                // Console.WriteLine($"L'attaque du personnage2 est de : {PointAttaqueFinalPerso2}");
                Monstre1.PointDeVieMonstre1 = Monstre1.PointDeVieMonstre1 - PointAttaqueFinalSashCorne;
                Console.WriteLine($"Dégats du chevalier {PointAttaqueFinalSashCorne} et la vie du monstre1 : {Monstre1.PointDeVieMonstre1}");

            }

            if (Monstre1.PointAttaqueMonstre1 > 150)
            {
                Laetitia.DegatsPourPetPaillette = Laetitia.DegatsPourPetPaillette + 150;
            }

            if (typeMenuPaillette == (int)EnumMenuPerso1.AttaqueFureur && Laetitia.DegatsPourPetPaillette >= 150)
            {
                Random aleatoirePetPaillette = new Random();
                int sommeDesDegatsPaillette = Laetitia.DegatsPourPetPaillette * aleatoirePetPaillette.Next(0, 25);
                Monstre1.PointDeVieMonstre1 = Monstre1.PointDeVieMonstre1 - sommeDesDegatsPaillette;
                Console.WriteLine($"Pailette fait une percée dans les défenses de l'enemie de {sommeDesDegatsPaillette}, le monstre est affaiblie {Monstre1.PointDeVieMonstre1}");
            }

            if (typeMenuPaillette == (int)EnumMenuPerso1.ProtegerAlliee)
            {

            }

            if (typeMenuPaillette == (int)EnumMenuPerso1.ParerAttaque)
            {
                Random aleatoirePailletteParerAttaque = new Random();
                int parerAttaque = aleatoirePailletteParerAttaque.Next(0, 100);
                Laetitia.PointDeViePaillette = Laetitia.PointDeViePaillette - (Monstre1.PointAttaqueMonstre1 - parerAttaque);
            }

            if (typeMenuPaillette == (int)EnumMenuPerso1.BoirePotion && Laetitia.MangerFleurMagique < 6)
            {
                Laetitia.EndurancePaillette = Laetitia.EndurancePaillette + 30;
                Laetitia.MangerFleurMagique = Laetitia.MangerFleurMagique + 1;
                int sommeDesPotionsPaillette = 7 - Laetitia.MangerFleurMagique;
                Console.WriteLine($"il reste en potion {sommeDesPotionsPaillette}");
                Laetitia.PointDeViePaillette = Laetitia.PointDeViePaillette + 900;
                Console.WriteLine($"Paillette à maintenant en point de vie {Laetitia.PointDeViePaillette}");
            }

            if (typeMenuPaillette == (int)EnumMenuPerso1.Navi)
            {
                Console.WriteLine("Navi à un conseil pour toi ");
            }
        }
    }
}
