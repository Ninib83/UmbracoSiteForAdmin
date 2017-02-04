using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;

namespace UnderlakareCmsDialogue.Models
{
    public class CustomMember
    {
        
        
        public int CustomMemberId { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }


    }
}