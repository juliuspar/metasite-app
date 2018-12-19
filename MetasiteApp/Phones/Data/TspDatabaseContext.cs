using System;
using Microsoft.EntityFrameworkCore;

namespace MetasiteApp.Phones.Data
{
    public class TspDatabaseContext : DbContext
    {
        public TspDatabaseContext(DbContextOptions<TspDatabaseContext> options) : base(options)
        {
        }

        public DbSet<Sms> Smses { get; set; }

        public DbSet<Call> Calls { get; set; }

        public DbSet<Phone> Phones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedWithRandomData(modelBuilder);
        }

        private static void SeedWithRandomData(ModelBuilder modelBuilder)
        {
            var random = new Random();
            int smsId = 1;
            int callId = 1;

            for (int phoneId = 1; phoneId < 100; phoneId++)
            {
                modelBuilder.Entity<Phone>().HasData(new Phone
                {
                    PhoneId = phoneId,
                    Number = $"370{random.Next(67999990, 67999999)}",
                });
                modelBuilder.Entity<Sms>().HasData(new Sms
                {
                    PhoneId = phoneId,
                    SmsId = smsId++,
                    Date = DateTime.Now - TimeSpan.FromDays(random.Next(1, 28))
                });
                modelBuilder.Entity<Call>().HasData(new Call
                {
                    PhoneId = phoneId,
                    CallId = callId++,
                    Duration = random.Next(1, 20),
                    Date = DateTime.Now - TimeSpan.FromDays(random.Next(1, 28))
                });
            }
        }
    }
}
