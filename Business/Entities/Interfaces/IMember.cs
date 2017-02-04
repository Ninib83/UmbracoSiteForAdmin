using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnderlakareCmsDialogue.Business.Entities.Interfaces
{
    public interface IMember
    {
        int Id { get; }
        string UserName { get; }
        string Email { get; }
    }
}