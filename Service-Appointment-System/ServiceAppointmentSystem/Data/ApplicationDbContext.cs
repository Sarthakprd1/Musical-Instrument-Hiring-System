using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ServiceAppointmentSystem.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Reflection.Emit;

namespace ServiceAppointmentSystem.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

	//The class defines various DbSet properties, which represent database tables or collections of entities that can be queried and manipulated using Entity Framework Core. The DbSet properties in this code include AppUsers, Items, Professionals, Services, Orders, OrderDetails, ShoppingCart, and Appointments. These properties allow accessing and performing CRUD (Create, Read, Update, Delete) operations on the corresponding entities in the database.
	public DbSet<AppUser> AppUsers { get; set; }

    public DbSet<Item> Items { get; set; }  

	public DbSet<Professional> Professionals { get; set; }

	public DbSet<Service> Services { get; set; }    

    public DbSet<OrderHeader> Orders { get; set; }

    public DbSet<OrderDetail> OrderDetails { get; set; }    

    public DbSet<ShoppingCart> ShoppingCart { get; set;  }

    public DbSet<Appointment> Appointments { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
		base.OnModelCreating(builder);

		builder.Entity<IdentityUser>().ToTable("Users");
        builder.Entity<IdentityRole>().ToTable("Roles");
        builder.Entity<IdentityUserToken<string>>().ToTable("Tokens");
        builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
        builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
        builder.Entity<IdentityUserLogin<string>>().ToTable("LoginAttempts");

        builder.Entity<Appointment>()
            .HasOne(x => x.AppUser)
            .WithMany(x => x.Appointments)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.NoAction);

    }
}
