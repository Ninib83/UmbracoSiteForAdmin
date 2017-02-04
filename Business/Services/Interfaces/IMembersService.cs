using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnderlakareCmsDialogue.Business.Entities.Interfaces;

namespace UnderlakareCmsDialogue.Business.Services.Interfaces
{
    public interface IMembersService
    {
        IMember GetMemberById(int id);
        IMember GetMemberByUsername(string username);
        IMember GetMemberByEmail(string email);
    }
}