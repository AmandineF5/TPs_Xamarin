using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Layouts.Models;
using TP_Layouts.Services;
using TP_Layouts.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP_Layouts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetsListView : ContentPage
    {
        private TwitterService ts;
        private ObservableCollection<Tweet> tweetsObserver;
        public TweetsListView()
        {
            InitializeComponent();

            ts = new TwitterService();
            List<Tweet> tweetsDB = ts.getTweets();
            tweetsObserver = new ObservableCollection<Tweet>();

            foreach (var tweet in tweetsDB)
            {
                tweetsObserver.Add(tweet);
            }

            this.TweetsList.ItemsSource = tweetsObserver;

        }
    }
}