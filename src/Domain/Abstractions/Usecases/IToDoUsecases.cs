using Domain.Entities;

namespace Domain.Abstractions.Usecases;

public interface IToDoUsecases
{
    ToDo CreateTask(string description);
    void MarkTaskAsCompleted(Guid taskId);
    List<ToDo> GetAllTasks();
}