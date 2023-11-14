using Application.Usecases;
using Infrastructure.Repositories;

var repository = new ToDoRepository();
var usecases = new ToDoUsecases(repository);

// Exemplo de uso
var task1 = usecases.CreateTask("Criar um exemplo prático de Clean Architecture");
var task2 = usecases.CreateTask("Implementar casos de uso");
usecases.MarkTaskAsCompleted(task1.Id);

Console.WriteLine("Tarefas:");
foreach (var task in usecases.GetAllTasks())
{
    Console.WriteLine($"ID: {task.Id}, Descrição: {task.Description}, Concluída: {task.IsCompleted}");
}