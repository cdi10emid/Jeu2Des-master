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
    public class Classement
    {

        public List<Entree> classement { get; private set; }
         
        public Classement()
        {
           
                classement = new List<Entree>();
            
            classement = this.classement;
        }
        public void AjouterEntree(string nom, int score)
        {
            Entree _Entree = new Entree( nom, score);
            classement.Add(_Entree);
            
        }
        public void VisuClassement()
        {
            classement.Sort();
            classement.Reverse();
            foreach(Entree _Entree in classement)
            {
                Console.WriteLine( _Entree.ToString());
            }
            
        }
        public void TopN()
        {
            
        }
        public void saveBin()
        {
          
            Stream fichier = File.Create("sav.txt");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(fichier, classement);
            fichier.Close();
        }
        public void loadBin()
        {
            if (File.Exists("sav.txt"))
            {
                Stream fichier = File.OpenRead("sav.txt");
                BinaryFormatter serializer = new BinaryFormatter();
                Object obj = serializer.Deserialize(fichier);
                Console.WriteLine(obj);
                this.classement = (List<Entree>)obj;
               // classdDeserialise.VisuClassement();
                fichier.Close();
            }
        }
        public void saveXML()
        {
            Stream fichier = File.Create("sav.xml");
             XmlSerializer serializer = new XmlSerializer(this.classement.GetType());
            serializer.Serialize(fichier, classement);
            fichier.Close();
        }
    }
}
