using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TwitterClone.Models
{
    
    public class HubIndexViewModel
    {
        public SubmitTweetViewModel SubmitTweetModel { get; set; }
        public ListTweetsViewModel TweetsViewModel { get; set; }
    }

    public class SubmitTweetViewModel
    {
        [Required]
        public string Content { get; set; }
        public string UserID { get; set; }
    }

    public class ListTweetsViewModel
    {
        [Required]
        public List<Tweet> Tweets { get; set; }
    }
}