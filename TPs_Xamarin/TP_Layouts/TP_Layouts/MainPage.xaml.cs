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

            if (identifiant == "" || identifiant == null || mdp == "" || mdp == null)
            {
                this.error.Text = "Veuillez entrer un identifiant et un mot de passe";

            } else if (identifiant.Length < 3 && mdp.Length < 6)
            {
                this.error.Text = "Veuillez entrer un identifiant d'au moins 3 charactères et un mot de passe d'au moins 6 charactères";
            } else if (identifiant.Length < 3)
            {
                this.error.Text = "Veuillez entrer un identifiant d'au moins 3 charactères";

            } else if (mdp.Length < 6)
            {
                this.error.Text = "Veuillez entrer un mot de passe d'au moins 6 charactères";
            } else
            {
                this.isConnected = true;
            }

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
