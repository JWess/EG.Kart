using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using EG.Kart.Domain;

namespace EG.Kart.Data
{
    public interface IBaseDbContext : IDisposable
    {
        int SaveChanges();
        IDbSet<T> Set<T>() where T : Entity;
        DbEntityEntry<T> Entry<T>(T entity) where T : Entity;
    }
}
