namespace lab4_application.Migrations.ApplicationDb
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<lab4_application.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ApplicationDb";
        }

        protected override void Seed(lab4_application.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Cities.AddOrUpdate( i => i.CityId,
                new Models.City
                {
                    CityId = 1,
                    CityName = "Vancouver",
                    Population = 100000,
                    ProviniceCode = "BC"
                },
                new Models.City
                {
                    CityId = 2,
                    CityName = "Burnaby",
                    Population = 90000,
                    ProviniceCode = "BC"
                },
                new Models.City
                {
                    CityId = 3,
                    CityName = "Surrey",
                    Population = 90000,
                    ProviniceCode = "BC"
                },
                new Models.City
                {
                    CityId = 4,
                    CityName = "Calary",
                    Population = 90000,
                    ProviniceCode = "AB"
                },
                new Models.City
                {
                    CityId = 5,
                    CityName = "Edminton",
                    Population = 90000,
                    ProviniceCode = "AB"
                },
                new Models.City
                {
                    CityId = 6,
                    CityName = "Red Dear",
                    Population = 90000,
                    ProviniceCode = "AB"
                },
                new Models.City
                {
                    CityId = 7,
                    CityName = "Toronto",
                    Population = 90000,
                    ProviniceCode = "ON"
                },
                new Models.City
                {
                    CityId = 8,
                    CityName = "Ottawa",
                    Population = 90000,
                    ProviniceCode = "ON"
                },
                new Models.City
                {
                    CityId = 9,
                    CityName = "Hamilton",
                    Population = 90000,
                    ProviniceCode = "ON"
                }
            );

            context.Provinces.AddOrUpdate( i => i.ProviniceCode,
                new Models.Province
                {
                    ProviniceCode = "BC",
                    ProviceName = "British Columbia"
                },
                new Models.Province
                {
                    ProviniceCode = "AB",
                    ProviceName = "Alberta"
                },
                new Models.Province
                {
                    ProviniceCode = "ON",
                    ProviceName = "Ontario"
                }
            );

        }
    }
}
