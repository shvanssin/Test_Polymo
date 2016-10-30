using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Polymo
{
    class Mere
    {
        protected static int id = 01;
        public int Id { get { return id; } set { id = value; } }
        public Mere() { this.Id= 01;} // constructeur par défaut
    
        public void Methode() { Console.WriteLine("Ceci est une méthode propre à la classe Mère"); }
        public virtual void Methode(int a) { Console.WriteLine("Ceci est la {0} méthode propre à la classe Mère", a); }// Polymorphisme statique (meme nom mais diffèrents paramètres)
        ~Mere() { Console.WriteLine("Destructeur Mere appelé pour l'objet {0}", this.ToString()); }
    }
}
