using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux01.InterfaceMultiple
{
    interface ICalculAttaque
    {

         //int NombreAleatoireCoupCritique { get; set; }
         //int Aleatoire { get; set; }

        public int CalculerDegats(int nombreDonne);
    }
}
