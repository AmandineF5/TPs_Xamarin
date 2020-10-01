using System;
using System.Collections.Generic;
using System.Text;
using TP_Layouts.Models;

namespace TP_Layouts.Services
{
    public interface ITwitterService
    {
        bool Authenticate(string identifiant, string mdp);
        List<Tweet> GetTweets();
    }
}
