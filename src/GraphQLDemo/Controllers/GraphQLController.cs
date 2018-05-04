using System.Threading;
using System.Threading.Tasks;
using GraphQLDemo.GraphQL;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GraphQLDemo.Controllers
{
    [Route("[controller]")]
    public class GraphQLController : Controller
    {
        private readonly IGraphqlService _graphQLService;

        public GraphQLController(IGraphqlService graphQLService)
        {
            _graphQLService = graphQLService;
        }

        [HttpPost]
        [Produces("application/json")]
        public async Task<IActionResult> PostAsync([FromBody] GraphqlRequest query, CancellationToken cancellationToken)
        {
            var json = await _graphQLService.ExecuteAsync(query.Query, query.Variables?.ToString(), query.OperationName, cancellationToken);
            object jsonRes = JsonConvert.DeserializeObject(json);
            return Ok(jsonRes);
        }
    }
}
