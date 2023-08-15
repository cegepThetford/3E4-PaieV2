using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paie_Affaires
{
    public abstract class Employe
    {
        private int _numAssSoc;
        private string _nom;

        public Employe(int nas, string nom)
        {
            _numAssSoc = nas;
            _nom = nom;
        }

        public int NumAssSoc { get { return _numAssSoc; } }
        public string Nom { get { return _nom; } }
        public abstract decimal calculerSalaireBrut();
    }
}
