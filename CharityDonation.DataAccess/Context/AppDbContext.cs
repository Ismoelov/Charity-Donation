
using CharityDonation.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CharityDonation.DataAccess.Context;

public class AppDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=CharityDonationDb;Trusted_Connection=True;";
        optionsBuilder.UseSqlServer(ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
        .HasMany(User => User.donations)
        .WithOne(Donations=> Donations.User);

    }

    public DbSet<User> Users {  get; set; }
    public DbSet<Donation_Goal> Donation_Goals { get; set; }
    public DbSet<Donation> Donations { get; set; }
}
    