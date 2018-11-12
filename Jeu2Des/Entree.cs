using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu2Des
{
    public class Entree : IComparable<Entree>
    {
        private string Nom;
        private int Score;
      
        public Entree(Joueur joueur)
        {
            Nom = joueur.Nom;
            Score = joueur.Score;
         
        }

        public int CompareTo(Entree other)
        {
            if (other != null)
            {
                return this.Score.CompareTo(other.Score);
            }
            throw new NotImplementedException();
        }
    }
}
