using System;
using System.Text.RegularExpressions;

namespace Tests_cours_POO
{
    public class Bien
    {
        public string adresse;
        public float superficie;

        public Bien(string Adresse, float Superficie) 
        {
            adresse = Adresse;
            superficie = Superficie;
        }

        public override string ToString()
        {
            string toString = String.Format("Adresse = {0}\n", this.adresse);
            toString += String.Format("Superficie = {0}m²\n", this.superficie);
            return toString;
        }

        public float EvaluationValeur()
        {
            int facteur = 3000;

            return this.superficie * facteur;
        }
    }
}
