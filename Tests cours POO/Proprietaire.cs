using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests_cours_POO
{
    public class Proprietaire
    {
        public string nom = "";
        public string prénom;
        public List<Bien> biens = new List<Bien>();

        public Proprietaire(string nom, string prénom, List<Bien> bien) 
        {
            this.nom = nom;
            this.prénom = prénom;
            this.biens = bien;
        }

        private string ListeBiens()
        {
            string listeBiens = "";

            foreach (Bien b in this.biens)
            {
                listeBiens += string.Format("- {0} {1} au {2}\n", b.GetType().Name == "Maison" ? "Une" : "Un", b.GetType().Name, b.adresse);
            }
            return listeBiens;
        }
        

        public override string ToString()
        {
            string toString = String.Format("{0} {1} {2} bien(s).\n", this.nom, this.prénom, this.biens?.Count != 0 ? "possède un ou plusieurs" : "ne possède pas de");
            toString += ListeBiens();          
            return toString;
        }
    }
}
