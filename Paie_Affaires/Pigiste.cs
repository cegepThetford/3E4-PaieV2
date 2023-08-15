using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paie_Affaires
{
    public class Pigiste : Employe
    {
        private Contrat _contrat;

        public Pigiste(int nas, string nom, Contrat cont) : base(nas,nom)
        {
            _contrat = cont;
        }

        public Contrat Contrat { get { return _contrat; } set { _contrat = value; } }

        public override decimal calculerSalaireBrut()
        {
            TimeSpan ts = _contrat.DateFin - _contrat.DateDebut;
            return _contrat.Montant / 26.0m; 
        }
    }
}
