using Degree.DAL.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Degree.DAL.Context
{
    public class MyDbContext: IdentityDbContext<User>
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountInfo> AccountInfos { get; set; }
        public DbSet<SearchHistory> SearchHistorys { get; set; }
        public DbSet<Advice> Advices { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> contextOptions) : base(contextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Account>().HasKey(x => x.Id);
            builder.Entity<Account>().Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Entity<Account>().HasOne(x => x.User)
                .WithMany(x => x.Accounts)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<AccountInfo>().HasKey(x => x.Id);
            builder.Entity<AccountInfo>().Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Entity<AccountInfo>().HasOne(x => x.Account)
                .WithMany(x => x.AccountInfos)
                .HasForeignKey(x => x.AccountId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<SearchHistory>().HasKey(x => x.Id);
            builder.Entity<SearchHistory>().Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Entity<SearchHistory>().HasOne(x => x.Account)
                .WithMany(x => x.SearchHistories)
                .HasForeignKey(x => x.AccountId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Advice>().HasKey(x => x.Id);
            builder.Entity<Advice>().Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
