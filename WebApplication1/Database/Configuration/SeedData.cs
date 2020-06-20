using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Database.Entities;

namespace WebApplication1.Database.Configuration
{
    public static  class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Database.AppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Database.AppContext>>()))
            {
                if(context.car.Any())
                {
                    return;
                }

                context.car.AddRange(
                    new Car { Manufacturer="Hyundai",Model="i10"},
                    new Car {  Manufacturer = "Hyundai", Model = "i10" } ,
                    new Car {  Manufacturer = "Hyundai", Model = "i20" });

                context.SaveChanges();
            }
            
        }
    }
}