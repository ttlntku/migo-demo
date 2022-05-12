using Core.Entities;
using Core.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DataContext : DbContext
    {
        //public DataContext() : base() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<StoryEntity> Stories { get; set; }
        public DbSet<TopicEntity> Topics { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    if (!options.IsConfigured)
        //    {
        //        options.UseSqlServer("A FALLBACK CONNECTION STRING");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            this.ConfigureTopicEntity(modelBuilder);
            this.ConfigureStoryEntity(modelBuilder);
        }

        private void ConfigureTopicEntity(ModelBuilder modelBuilder)
        {
            //seeding
            modelBuilder.Entity<TopicEntity>().HasData(
                new TopicEntity
                {
                    Id = 1,
                    TopicName = "Food & Drinks",
                    TopicIcon = "../assets/food-drink.svg",
                    CreatedBy = "KIEU",
                    CreatedAt = CustomUtilities.CustomDatetimeConvert(DateTime.Now),
                    UpdatedBy = "KIEU",
                    UpdatedAt = CustomUtilities.CustomDatetimeConvert(DateTime.Now)
                },
                new TopicEntity
                {
                    Id = 2,
                    TopicName = "City & Culture",
                    TopicIcon = "../assets/city-cultures.svg",
                    CreatedBy = "KIEU",
                    CreatedAt = CustomUtilities.CustomDatetimeConvert(DateTime.Now),
                    UpdatedBy = "KIEU",
                    UpdatedAt = CustomUtilities.CustomDatetimeConvert(DateTime.Now)
                },
                new TopicEntity
                {
                    Id = 3,
                    TopicName = "Getaway & Resorts",
                    TopicIcon = "../assets/gateway-resort.svg",
                    CreatedBy = "KIEU",
                    CreatedAt = CustomUtilities.CustomDatetimeConvert(DateTime.Now),
                    UpdatedBy = "KIEU",
                    UpdatedAt = CustomUtilities.CustomDatetimeConvert(DateTime.Now)
                },
                new TopicEntity
                {
                    Id = 4,
                    TopicName = "Nature & Adventure",
                    TopicIcon = "../assets/nature-adventure.svg",
                    CreatedBy = "KIEU",
                    CreatedAt = CustomUtilities.CustomDatetimeConvert(DateTime.Now),
                    UpdatedBy = "KIEU",
                    UpdatedAt = CustomUtilities.CustomDatetimeConvert(DateTime.Now)
                });
        }

        private void ConfigureStoryEntity(ModelBuilder modelBuilder)
        {
            //seeding
            modelBuilder.Entity<StoryEntity>().HasData(
                new StoryEntity
                {
                    Id = 1,
                    TopicId = 1,
                    Title = "Beautiful beach at Sunrise Resort, in Hoi An, Quang Nam",
                    PhotoUrl = "../assets/topic.png",
                    Address = "Phú Quốc, Việt Nam",
                    Description = @"Located in an open space with clouds,
                                    sky, and sea, the special highlight of
                                    the resort is the architectural style
                                    combining the three countries of Japan,
                                    France and Vietnam.",
                    AwardIconUrl = "../assets/gateway-resort.svg",
                    AwardName = "",
                    CreatedBy = "KIEU",
                    CreatedAt = CustomUtilities.CustomDatetimeConvert(DateTime.Now),
                    UpdatedBy = "KIEU",
                    UpdatedAt = CustomUtilities.CustomDatetimeConvert(DateTime.Now)
                },
                new StoryEntity
                {
                    Id = 2,
                    TopicId = 1,
                    Title = "Topas Ecolodge - Service and comfort in the clouds",
                    PhotoUrl = "../assets/city-cultures.svg",
                    Address = "Phú Quốc, Việt Nam",
                    Description = @"Located in an open space with clouds,
                                    sky, and sea, the special highlight of
                                    the resort is the architectural style
                                    combining the three countries of Japan,
                                    France and Vietnam.",
                    AwardIconUrl = "../assets/gateway-resort.svg",
                    AwardName = "",
                    CreatedBy = "KIEU",
                    CreatedAt = CustomUtilities.CustomDatetimeConvert(DateTime.Now),
                    UpdatedBy = "KIEU",
                    UpdatedAt = CustomUtilities.CustomDatetimeConvert(DateTime.Now)
                },
                new StoryEntity
                {
                    Id = 3,
                    TopicId = 1,
                    Title = "Topas Ecolodge - Service and comfort in the clouds",
                    PhotoUrl = "../assets/city-cultures.svg",
                    Address = "Phú Quốc, Việt Nam",
                    Description = @"Located in an open space with clouds,
                                    sky, and sea, the special highlight of
                                    the resort is the architectural style
                                    combining the three countries of Japan,
                                    France and Vietnam.",
                    AwardIconUrl = "../assets/gateway-resort.svg",
                    AwardName = "",
                    CreatedBy = "KIEU",
                    CreatedAt = CustomUtilities.CustomDatetimeConvert(DateTime.Now),
                    UpdatedBy = "KIEU",
                    UpdatedAt = CustomUtilities.CustomDatetimeConvert(DateTime.Now)
                },
                new StoryEntity
                {
                    Id = 4,
                    TopicId = 1,
                    Title = "Experience traveling 4 days 3 nights in Quang Ngai pearl island",
                    PhotoUrl = "../assets/nature-adventure.svg",
                    Address = "Quảng Nam, Việt Nam",
                    Description = @"Located in an open space with clouds,
                                    sky, and sea, the special highlight of
                                    the resort is the architectural style
                                    combining the three countries of Japan,
                                    France and Vietnam.",
                    AwardIconUrl = "../assets/gateway-resort.svg",
                    AwardName = "Nature Adventure",
                    CreatedBy = "KIEU",
                    CreatedAt = CustomUtilities.CustomDatetimeConvert(DateTime.Now),
                    UpdatedBy = "KIEU",
                    UpdatedAt = CustomUtilities.CustomDatetimeConvert(DateTime.Now)
                });
        }
    }
}
