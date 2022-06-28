using Microsoft.EntityFrameworkCore;
using UserService.Database.Entities;

namespace UserService.Database
{
    public class DatabaseContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=owashim\sqlexpress;Initial Catalog=UserMicroService;Integrated Security=True;Pooling=False");
        }

        public DbSet<User> Users { get; set; }
    }
}
