using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderlakareCmsDialogue.Business.Entities.Interfaces
{
    public interface ITopic
    {
        Guid Id { get; }
        string Name { get;}
        int Views { get; }
    }
}
