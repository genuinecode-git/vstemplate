namespace ApplicationTemplate.Infrastructure;

public interface IUnitOfWork
{
    ISampleRepository Samples { get; }

    Task SaveChangesAsync();
}
