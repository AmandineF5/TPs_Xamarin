using System;
using System.Collections.Generic;
using System.Text;
using TP_Layouts.Models;

namespace TP_Layouts.Services
{
    public class TwitterService : ITwitterService
    {
        public bool authenticate(string identifiant, string mdp)
        {
            if (identifiant.Equals("croustis") && mdp.Equals("cacahuete"))
            {
                return true;
            }
            return false;
        }

        public List<Tweet> getTweets()
        {
            var tweets = new List<Tweet>();
            tweets.Add(new Tweet
            {
                DateCreation = new DateTime(2020, 09, 29),
                Identifiant = "tweet1",
                IdentifiantUtilisateur = "user1",
                NomUtilisateur = "Marco",
                PseudoUtilisateur = "Marco Polo",
                Texte = " A la claire fontaine, m'y allant promener"
            });

            tweets.Add(new Tweet
            {
                DateCreation = new DateTime(2020, 09, 30),
                Identifiant = "tweet2",
                IdentifiantUtilisateur = "user2",
                NomUtilisateur = "Dalaï",
                PseudoUtilisateur = "Dalaï Lama",
                Texte = "Ce matin j'ai bu mon thé au jasmin et je me sentais zeeeeeeeeeeeeeeen"
            });

            tweets.Add(new Tweet
            {
                DateCreation = new DateTime(2020, 09, 30),
                Identifiant = "tweet3",
                IdentifiantUtilisateur = "user3",
                NomUtilisateur = "Loukoum",
                PseudoUtilisateur = "Loukoum addiction",
                Texte = "Breaking news: la Turquie n'est pas le sain pays du Loukoum !"
            });

            return tweets;
        }

    }
}
