using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formations
{
    /// <summary>
    /// Class principale Personne
    /// </summary>
    class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        /// <summary>
        /// Constructeur de la classe Personne prenant 2 params
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;

        }

    }
}
