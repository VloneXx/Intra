using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intra.Classes
{
    public class Electeur : Individu
    {
        string numero_electeur;
        string circonscription;

        public string Numero_electeur
        {
            get { return numero_electeur; }
            set { numero_electeur = value; }
        }

        public string Circonscription
        {
            get { return circonscription; }
            set { circonscription = value; }
        }

        public Electeur(string p_nom = "!", string p_prenom = "!", string p_courriel = "!", string p_numero_electeur = "!", string p_circonscription = "!") : base (p_nom, p_prenom, p_courriel)
        {
            this.numero_electeur = p_numero_electeur;
            this.circonscription = p_circonscription;
        }

        public override string ToString()
        {
            return "Le numéro electeur est " + this.Numero_electeur + " la circonscription est " + this.Circonscription;
        }
    }
}
