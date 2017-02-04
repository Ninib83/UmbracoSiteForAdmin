using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderlakareCmsDialogue.Business.Entities.Interfaces;

namespace UnderlakareCmsDialogue.Business.Services.Interfaces
{
    public interface ITopicsService
    {
        ITopic GetTopicById(Guid id);
        ITopicPaging GetRecentTopics(int page, int size);
    }

  
}
