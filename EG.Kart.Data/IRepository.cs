using System;
using System.Collections.Generic;
using System.Linq;
using EG.Kart.Domain;

namespace EG.Kart.Data
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        IQueryable<TEntity> Query();

        TEntity GetById(Guid id);

        void Create(TEntity entityToCreate);
        void Create(IList<TEntity> entitiesToCreate);

        void Update(TEntity entityToUpdate);
        void Update(TEntity entityToUpdate, TEntity entityOnContext);
        void Update(IList<TEntity> entitiesToUpdate);

        void Delete(Guid id);
        void Delete(IList<Guid> ids);
        void Delete(TEntity entityToDelete);
        void Delete(IList<TEntity> entitiesToDelete);
    }
}
