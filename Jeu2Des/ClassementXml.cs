using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Jeu2Des
{
   public class ClassementXml:Classement
    {
       
        public override void save()
        {
            Stream fichier = File.Create("sav.xml");
            XmlSerializer serializer = new XmlSerializer(this.classement.GetType());
            serializer.Serialize(fichier, classement);
            fichier.Close();
        }
        public override void load()
        {
            if (File.Exists("sav.xml"))
            {
                Stream fichier = File.OpenRead("sav.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(List<Entree>));
                Object obj = serializer.Deserialize(fichier);
                classement = (List<Entree>)obj;
                fichier.Close();
            }

        }

    }
}
