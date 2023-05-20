using Microsoft.EntityFrameworkCore;
using ShipStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipStoreApp.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId= 1,
                    Name = "Light Bulb 100W/240V",
                    Description = "Halogen Single Ended E14 100W/240V JD20X74MM HE14240100",
                    ImageUrl= "Assets/Lightbulbs/30142936.jpg",
                    Category = Enums.Category.Light_Bulbs_Tubes
                },
                new Product() 
                {
                    ProductId = 2,
                    Name = "Project Lighting 75W/240V",
                    Description = "Project Lighting Jo Halogen 75W/240V EIIT 14X81648173200",
                    ImageUrl = "Assets/Lightbulbs/30142929.jpg",
                    Category = Enums.Category.Light_Bulbs_Tubes
                },
                new Product()
                {
                    ProductId = 3,
                    Name = "Osram Parathom 100W/220-240V",
                    Description = "Osram Parathom 100W/220-240V JD20X74MM HE14240100",
                    ImageUrl = "Assets/Lightbulbs/30143099.jpg",
                    Category = Enums.Category.Light_Bulbs_Tubes
                },
                new Product()
                {
                    ProductId = 4,
                    Name = "Shelf Support",
                    Description = "Shelf Support",
                    ImageUrl = "Assets/Structural/30142767.jpg",
                    Category = Enums.Category.Structural_Supplies
                },
                new Product()
                {
                    ProductId = 5,
                    Name = "Radiator Air Bleed Key",
                    Description = "Radiator Air Bleed Key",
                    ImageUrl = "Assets/OutdoorMisc/30142680.jpg",
                    Category = Enums.Category.Outdoor_or_Misc
                }
                );
        }
    }
}
