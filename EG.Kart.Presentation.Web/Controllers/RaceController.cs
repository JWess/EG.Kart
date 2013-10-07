using System.Linq;
using System.Web.Mvc;
using EG.Kart.Data;
using EG.Kart.Domain;

namespace EG.Kart.Presentation.Web.Controllers
{
    public class RaceController : Controller
    {
        private readonly IRepository<Race> _raceRepository;

        public RaceController(IRepository<Race> raceRepository)
        {
            _raceRepository = raceRepository;
        }

        public ActionResult Index()
        {
            var races = _raceRepository.Query()
            .Select(x => x.Trackname)
            .ToList();
            
            return View(races);
        }
    }
}