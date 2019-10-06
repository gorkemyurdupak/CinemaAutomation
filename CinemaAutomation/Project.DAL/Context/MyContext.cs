using Project.DAL.StrategyPattern;
using Project.MAP.Options;
using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
  public class MyContext:DbContext
    {
        public MyContext():base("CinemaConnection")
        {
            Database.SetInitializer(new MyInitiliazer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new AppUserProfileMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new GenreMap());
            modelBuilder.Configurations.Add(new MovieMap());
            modelBuilder.Configurations.Add(new MovieSeansMap());
            modelBuilder.Configurations.Add(new SalonMap());
            modelBuilder.Configurations.Add(new SalonSeansMap());
            modelBuilder.Configurations.Add(new SeansMap());
            modelBuilder.Configurations.Add(new SeatMap());
            modelBuilder.Configurations.Add(new SpecialDayMap());
            modelBuilder.Configurations.Add(new TicketMap());
            //modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
            Database.SetInitializer<MyContext>(null);
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> AppUserProfiles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieSeans> MovieSeanss { get; set; }   
        public DbSet<Salon> Salons { get; set; }
        public DbSet<SalonSeans> SalonSeanss { get; set; }
        public DbSet<Seans> Seanss { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SpecialDay> SpecialDays { get; set; }
        public DbSet<Ticket> Tickets { get; set; }



    }
}
