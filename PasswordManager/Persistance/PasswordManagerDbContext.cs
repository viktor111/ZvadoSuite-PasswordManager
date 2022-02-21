namespace PasswordManager.Persistance
{
    using Microsoft.EntityFrameworkCore;
    using Models.IdentityData;
    using Models.Users;

    public class PasswordManagerDbContext : DbContext
    {
        public PasswordManagerDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=appdb.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityData>().ToTable("IdentityDatas");
            modelBuilder.Entity<User>().ToTable("Users");
        }

        public DbSet<IdentityData> IdentityDatas { get; set; } = default!;

        public DbSet<User> Users { get; set; } = default!;
    }
}
