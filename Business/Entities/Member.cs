using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnderlakareCmsDialogue.Business.Entities.Interfaces;

namespace UnderlakareCmsDialogue.Business.Entities
{
    public class Member : IMember
    {
        public Member(int id, string username, string email)
        {
            Id = id;
            UserName = username;
            Email = email;
        }


        public string Email
        {
            get;
        }

        public int Id
        {
            get;
        }

        public string UserName
        {
            get;
        }
    }
}