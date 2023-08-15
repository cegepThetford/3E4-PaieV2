using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paie_Affaires
{
    public class EmployePermanent : Employe
    {
        private decimal _salaire;

        public EmployePermanent(int nas, string nom, decimal sal) : base(nas,nom)
        {
            _salaire = sal;
        }

        public decimal Salaire { get { return _salaire; } set { _salaire = value; } }

        public override decimal calculerSalaireBrut()
        {
            return _salaire / 26.0m;
        }
    }
}
