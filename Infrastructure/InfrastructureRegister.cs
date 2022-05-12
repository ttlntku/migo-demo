using Core.Repositories;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class InfrastructureRegister
    {
        public static void AddInfrastructureService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(m =>
                m.UseSqlServer(configuration.GetConnectionString("MigoDB")), ServiceLifetime.Singleton
            );

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IStoryRepository, StoryRepository>();
            services.AddTransient<ITopicRepository, TopicRepository>();
        }
    }
}
