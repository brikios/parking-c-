using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingC
{
    internal class Ticket
    {
        public int _idTicket;
        public String _etat;
        public DateTime _dateHeureEntree;
        public DateTime _dateHeureSortie;
        public Double _tarifs;


        public Ticket(int _idT, String _etat, DateTime _dateHeureEntree)
        {
            this._idTicket = _idT;
            this._etat = _etat;
            this._dateHeureEntree = _dateHeureEntree;
        }

        public int getIdTicket() {  return _idTicket;  }
        public String getETat() { return _etat; }
        public DateTime getDateHeureEntree() { return _dateHeureEntree; }
        public Double getTarifs() { return _tarifs; }

        public void setIdTicket(int idt) { this._idTicket = idt; }

        public void setETat(String etat) { this._etat = etat; }
        public void setDateHeureEntree (DateTime d) { this._dateHeureEntree = d; }
        public void setTarifs(Double t) { this._tarifs = t; }

        







    }
}
