using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Jeu2Des
{
   public class ClassementBinaire: Classement
    {
        public override void save()
        {

            Stream fichier = File.Create("sav.txt");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(fichier, classement);
            fichier.Close();
        }
        public override void load()
        {
            if (File.Exists("sav.txt"))
            {
                Stream fichier = File.OpenRead("sav.txt");
                BinaryFormatter serializer = new BinaryFormatter();
                Object obj = serializer.Deserialize(fichier);

                this.classement = (List<Entree>)obj;

                fichier.Close();
            }
        }
    }
}
