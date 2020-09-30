using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public MainPage()
        {
            InitializeComponent();
            this.connecter.Clicked += connecter_Clicked;
            

        }

        private void connecter_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Connection is clicked");
            this.error.Text = "";
            var identifiant = this.identifiant.Text;
            var mdp = this.mdp.Text;
            StringBuilder errorSet = new StringBuilder();

            if (identifiant == "" || identifiant == null || identifiant.Length < 3)
            {
                errorSet.Append(ERROR_IDENTIFIANT);

                if (mdp == "" || mdp == null || mdp.Length < 6)
                {
                    errorSet.Append("\n");
                    errorSet.Append(ERROR_MDP);
                } 
            } 

            if (mdp == "" || mdp == null || mdp.Length < 6)
            {
                if (identifiant != null)
                {
                    errorSet.Append(ERROR_MDP);
                }
                
            } 

            if (errorSet.Length == 0)
            {
                this.isConnected = true;
            }
            this.error.Text = errorSet.ToString();
            this.showHideContent(isConnected);
        }

      private void showHideContent (bool boo)
        {
            if (boo == false)
            {
                this.connectionForm.IsVisible = true;
                this.tweets.IsVisible = false;
            }
            else if (boo == true)
            {
                this.connectionForm.IsVisible = false;
                this.tweets.IsVisible = true;
            }
        }
    }
}
