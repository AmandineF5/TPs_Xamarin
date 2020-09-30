using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Layouts.Models;
using TP_Layouts.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP_Layouts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetView : ContentView
    {
        public TweetView()
        {
            InitializeComponent();
        }

        public void LoadData (Tweet tweet)
        {
            this.TweetInfos.Text = String.Format("{0} {1} {2} ", tweet.PseudoUtilisateur, tweet.DateCreation, this.TweetText);
            this.TweetText.Text = tweet.Texte;
            
        }
    }
}