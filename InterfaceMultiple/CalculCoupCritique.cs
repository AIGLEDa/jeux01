using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux01.InterfaceMultiple
{
     public class CalculCoupCritique : IcalculAttaque
    {

      //  public int NombreAleatoireCoupCritique {get; set;}
        public int NombreDonne { get; set;}

        public CalculCoupCritique(int nombreDonne)
        {
            NombreDonne = nombreDonne;
        }

        public int CalculerDegats(int nombreDonne)
        {
            
            Random aleatoire = new Random();
            int pointDegatsAttaqueARetirer = aleatoire.Next(0, 3);
            int valeurDuNombreDonne = nombreDonne - pointDegatsAttaqueARetirer;
            int pointDegatsDonnes = valeurDuNombreDonne + aleatoire.Next(0, 4);
            
            int nombreDegatsCritique = aleatoire.Next(0, 25); //Génère un entier compris entre 0 et 24
            int degatsCritique = pointDegatsDonnes * nombreDegatsCritique;
            return degatsCritique;
        }

    }
}
