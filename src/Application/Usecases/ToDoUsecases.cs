using Domain.Abstractions.Services;
using Domain.Abstractions.Repositories;
using Domain.Entities;

namespace Application.Usecases;

public class ToDoUsecases:IToDoService
{
    private readonly IRepository<ToDo> _repository;

    public ToDoUsecases(IRepository<ToDo> repository)
    {
        _repository = repository;
    }

    public ToDo CreateTask(string description)
    {
        var task = new ToDo(Guid.NewGuid(), description);
        _repository.Save(task);
        return task;
    }

    public void MarkTaskAsCompleted(Guid id)
    {
        var task = _repository.GetById(id);
        task.CheckCompleted();
        _repository.Update(task);
    }

    public List<ToDo> GetAllTasks()
    {
        return _repository.GetAll();
    }
}