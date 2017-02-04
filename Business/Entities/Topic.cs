using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnderlakareCmsDialogue.Business.Entities.Interfaces;

namespace UnderlakareCmsDialogue.Business.Entities
{
    public class Topic : ITopic
    {
        public Topic(Guid id, string name, int views)
        {
            Id = id;
            Name = name;
            Views = views;
        }
        public Guid Id { get; }
        public string Name { get; }
        public int Views { get; }
    }
}