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
                Console.WriteLine(classement.ToString());
            }

        }
        public void TopN()
        {
            int i = 0;
            classement.Sort();
            classement.Reverse();

            
            for (i=0; i<5 && classement.Count()>=i; i++)
            {
                Console.WriteLine($" {i+1} Nom :{classement[i].Nom}, Score: {classement[i].Score}");
            }
        }
        public abstract void save();
       
        public abstract void load();

        
    }
}
