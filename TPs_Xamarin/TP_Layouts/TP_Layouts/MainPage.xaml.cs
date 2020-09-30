using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Layouts.Services;
using Xamarin.Forms;

namespace TP_Layouts
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private bool isConnected = false;
        private const string ERROR_IDENTIFIANT = "Veuillez entrer un identifiant d'au moins 3 charactères";
        private const string ERROR_MDP = "Veuillez entrer un mot de passe d'au moins 6 charactères";
        private const string ERROR_GENERAL_CONNECTION = "Identifiant ou mot de passe incorrect";

        private TwitterService ts; 
        public MainPage()
        {
            InitializeComponent();
            this.ts = new TwitterService();

            this.connecter.Clicked += connecter_Clicked;

            this.loadTweets(this.TweetsList);
        }

        private void loadTweets(StackLayout tweetsList)
        {
            foreach (var tweet in ts.getTweets())
            {
                TweetView tv = new TweetView();
                tv.LoadData(tweet);
                tweetsList.Children.Add(tv);

            }
        }

        private void connecter_Clicked(object sender, EventArgs e)
        {
            //TP4 (module 7)
            if (!String.IsNullOrEmpty(this.identifiant.Text) && !String.IsNullOrEmpty(this.mdp.Text))
            {
                isConnected = this.ts.authenticate(this.identifiant.Text, this.mdp.Text);

            } else
            {
                this.error.Text = ERROR_GENERAL_CONNECTION;
            }

            //TP3 (module 6)
            //Debug.WriteLine("Connection is clicked");
            //this.error.Text = "";
            //var identifiant = this.identifiant.Text;
            //var mdp = this.mdp.Text;
            //StringBuilder errorSet = new StringBuilder();

            //if (identifiant == "" || identifiant == null || identifiant.Length < 3)
            //{
            //    errorSet.Append(ERROR_IDENTIFIANT);

            //    if (mdp == "" || mdp == null || mdp.Length < 6)
            //    {
            //        errorSet.Append("\n");
            //        errorSet.Append(ERROR_MDP);
            //    } 
            //} 

            //if (mdp == "" || mdp == null || mdp.Length < 6)
            //{
            //    if (identifiant != null)
            //    {
            //        errorSet.Append(ERROR_MDP);
            //    }

            //} 

            //if (errorSet.Length == 0)
            //{
            //    this.isConnected = true;
            //}
            //this.error.Text = errorSet.ToString();
            this.showHideContent(isConnected);
        }

      private void showHideContent (bool boo)
        {
            if (boo == false)
            {
                this.connectionForm.IsVisible = true;
                this.TweetsList.IsVisible = false;
            }
            else if (boo == true)
            {
                this.connectionForm.IsVisible = false;
                this.TweetsList.IsVisible = true;
            }
        }
    }
}
