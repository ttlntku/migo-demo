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
    public class StoryService : StoryFunc.StoryFuncBase
    {
        private readonly ILogger<StoryService> _logger;
        private readonly IStoryRepository _storyRepository;
        public StoryService(ILogger<StoryService> logger, IStoryRepository storyRepository)
        {
            _logger = logger;
            _storyRepository = storyRepository;
        }

        public async override Task<Stories> GetAllStory(EmptyStory request, ServerCallContext context)
        {
            Stories returnStories = new Stories();
            List<StoryEntity> listStory = await _storyRepository.GetAllAsync();
            returnStories.Items.AddRange(listStory.Select(le => MapperConfig.mapper.Map<Story>(le)).Take(4).ToList());
            return Task.FromResult(returnStories).Result;
        }
    }
}
