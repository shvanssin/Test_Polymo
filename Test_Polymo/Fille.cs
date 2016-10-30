using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Polymo
{
    class Fille : Mere
    {
        private string nom;
        public String Nom { get; set; }
        public Fille(string nom):base() { this.nom = nom; }
        public new void Methode() { Console.WriteLine("Ceci est une méthode propre à la classe Fille"); } // Masquage (Liaison statique)
        public override void Methode(int a) { Console.WriteLine("Ceci est la {0} méthode propre à la classe Fille", a); }
        //public void NewMethode() { Console.WriteLine("Ceci est la nouvelle methode propre à la classe Fille");}
        ~Fille() { Console.WriteLine("Destructeur Fille appelé pour l'objet {0}", this.ToString()); }
    }

}
