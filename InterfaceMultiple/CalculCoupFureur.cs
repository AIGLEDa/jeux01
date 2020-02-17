using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux01.InterfaceMultiple
{
    class CalculCoupFureur : IcalculAttaque
    {
        public int NombreDonne { get; set; }

        public CalculCoupFureur(int nombreDonne)
        {
            NombreDonne = nombreDonne;
        }

        public int CalculerDegats(int nombreDonne)
        {

            Random aleatoireColere = new Random();
            int pointDegatsAttaqueARetirer = aleatoireColere.Next(0, 3);
            int valeurDuNombreDonneColere = nombreDonne - pointDegatsAttaqueARetirer;
            int pointDegatsDonnes = valeurDuNombreDonneColere + aleatoireColere.Next(0, 4);

            int nombreDegatsCritique = aleatoireColere.Next(4, 28); 
            int degatsCritique = pointDegatsDonnes * nombreDegatsCritique;
            return degatsCritique;

        }
    }
}
