using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Polymo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mere objet_1 = new Mere();
            Mere objet_2 = new Fille("objet_2");
            //Fille objet_3 = (Fille) new Mere(); // Exception générée à l'execution 
            Fille objet_3 = new Fille("objet_3");
            Fille objet_4 = new Fille("objet_4");

            objet_1.Methode();// appel de la methode Mere
            objet_2.Methode();// appel de la methode Mere
            objet_3.Methode();// appel de la methode Fille
            objet_4.Methode();// appel de la methode Fille
            objet_1.Methode(1);// appel de la methode Mere
            objet_2.Methode(1);// appel de la methode Fille
            objet_3.Methode(1);// appel de la methode Fille
            objet_4.Methode(1);// appel de la methode Fille

           
            Console.ReadKey();

        }
    }
}
