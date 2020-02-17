using Jeux01.EnumArme;
using Jeux01.InterfaceMultiple;
using Jeux01.Monstre;
using Jeux01.Personnage;
using System;


namespace Jeux01
{
    class Program
    {




        static void Main(string[] args)
        {
            //NomPersonnage perso1 = new NomPersonnage("Damien", "chavalier");
            Personnage1 perso = new Personnage1();
            Personnage2 perso2 = new Personnage2();
            Monstre1 monstreLevel1 = new Monstre1();
            //perso.Attaquer(EnumTypeArme.Epee);

            //perso2.Attaquer(EnumTypeArme.Arc);
            // perso.Vie();

            //  MonstreLevel1.VieMonstre();
            // Console.WriteLine(MonstreLevel1.ToString());
            //  MonstreLevel1.Attaquer();
            // perso.Attaquer();
            //MonstreLevel1.VieMonstre();

            // MonstreLevel1.attaqueRapideMonstre();
            //MonstreLevel1.VieMonstre();







            Console.WriteLine("le combat commence ");
            /*
            MonstreLevel1.AttaqueAleatoire(perso, MonstreLevel1);
            MonstreLevel1.AttaqueAleatoire(perso, MonstreLevel1);
            MonstreLevel1.AttaqueAleatoire(perso, MonstreLevel1);
            MonstreLevel1.AttaqueAleatoire(perso, MonstreLevel1);
            */


            // IcalculAttaque CoupCritique = new CalculCoupCritique(3);

            //  perso2.AttaquerJulieGlace(monstreLevel1);
            perso2.AttaquerJulie(monstreLevel1, perso);





            /*
            MonstreLevel1.AttaqueAleatoire(perso, MonstreLevel1);
            MonstreLevel1.AttaqueAleatoire(perso, MonstreLevel1);
            MonstreLevel1.AttaqueAleatoire(perso, MonstreLevel1);
            MonstreLevel1.AttaqueAleatoire(perso, MonstreLevel1);
            MonstreLevel1.attaqueRapideMonstre();
            MonstreLevel1.Attaquer();
            */
            // perso.Attaquer();
            //perso.Attaquer();




            Console.WriteLine("le test!! ");


            /*
            MonstreLevel1.VieMonstre();
            perso.Vie();

            perso.AttaqueRapide();
            MonstreLevel1.attaqueRapideMonstre();
            perso2.AiderParAlliee();
            MonstreLevel1.Attaquer();
            */









            //MonstreLevel1.VieMonstre();






            /*
            Console.WriteLine(perso.ToString());
            //Console.WriteLine(perso1);
            Console.WriteLine(perso2.ToString());
            */
        }
    }
}
