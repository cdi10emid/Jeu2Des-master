using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu2Des
{
    public class Factory
    {
        
        public static Classement CreateClassement(string typeSauvegarde)
        {
            if (typeSauvegarde == "Binaire")
            {
              return    new ClassementBinaire();
                
                
            }
           else 
            {
                return new ClassementXml();
              
               
            }
           
        }
       
    }
}
