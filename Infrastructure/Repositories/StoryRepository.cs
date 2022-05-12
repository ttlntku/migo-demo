using Core.Entities;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class StoryRepository : BaseRepository<StoryEntity>, IStoryRepository
    {
        public StoryRepository(DataContext _dataContext) : base(_dataContext) { }
    }
}
