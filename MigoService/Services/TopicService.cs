using Application.Mappers;
using Core.Entities;
using Core.Repositories;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigoService.Services
{
    public class TopicService : TopicFunc.TopicFuncBase
        {
            private readonly ILogger<StoryService> _logger;
        private readonly ITopicRepository _topicRepository;
        public TopicService(ILogger<StoryService> logger, ITopicRepository topicRepository)
        {
            _logger = logger;
            _topicRepository = topicRepository;
        }

        public async override Task<Topics> GetAllTopic(EmptyTopic request, ServerCallContext context)
        {
            Topics returnTopic = new Topics();
            List<TopicEntity> listStory = await _topicRepository.GetAllAsync();
            returnTopic.Items.AddRange(listStory.Select(le => MapperConfig.mapper.Map<Topic>(le)).ToList());
            return Task.FromResult(returnTopic).Result;
        }
    }
}
