namespace Application.Infrastructure;

public interface IUnitOfWork
{
    ISampleRepository Samples { get; }

    Task SaveChangesAsync();
}
