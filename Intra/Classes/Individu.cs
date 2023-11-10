using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Intra.Classes
{
    public class Individu
    {
        private string nom;
        private string prenom;
        private string courriel;

        public string Nom
        {
            get { return nom; }
            set {
                Regex R = new Regex("^[A-Za-z]{1,25}$");
                if (R.IsMatch(value) == true) nom = value; }
            }

        public string Prenom
        {
            get { return prenom; }
            set
            {
                Regex R = new Regex("^[A-Za-z]{1,25}$");
                if (R.IsMatch(value) == true) prenom = value;
            }
        }

        public string Courriel
        {
            get { return courriel; }
            set
            {
                Regex R = new Regex("^[A-Za-z]{1,25}$");
                if (R.IsMatch(value) == true) courriel = value;
            }
        }

        public Individu(string p_nom = "!", string p_prenom = "!", string p_courriel = "!")
        {
            this.nom = p_nom;
            this.prenom = p_prenom;
            this.courriel = p_courriel;
        }

        public override string ToString()
        {
            return "Le nom est " + this.Nom + " le prénom est " + this.Prenom + " le courriel est " + this.Courriel;
        }

    }

}
