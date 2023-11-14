namespace Domain.Entities;

public record ToDo(Guid Id, string Description, bool IsCompleted = false)
{
    public bool IsCompleted { get; private set; } = IsCompleted;
    
    public ToDo(string Description):this(Guid.NewGuid(), Description){}
        
    public void CheckCompleted() 
        => IsCompleted = true;
}