using Domain.Entities;

namespace Domain.Abstractions.Services;

public interface IToDoService
{
    ToDo CreateTask(string description);
    void MarkTaskAsCompleted(Guid taskId);
    List<ToDo> GetAllTasks();
}