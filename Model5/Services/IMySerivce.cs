namespace Model5.Services;

public interface IMySerivce
{
    Guid Id { get; }
}

public class MyService : IMySerivce, IDisposable
{
    //public Guid Id => Guid.NewGuid();

    public Guid Id { get; } = Guid.NewGuid();

    public void Dispose() { Console.WriteLine($"{Id} displose....");  }
}