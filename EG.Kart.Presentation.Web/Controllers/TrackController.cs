using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using EG.Kart.Data;
using EG.Kart.Domain;
using EG.Kart.Presentation.Web.Models;

namespace EG.Kart.Presentation.Web.Controllers
{
    public class TrackController : BootstrapBaseController
    {
        private readonly IRepository<Track> _trackRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TrackController(IRepository<Track> trackRepository, IUnitOfWork unitOfWork)
        {
            _trackRepository = trackRepository;
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            var races = Mapper.Map<IList<Track>, IList<TrackModel>>(  _trackRepository.Query().ToList() );
            
            return View(races);
        }

        public ActionResult Edit(int id)
        {
            var model = _trackRepository.GetById(id);
            return View("Create", model);
        }

        [HttpPost]
        public ActionResult Edit(TrackModel model)
        {
            if (!ModelState.IsValid) return View("Create", model);

            var track = _trackRepository.GetById(model.Id);
            if (track == null)
            {
                ModelState.AddModelError("Id", StringResource.ItemDoesNotExist);
                return View("Create", model);
            }

            track.Name = model.Name;
            _unitOfWork.Commit();

            Success(StringResource.ItemSaved);

            return RedirectToAction("Index");
        }
    }
}