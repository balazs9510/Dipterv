using DAL;
using DAL.SeedServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Helpers
{
    public static class DbContextHelper
    {
        static object _lock = new object();
        public static BookingSystemDbContext GetInMemoryDbContext()
        {
            var options = new DbContextOptionsBuilder<BookingSystemDbContext>()
                .UseInMemoryDatabase(databaseName: "Inmemory_db")
                .ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning))
                .Options;
            var seedService = new SeedService();
            var context = new BookingSystemDbContext(options, seedService);
            
            lock (_lock)
            {
                if (!context.Users.Any())
                {
                    context.Users.AddRange(seedService.Users.Select(x => x.Value));
                    context.Images.AddRange(seedService.Images.Select(x => x.Value));
                    context.Events.AddRange(seedService.Events.Select(x => x.Value));
                    context.ServiceTypes.AddRange(seedService.ServiceTypes.Select(x => x.Value));
                    context.Services.AddRange(seedService.Services.Select(x => x.Value));
                    context.SaveChanges();
                }
            }

            return context;
        }
    }
}
