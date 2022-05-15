using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joc
{
    class Jucator
    {
        public int id, scor;
        public string numeJucator;

        
        public string Informatie
        {
            
            get
            {
                return id.ToString() + " " +numeJucator+ " "+scor.ToString();
            }
        }
    }
}
