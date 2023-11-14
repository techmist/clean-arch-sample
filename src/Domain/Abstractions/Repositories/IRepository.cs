using Domain.Entities;

namespace Domain.Abstractions.Repositories;

public interface IRepository<TEntity>
{
    void Save(TEntity entity);
    ToDo GetById(Guid id);
    void Update(TEntity entity);
    List<TEntity> GetAll();
}