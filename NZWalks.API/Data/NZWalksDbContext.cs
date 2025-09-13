using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext:DbContext
    {
        public NZWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    var difficulties = new List<Difficulty>
        //    {
        //        new Difficulty
        //        {
        //            Id = Guid.Parse("5f5d8c9c-c22c-4666-8e11-604eb1c9f5fb"),
        //            Name = "Easy"
        //        }
        //    };
        //    modelBuilder.Entity<Difficulty>().HasData(difficulties);
        //}

    }
}
