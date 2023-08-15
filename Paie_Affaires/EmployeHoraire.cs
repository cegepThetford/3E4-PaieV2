using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paie_Affaires
{
    public class EmployeHoraire : Employe
    {
        private decimal _tauxHoraire;
        private double _nbHeures; 

        public EmployeHoraire(int nas, string nom, decimal th) : base(nas, nom)
        {
            _tauxHoraire = th;
            _nbHeures = 0;
        }

        public decimal TauxHoraire { get { return _tauxHoraire; } }
        public double NbHeures { get { return _nbHeures; } set { _nbHeures = value; } }

        public override decimal calculerSalaireBrut()
        {
            decimal sal = (decimal) _nbHeures * _tauxHoraire;
            if (_nbHeures > 75)
                sal += (decimal) ((_nbHeures - 75) * 0.5) * _tauxHoraire;
            return sal;
        }
    }
}
