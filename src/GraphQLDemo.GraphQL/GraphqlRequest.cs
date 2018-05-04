using Newtonsoft.Json.Linq;

namespace GraphQLDemo.GraphQL
{
    public class GraphqlRequest
    {
        public string OperationName { get; set; }
        public string Query { get; set; }
        public JObject Variables { get; set; }
    }
}
