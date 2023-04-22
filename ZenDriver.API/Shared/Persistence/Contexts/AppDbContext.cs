using ZenDriver.API.Shared.Extensions;
using Microsoft.EntityFrameworkCore;
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
        
        // //Driver
        // builder.Entity<Driver>().ToTable("Driver");
        // builder.Entity<Driver>().HasKey(p => p.Id);
        // builder.Entity<Driver>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        // //Relationsships
        // builder.Entity<Driver>()
        //     .HasOne(p => p.User)
        //     .WithOne(p => p.Driver)
        //     .HasForeignKey<Driver>(p => p.UserId);
          
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
