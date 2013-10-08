using System.Web.Mvc;
using EG.Kart.Data;
using EG.Kart.Presentation.Web.Infrastructure;
using StructureMap;

namespace EG.Kart.Presentation.Web.App_Start
{
    public class IocConfig
    {
        public static void Configure()
        {
            ControllerBuilder.Current.SetControllerFactory(new StructureMapControllerFactory());
            ObjectFactory.Initialize(x =>
            {
                x.For<IBaseDbContext>().Use<KartDbBaseDbContext>();
                x.For<IContextFactory>().Use<ContextFactory>();
                x.For<IUnitOfWork>().Use<EntityFrameworkUnitOfWork>();
                
                x.For(typeof(IRepository<>))
                    .HttpContextScoped()
                    .Use(typeof(Repository<>));
            });
        }
    }
}