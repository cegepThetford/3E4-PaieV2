using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paie_Affaires
{
    public class Entreprise
    {
        private Dictionary<int, Employe> _employes;

        public Entreprise()
        {
            _employes = new Dictionary<int,Employe>();
        }

        public Dictionary<int, Employe> Employes { get { return _employes; } }

        public Employe getEmploye(int nas) { return _employes[nas]; }

        public void ajouterEmploye(Employe emp) { _employes.Add(emp.NumAssSoc, emp); }

        public Dictionary<int, decimal> calculerSalairesBruts()
        {
            Dictionary<int, decimal> salaires = new Dictionary<int, decimal>();
            foreach (Employe emp in _employes.Values)
                salaires.Add(emp.NumAssSoc, emp.calculerSalaireBrut());
            return salaires;
        }
    }
}
