using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TwitterClone.Models
{
    
    public class SubmitTweetViewModel
    {
        [Required]
        public string Content { get; set; }
        public ApplicationUser User { get; set; }
    }
}