using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu2Des
{
    [Serializable]
    public class Entree : IComparable<Entree>
    {
        public string Nom { get; set; }
        public int Score { get; set; }
       
      
        public Entree(string nom, int score)
        {
            Nom = nom;
            Score = score;
         
        }
        public Entree()
        {

        }

        public int CompareTo(Entree other)
        {
            if (other != null)
            {
                return this.Score.CompareTo(other.Score);
            }
            return 1;
        }
        public override string ToString()
        {
            return $"Nom : {Nom} , Score: {Score}";
        }
    }
}
