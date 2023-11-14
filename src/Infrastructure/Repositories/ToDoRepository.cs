using Domain.Abstractions.Repositories;
using Domain.Entities;

namespace Infrastructure.Repositories;

public class ToDoRepository : IRepository<ToDo>
{
    private readonly List<ToDo> _list = new ();

    public void Save(ToDo task)
    {
        _list.Add(task);
    }

    public ToDo GetById(Guid id)
    {
        return _list.First(t => t.Id == id);
    }

    public void Update(ToDo entity)
    {
        // Implementação da atualização no banco de dados ou outra fonte de dados.();
    }

    public List<ToDo> GetAll()
    {
        return _list;
    }
}