using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace School.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            SchoolDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<SchoolDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.StudentCheck.Any())
            {
                context.StudentCheck.AddRange(
                    new StudentCheck
                    {
                        Name = "Jacob",
                        Email = "jacob@gmail.com",
                        Phone = "52324817",
                        Semester = 3
                    },
                    new StudentCheck
                    {
                        Name = "Børge",
                        Email = "Børge@gmail.com",
                        Phone = "98765432",
                        Semester = 5
                    }
                );
            context.SaveChanges();
        }
    }
}
}
