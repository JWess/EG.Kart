using AutoMapper;
using EG.Kart.Domain;
using EG.Kart.Presentation.Web.Models;

namespace EG.Kart.Presentation.Web.Infrastructure.Mapping
{
    public class TrackMap
    {
        public static void Map()
        {
            Mapper.CreateMap<Track, TrackModel>();
        }
    }
}