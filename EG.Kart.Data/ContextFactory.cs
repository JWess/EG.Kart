namespace EG.Kart.Data
{
    public interface IContextFactory
    {
        IBaseDbContext Get();
    }

    public class ContextFactory : IContextFactory
    {
        private IBaseDbContext _baseDbContext;

        #region Implementation of IContextFactory

        public IBaseDbContext Get()
        {
            return _baseDbContext ?? (_baseDbContext = new KartDbBaseDbContext());
        }

        #endregion
    }
}
