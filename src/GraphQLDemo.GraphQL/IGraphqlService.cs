using System.Threading;
using System.Threading.Tasks;

namespace GraphQLDemo.GraphQL
{
    public interface IGraphqlService
    {
        Task<string> ExecuteAsync(string query, string variables, string operationName, CancellationToken cancellationToken);
    }
}
