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
            Personnage1 perso = new Personnage1();
            Personnage2 perso2 = new Personnage2();
            Monstre1 monstreLevel1 = new Monstre1();

            Console.WriteLine("le combat commence ");

            perso2.AttaquerJulie(monstreLevel1, perso);

            Console.WriteLine("le test!! ");

        }
    }
}
