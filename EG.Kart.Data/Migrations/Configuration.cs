using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using EG.Kart.Domain;

namespace EG.Kart.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<KartDbBaseDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KartDbBaseDbContext context)
        {
            var tracks = new List<string>
                {
                    "Bowser Castle 3",
                    "Bowser's Castle (Mario Kart)",
                    "Coconut Mall",
                    "Cookie Land",
                    "D.K.'s Jungle Parkway",
                    "Daisy Circuit",
                    "Delfino Square",
                    "Desert Hills",
                    "DK Mountain",
                    "DK Summit",
                    "Dry Dry Ruins (Mario Kart)",
                    "Galaxy Colosseum",
                    "Ghost Valley 2",
                    "Grumble Volcano",
                    "Koopa Cape",
                    "Luigi Circuit",
                    "Maple Treeway",
                    "Mario Circuit",
                    "Mario Circuit 3",
                    "Moo Moo Meadows",
                    "Moonview Highway",
                    "Mushroom Gorge",
                    "Peach Beach",
                    "Peach Gardens",
                    "Rainbow Road",
                    "Sherbet Land (Mario Kart)",
                    "Shy Guy Beach",
                    "Toad's Factory",
                    "Waluigi Stadium",
                    "Wario's Gold Mine",
                    "Yoshi Falls"
                }.Select(x => new Race {Trackname = x}).ToList();
            
            context.Set<Race>().AddOrUpdate(x => x.Trackname, tracks.ToArray());
        }
    }
}
