using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingC
{
    internal class BusinessParking
    {
        public List<Evenement> _evenement=new List<Evenement>();
        public Info _info ;
        public Ticket _ticket;

        

        
        public void addEvenement(Evenement e)
        {
            _evenement.Add(e);  
        }

        public void VerifyEvenement(Evenement e)
        {
            if(e._idBorne==1)
            {
               
            }
        }
    }

}
