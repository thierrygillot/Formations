using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formations
{
   

   

   

  


    //Main
    class Program
    {
        static void Main(string[] args)
        {

            //Formateurs
            Formateur formateurGuillaume = new Formateur("Oger", "Guillaume", "BStorm");
            Formateur formateurThierry = new Formateur("Morre", "Thierry", "Cognitic");
            Formateur formateurMichael = new Formateur("Person", "Michael", "Cognitic");

            //Participants
            Participant participantThierry = new Participant("Thierry", "Gillot");
            Participant participantCharles = new Participant("Charles", "De Grote");
            Participant participantFlorence = new Participant("Florences", "Tuts");
            Participant participantKyle = new Participant("Kyle", "Barkner");
            Participant participantBrad = new Participant("Brad", "Pitt");
            Participant participantAngelina = new Participant("Angelina", "Jolie");
            Participant participantJohnny = new Participant("Johnny", "Dep");
            Participant participantStephanie = new Participant("Stephanie", "Goedertier");
            Participant participantManuel = new Participant("Manuel", "Peremans");

            ////Liste de participants
            //List<Participant> listeParticipants1 = new List<Participant>();
            //listeParticipants1.Add(participantThierry);
            //listeParticipants1.Add(participantAngelina);
            //listeParticipants1.Add(participantKyle);
            //listeParticipants1.Add(participantStephanie);
            //listeParticipants1.Add(participantCharles);

            //List<Participant> listeParticipants2 = new List<Participant>();
            //listeParticipants1.Add(participantFlorence);
            //listeParticipants1.Add(participantKyle);
            //listeParticipants1.Add(participantManuel);
            //listeParticipants1.Add(participantStephanie);
            //listeParticipants1.Add(participantBrad);

            //Formations

            Formation dotNet = new Formation("C#", 32, formateurGuillaume);
            Formation dotNetAvance = new Formation("C# Avancé", 50, formateurMichael);
            Formation sql = new Formation("SQL", 24, formateurMichael);


            //Cours donnés
            formateurGuillaume.DonneCours(dotNet);
            formateurThierry.DonneCours(dotNetAvance);
            formateurMichael.DonneCours(sql);

            //Inscription
            dotNet.Inscrire(participantThierry);
            dotNet.Inscrire(participantCharles);
            dotNet.Inscrire(participantFlorence);
            dotNet.Inscrire(participantAngelina);
            dotNet.Inscrire(participantStephanie);

            //Liste de formations
            //List<Formation> formationsListe = new List<Formation>();

        }
    }
}
