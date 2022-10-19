using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Tests_cours_POO
{
    public class Piece
    {
        public int     superficie;
        public string  nom;

        public Piece(int superficie, string nom)
        {
            this.superficie = superficie;
            this.nom = nom;
        }

        public override string ToString()
        {
            string toString = String.Format("La pièce {0} fait {1}m²", this.nom, this.superficie);
            return toString;
        }
    }
}
