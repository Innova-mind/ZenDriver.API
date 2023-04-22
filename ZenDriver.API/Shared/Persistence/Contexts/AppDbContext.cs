using ZenDriver.API.Shared.Extensions;
using Microsoft.EntityFrameworkCore;
using ZenDriver.API.ApplyForJob.Domain.Models;
using ZenDriver.API.DriverProfile.Domain.Communication.Models;
using ZenDriver.API.DriverProfile.Domain.Models;
using ZenDriver.API.Security.Domain.Models;

namespace ZenDriver.API.Shared.Persistence.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Driver> Drivers { get; set; }

    public DbSet<Driverprofile> Driverprofiles { get; set; }
    public DbSet<License> Licenses { get; set; }

    public DbSet<Company> Companies { get; set; }
    public DbSet<Recruiter> Recruiters { get; set; }
    public DbSet<Post> Posts { get; set; }
    
    public DbSet<SocialNetwork> SocialNetworks { get; set; }

    public DbSet<Address> Address { get; set; }
    public AppDbContext(DbContextOptions options) : base (options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
 
        
        //Users
        //Constraints
        builder.Entity<User>().ToTable("Users");
        builder.Entity<User>().HasKey(p => p.Id);
        builder.Entity<User>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<User>().Property(p => p.UserName).IsRequired();
        builder.Entity<User>().Property(p => p.FirstName).IsRequired();
        builder.Entity<User>().Property(p => p.LastName).IsRequired();
        builder.Entity<User>().Property(p => p.Role).IsRequired().HasMaxLength(10);
        builder.Entity<User>().Property(p => p.Phone).IsRequired();
        builder.Entity<User>().Property(p => p.Description);
        
        
        
        //Address
        builder.Entity<Address>().ToTable("Address");
        builder.Entity<Address>().HasKey(p => p.Id);
        builder.Entity<Address>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Address>().Property(p => p.NameAddress).IsRequired().HasMaxLength(500);
        //Relationsships
        builder.Entity<Address>()
            .HasOne(p => p.User)
            .WithMany(p => p.Addresses)
            .HasForeignKey(p => p.UserId);

        // Companies
        builder.Entity<Company>().ToTable("Companies");
        builder.Entity<Company>().HasKey(p => p.Id);
        builder.Entity<Company>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd(); 
        builder.Entity<Company>().Property(p => p.Name).IsRequired();
        builder.Entity<Company>().Property(p => p.RUC).IsRequired().HasMaxLength(11);
        builder.Entity<Company>().Property(p => p.Owner).IsRequired();
        
        
        // Recruiters
        builder.Entity<Recruiter>().ToTable("Recruiters");
        builder.Entity<Recruiter>().HasKey(p => p.Id);
        builder.Entity<Recruiter>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        // Relationsships
        builder.Entity<Recruiter>()
            .HasOne(p => p.Company)
            .WithOne(p => p.Recruiter)
            .HasForeignKey<Recruiter>(p => p.CompanyId);
        
        // Posts
        builder.Entity<Post>().ToTable("Posts");
        builder.Entity<Post>().HasKey(p => p.Id);
        builder.Entity<Post>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Post>().Property(p => p.Title).IsRequired(); 
        builder.Entity<Post>().Property(p => p.Description).IsRequired();
        builder.Entity<Post>().Property(p => p.date).IsRequired();
        // Relationsships
        builder.Entity<Post>()
            .HasOne(p => p.Recruiter)
            .WithMany(p => p.Posts)
            .HasForeignKey(p => p.RecruiterId);

        
        //Driverprofile
        builder.Entity<Driverprofile>().ToTable("Driverprofile");
        builder.Entity<Driverprofile>().HasKey(p => p.Id);
        builder.Entity<Driverprofile>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        //Relationsships
        builder.Entity<Driverprofile>()
            .HasOne(p => p.Driver)
            .WithOne(p => p.Driverprofile)
            .HasForeignKey<Driverprofile>(p => p.DriverId);
        builder.Entity<Driverprofile>()
            .HasOne(p => p.License)
            .WithOne(p => p.Driverprofile)
            .HasForeignKey<Driverprofile>(p => p.LicenseId);
        
        //License
        builder.Entity<License>().ToTable("License");
        builder.Entity<License>().HasKey(p => p.Id);
        builder.Entity<License>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        
        //Apply Snake Case Naming Convention
        builder.UseSnakeCaseNamingConvention();

    }
}
