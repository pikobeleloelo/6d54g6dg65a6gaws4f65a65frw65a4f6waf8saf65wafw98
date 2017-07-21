namespace WebApplication4.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication4.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication4.DAL.TraningContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication4.DAL.TraningContext context)
        {
            var tranings = new List<Traning>
            {
                new Traning { DST = "3.235", TM = "03:20:21", AVG = "23.5", MAX = "32.5",KM1 = "2:02", DATE = "2017-05-11 15:21:41", TEMP = "23", WEATHER = "poogdna", ENDMNDO = "adadada"},
                new Traning { DST = "8.235", TM = "03:25:21", AVG = "22", MAX = "26",KM1 = "1:20", DATE = "2017-05-91 15:21:41", TEMP = "23", WEATHER = "poogdna", ENDMNDO = "adadada"}
            };
            tranings.ForEach(t => context.Tranings.AddOrUpdate(r => r.DST, t));
            context.SaveChanges();
        }
    }
}
