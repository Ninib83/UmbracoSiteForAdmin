using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnderlakareCmsDialogue.Business.Entities;
using UnderlakareCmsDialogue.Business.Entities.Interfaces;
using UnderlakareCmsDialogue.Business.Helpers;
using UnderlakareCmsDialogue.Business.Services.Interfaces;

namespace UnderlakareCmsDialogue.Business.Services
{
    public class TopicService : ITopicsService
    {
        private readonly Dialogue.Logic.Services.TopicService _topicService;

        public TopicService(Dialogue.Logic.Services.TopicService topicService)
        {
            _topicService = topicService;
        }

        public ITopicPaging GetRecentTopics(int page, int pageSize)
        {
            var topics = _topicService.GetRecentTopics(page, pageSize, Int32.MaxValue);
            var hasMore = PagingHelper.HasMore(page, pageSize, topics.TotalCount);
            var results = new TopicPaging(hasMore, topics.TotalCount, topics);

            return results;
        }

        public ITopic GetTopicById(Guid id)
        {
            var topic = _topicService.Get(id);
            return new Topic(topic.Id, topic.Name, topic.Views);
        }
    }
}