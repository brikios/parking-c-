using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingC
{
    internal class Evenement
    {
        public int _idEvent;
        public DateTime _dateHeureEvent;
        public int _idBorne;
        public int _numCard;
        
        public Evenement(int ide,DateTime d,int idb,int idn)
        {
            this._idEvent = ide;
            this._dateHeureEvent = d;    
            this._idBorne = idb;   
            this._numCard = idn;
        }
        
        public int getIdEvent { get{ return this._idEvent; } }
        public DateTime getDateHeureEvent { get { return this._dateHeureEvent; } }
        public int getIdBorne { get { return this._idBorne; } }
        public int getNumCard { get { return this._numCard; } }

        public void setIdEvenet(int i) { this._idEvent = i; }
        public void setDateHeureEvent(DateTime d) { this._dateHeureEvent = d; }
        public void setIdBorne(int i) { this._idBorne = i; }
        public void setNumCard(int i) { this._numCard = i; }

    }
}
