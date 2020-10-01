using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Layouts.Models
{
   public class Tweet
    {
        private string identifiant;
        private DateTime dateCreation;
        private string texte;
        private string nomUtilisateur;
        private string identifiantUtilisateur;
        private string pseudoUtilisateur;

        public string Identifiant { get => identifiant; set => identifiant = value; }
        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }
        public string Texte { get => texte; set => texte = value; }
        public string NomUtilisateur { get => nomUtilisateur; set => nomUtilisateur = value; }
        public string IdentifiantUtilisateur { get => identifiantUtilisateur; set => identifiantUtilisateur = value; }
        public string PseudoUtilisateur { get => pseudoUtilisateur; set => pseudoUtilisateur = value; }

        private string tweetInfos;

        public string TweetInfos
        {
            get { return 
                    String.Format("{0} {1}", this.PseudoUtilisateur, this.DateCreation); }
            set { tweetInfos = value; }
        }

    }
}
