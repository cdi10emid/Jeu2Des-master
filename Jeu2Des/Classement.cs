using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Jeu2Des
{
    [Serializable]
    public abstract class Classement
    {

        public List<Entree> classement { get; protected set; }

        public Classement()
        {

            classement = new List<Entree>();


        }
        public void AjouterEntree(string nom, int score)
        {
            Entree _Entree = new Entree(nom, score);
            classement.Add(_Entree);

        }
        public void VisuClassement()
        {
            classement.Sort();
            classement.Reverse();
            foreach (Entree _Entree in classement)
            {
                Console.WriteLine(_Entree.ToString());
            }

        }
        public void TopN()
        {

        }
        public abstract void save();
       
        public abstract void load();
      

    }
}
