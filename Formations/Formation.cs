using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formations
{
    class Formation
    {
        public string Intitule { get; set; }
        public int NbrPeriodes { get; set; }
        public Formateur formateur { get; set; }
        public List<Participant> participants { get; set; }

        public Formation()
        {

        }

        /// <summary>
        /// Constructeur de la classe Formation prenant en param un string pour Intitulé
        /// </summary>
        /// <param name="intitule"></param>
        public Formation(string intitule)
        {
            Intitule = Intitule;

        }

        /// <summary>
        /// Constructeur de la classe Formation prenant un string et un int en params(intitule, formation)
        /// </summary>
        /// <param name="intitule"></param>
        /// <param name="periodes"></param>
        public Formation(string intitule, int periodes)
        {
            Intitule = Intitule;
            NbrPeriodes = periodes;

        }

        /// <summary>
        /// Constructeur de la classe Formation prenant un string, un int et un obj Formateur en params
        /// </summary>
        /// <param name="intitule"></param>
        /// <param name="periodes"></param>
        /// <param name="formateur"></param>
        public Formation(string intitule, int periodes, Formateur formateur)
        {
            Intitule = Intitule;
            NbrPeriodes = periodes;
            this.formateur = formateur;

        }

        /// <summary>
        /// Constructeur de la classe Formation prenant un string, un int, 1 obj Formateur et une liste Particpant en params  
        /// </summary>
        /// <param name="intitule"></param>
        /// <param name="periodes"></param>
        /// <param name="formateur"></param>
        /// <param name="participants"></param>
        public Formation(string intitule, int periodes, Formateur formateur, List<Participant> participants)
        {
            Intitule = Intitule;
            NbrPeriodes = periodes;
            this.formateur = formateur;
            this.participants = participants;

        }

        /// <summary>
        /// Inscription de participants à une formation
        /// </summary>
        /// <param name="participant"></param>
        /// <returns></returns>
        public void Inscrire(Participant participant)
        {
            participants.Add(participant);

        }
    }
}
