using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux01.Monstre
{
    class MonstreBoss1 : BaseMonstre
    {
        /*  public virtual void AttaquerMonstreBoss1()
         {
             {
                 Random aleatoire = new Random();
                 int entierUnChiffre = aleatoire.Next(1, 10); //Génère un entier compris entre 1 et 9
                 int PointAttaqueFinalPerso1 = PointAttaqueMonstre1 * entierUnChiffre;
                 PointDeVieMonstre1 = PointDeVieMonstre1 - PointAttaqueFinalPerso1;
                 Console.WriteLine($"Dégats du personnage {PointAttaqueFinalPerso1} et la vie du monstre1 : {PointDeVieMonstre1}");

             }
         }*/


        //attaque les personnages de la classe Masterclass2
        /*  public void AttaquerParLeBoss1(Sandra Sandra, Laetitia Laetitia, Morgane Morgane, Astrid Astrid, Fanny Fanny, Manon Manon, Christelle Christelle)
          {
              Random aleatoireMonstreBoss1 = new Random();
              int entierUnChiffreMonstreBoss1 = aleatoireMonstreBoss1.Next(1, 20); //Génère un entier compris entre 0 et 10
              int PointAttaqueFinalMonstreBoss1 = PointAttaqueMonstreBoss1 * entierUnChiffreMonstreBoss1;

              //nombre aléatoire pour attaque chacun des personnages aléatoirement
              Random aleatoireAttaqueDuBOss1SurPersonnage = new Random();
              //noter le nombre aléatoire en fonction du nombre de participant
              int nombreAleatoireAttaqueDuBoss1SurPersonnage = aleatoireAttaqueDuBOss1SurPersonnage.Next(1, 10);

              //attaque sandra
              if (nombreAleatoireAttaqueDuBoss1SurPersonnage == 1)
              {
                  Sandra.PointDeVieSandra = Sandra.PointDeVieSandra - PointAttaqueFinalMonstreBoss1;
                  Console.WriteLine($"la vie de Sandra: {Sandra.PointDeVieSandra},et dégats du MonstreBoss1 {PointAttaqueFinalMonstreBoss1}");
              }

              //attaque Laetitia
              if (nombreAleatoireAttaqueDuBoss1SurPersonnage == 2)
              {
                  Laetitia.PointDeVieLaetitia = Laetitia.PointDeVieLaetitia - PointAttaqueFinalMonstreBoss1;
                  Console.WriteLine($"la vie de Laetitia: {Laetitia.PointDeVieLaetitia},et dégats du MonstreBoss1 {PointAttaqueFinalMonstreBoss1}");
              }

              //attaque Morgane
              if (nombreAleatoireAttaqueDuBoss1SurPersonnage == 3)
              {
                  Morgane.PointDeVieMorgane = Morgane.PointDeVieMorgane - PointAttaqueFinalMonstreBoss1;
                  Console.WriteLine($"la vie de Morgane: {Morgane.PointDeVieMorgane},et dégats du MonstreBoss1 {PointAttaqueFinalMonstreBoss1}");
              }

              //attaque Astrid
              if (nombreAleatoireAttaqueDuBoss1SurPersonnage == 4)
              {
                  Astrid.PointDeVieAstrid = Astrid.PointDeVieAstrid - PointAttaqueFinalMonstreBoss1;
                  Console.WriteLine($"la vie de Astrid: {Astrid.PointDeVieAstrid},et dégats du MonstreBoss1 {PointAttaqueFinalMonstreBoss1}");
              }

              //attaque Fanny
              if (nombreAleatoireAttaqueDuBoss1SurPersonnage == 5)
              {
                  Fanny.PointDeVieFanny = Fanny.PointDeVieFanny - PointAttaqueFinalMonstreBoss1;
                  Console.WriteLine($"la vie de Fanny: {Fanny.PointDeVieFanny},et dégats du MonstreBoss1 {PointAttaqueFinalMonstreBoss1}");
              }

              //attaque Manon
              if (nombreAleatoireAttaqueDuBoss1SurPersonnage == 6)
              {
                  Manon.PointDeVieManon = Manon.PointDeVieManon - PointAttaqueFinalMonstreBoss1;
                  Console.WriteLine($"la vie de Manon: {Manon.PointDeVieManon},et dégats du MonstreBoss1 {PointAttaqueFinalMonstreBoss1}");
              }

              //attaque Christelle
              if (nombreAleatoireAttaqueDuBoss1SurPersonnage == 7)
              {
                  Christelle.PointDeVieChristelle = Christelle.PointDeVieChristelle - PointAttaqueFinalMonstreBoss1;
                  Console.WriteLine($"la vie de Christelle: {Christelle.PointDeVieChristelle},et dégats du MonstreBoss1 {PointAttaqueFinalMonstreBoss1}");
              }
              */

        //personnage1
        /*
        Personnage1.PointDeViePersonnage1 = Personnage1.PointDeViePersonnage1 - PointAttaqueFinalMonstre1;
        Console.WriteLine($"La vie personnage1 : {Personnage1.PointDeViePersonnage1}, et dégats du monstre1 {PointAttaqueFinalMonstre1}");
        */


        //attaque sur personnage2
        /*
        if (entierUnChiffreMonstre1 == 1 || entierUnChiffreMonstre1 == 2)
        {
            int PointAttaqueFinalMonstre1SurJulie = PointAttaqueMonstre1 * entierUnChiffreMonstre1;
            Personnage2.PointDeViePersonnage2 = Personnage2.PointDeViePersonnage2 - PointAttaqueFinalMonstre1SurJulie;
            Console.WriteLine($"La vie restante de Julie : {Personnage2.PointDeViePersonnage2} et dégats du monstre1 {PointAttaqueFinalMonstre1SurJulie}");
        }
        */
    }

    //attaque aléatoire 
    /*
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
    }*/



    //affichage quand le monstre meurt
    /*
    public void MortMonstreBoss(MonstreBoss1 Monstre1Boss1)
    {
        if (Monstre1Boss1.PointDeVieMonstreBoss1 == 0 || Monstre1Boss1.PointDeVieMonstreBoss1 < 0)
        {
            Console.WriteLine("Le Monstre boss est mort");

        }
    }
    */
}

