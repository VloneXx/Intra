using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intra.Classes
{
    public class Election : Electeur
    {
        private string nom_election;
        private DateTime date_election;
        private static List<Electeur> list_electeurs;
    }

    public string List<Electeur> List_electeurs 
    {
        get { return list_electeurs; }
        set { list_electeurs = value; }
    }

    static Statistique_election()
    {
        list_electeurs = new List<Electeur>();
    }
}
