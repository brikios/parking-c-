using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingC
{
    internal class Info
    {
        public int _capacite;
        public int _disponibililite;
       
            public Info(int capacite,int dispo)
        {
            this._capacite=capacite;
            this._disponibililite=dispo; 
        }
        public int getCapacite { get { return _capacite; } }   
        public int getDispo { get { return _disponibililite; } } 
        
        public void setCapacite(int cap) {   this._capacite = cap;  }
        public void setDispo(int dispo) {  this._disponibililite = dispo;  }
    }
}
