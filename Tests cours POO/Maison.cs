using System;
using System.Text.RegularExpressions;

namespace Tests_cours_POO
{
	public class Maison : Bien
	{
		public int nbPieces;
		public bool jardin;
		public Piece[] pieces;
		public List<Tuple<string, int>> nomPieces = new List<Tuple<string, int>>();

		
		public Maison(string adresse, float superficie, int nbPieces, bool jardin) : base(adresse, superficie)
		{
			Random rnd = new Random();
			this.nbPieces = nbPieces;
			this.jardin = jardin;
			this.superficie = 0;
			this.pieces = new Piece[nbPieces];
			nomPieces.Add(new Tuple<string , int>("Cuisine", 20));
			nomPieces.Add(new Tuple<string , int>("Salle de bain", 20));
			nomPieces.Add(new Tuple<string , int>("Salon", 50));
			nomPieces.Add(new Tuple<string , int>("Chambre", 30));
			nomPieces.Add(new Tuple<string , int>("Garage", 40));
			nomPieces.Add(new Tuple<string , int>("Bureau", 35));
			nomPieces.Add(new Tuple<string , int>("Terrasse", 70));


			for (int i = 0; i < nbPieces; i++)
			{
				int whichPiece = rnd.Next(nomPieces.Count);
				pieces[i] = new Piece(rnd.Next(10, nomPieces[whichPiece].Item2), nomPieces[whichPiece].Item1);
				this.superficie += pieces[i].superficie;
			}
		}

	   public override string ToString()
		{
			string toString = base.ToString();
			toString += String.Format("Nombre de pièces = {0}\n", this.nbPieces);
			foreach (var piece in this.pieces)
				toString += "- " + piece.ToString() + "\n";
			toString += String.Format("Présence d'un jardin = {0}\n", this.jardin ? "Oui" : "Non");
			toString += String.Format("> VALEUR = {0}$\n", this.EvaluationValeur());
			return toString;
		}

		public new float EvaluationValeur()
		{
			int facteur = 3000;

			if (this.jardin) { facteur += 500; }
			if (this.nbPieces > 3) { facteur += 200; }

			if (Regex.IsMatch(this.adresse, @"\bParis\b")) { facteur += 7000; }
			else if (Regex.IsMatch(this.adresse, @"\bLyon\b")) { facteur += 2000; }

			return this.superficie * facteur;
		}
	}
}