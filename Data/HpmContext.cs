using HPM.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace HPM.Data
{
    public class HpmContext : DbContext
    {
        public HpmContext(DbContextOptions<HpmContext> options) : base(options)
        {
        }
            public DbSet<Authentication> Authentications {get ; set;}
            public DbSet<JobRequest> JobRequests {get ; set;}
            public DbSet<Location> Locations {get ; set;}
            public DbSet<Material> Materials {get ; set;}
            public DbSet<Patient> Patients {get ; set;}
            public DbSet<Person> Persons {get ; set;}
            public DbSet<Status> Statuses {get ; set;}
            public DbSet<UrgentType> UrgentTypes {get ; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
#if DEBUG
            optionsBuilder.LogTo(Console.WriteLine);
#endif
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Authentication>()
                .HasData(
                    new Authentication
                    {
                        AuthId = 1,
                        UserName = "HPMTest",
                        Password = "Test",
                        FirstName = "Test",
                        LastName = "Test",
                        Department = "Test",
                        FlagStatus ="Test",
                        PhoneNumber = "Test",
                        UserRole ="Test",
                    }
                );
        }
    }
}