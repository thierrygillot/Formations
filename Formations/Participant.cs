using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formations
{
    /// <summary>
    /// Classe Participant héritant de la classe Personnr
    /// </summary>
    class Participant : Personne
    {
        public List<Formation> FormationsSuivies { get; set; }

        public Participant(string nom, string prenom)
            : base(nom, prenom)
        {

        }

        public Participant(string nom, string prenom, List<Formation> formations)
            : base(nom, prenom)
        {
            FormationsSuivies = formations;
        }



    }
}
