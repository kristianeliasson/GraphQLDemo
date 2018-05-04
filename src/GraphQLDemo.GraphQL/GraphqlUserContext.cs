using GraphQLDemo.Model;

namespace GraphQLDemo.GraphQL
{
    public class GraphqlUserContext
    {
        public GraphqlUserContext(IRepository repository)
        {
            Repository = repository;
        }
        public IRepository Repository { get; }
    }
}