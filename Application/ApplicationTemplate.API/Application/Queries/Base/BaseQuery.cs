
namespace ApplicationTemplate.API.Application.Queries.Base;

public class BaseQuery(IDbConnection connection)
{
    protected readonly IDbConnection _connection = connection;


}
