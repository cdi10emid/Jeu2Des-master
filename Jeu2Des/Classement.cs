using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu2Des
{
    public class Classement
    {
        
        
        List<Entree> classement = new List<Entree>();
        public Classement()
        {
           
        }
        public void AjouterEntree(Joueur joueur)
        {
            Entree _Entree = new Entree(joueur);
            classement.Add(_Entree);
            
        }
        public void VisuClassement()
        {
            classement.Sort();
            classement.Reverse();
            foreach(Entree _Entree in classement)
            {
                Console.WriteLine();
            }
            
        }
        public void TopN()
        {
            
        }
    }
}
