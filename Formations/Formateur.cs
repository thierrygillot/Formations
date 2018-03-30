using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formations
{
    /// <summary>
    /// Classe Formateur héritant de la classe Personne
    /// </summary>
    class Formateur : Personne
    {
        public string Entreprise { get; set; }

        /// <summary>
        /// Constructeur de la classe Formateur prenant 3 params
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="entreprise"></param>
        public Formateur(string nom, string prenom, string entreprise)
            : base(nom, prenom)
        {
            Entreprise = entreprise;
        }

        public Formation DonneCours(Formation formation)
        {
            return formation;
        }

    }
}
