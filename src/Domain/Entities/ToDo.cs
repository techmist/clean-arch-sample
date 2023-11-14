namespace Domain.Entities;

public record ToDo(Guid Id, string Description, bool IsCompleted = false)
{
    public bool IsCompleted { get; private set; } = IsCompleted;
    
    public void CheckCompleted() 
        => IsCompleted = true;
}