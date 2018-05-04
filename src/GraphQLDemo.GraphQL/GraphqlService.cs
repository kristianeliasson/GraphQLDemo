using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Http;
using GraphQL.Instrumentation;
using GraphQL.Types;
using GraphQL.Validation.Complexity;
using Newtonsoft.Json.Linq;

namespace GraphQLDemo.GraphQL
{
    public class GraphqlService : IGraphqlService
    {
        private readonly ISchema _schema;
        private readonly IDocumentExecuter _executer;
        private readonly IDocumentWriter _writer;
        private readonly GraphqlUserContext _userContext;

        public GraphqlService(ISchema schema, IDocumentExecuter executer, IDocumentWriter writer, GraphqlUserContext userContext)
        {
            _schema = schema;
            _executer = executer;
            _writer = writer;
            _userContext = userContext;
        }

        public async Task<string> ExecuteAsync(string query, string variables, string operationName, CancellationToken cancellationToken)
        {
            var inputs = variables.ToInputs();

            var result = await _executer.ExecuteAsync(x =>
            {
                x.UserContext = _userContext;
                x.Schema = _schema;
                x.Query = query;
                x.OperationName = operationName;
                x.Inputs = inputs;
                x.CancellationToken = cancellationToken;
                x.ComplexityConfiguration = new ComplexityConfiguration { MaxDepth = 15 }; // Set limit to the nesting
                x.FieldMiddleware.Use<InstrumentFieldsMiddleware>();
            });

            if (result.Errors?.Any() ?? false)
            {
                string errors = string.Join(Environment.NewLine, result.Errors.Select(x => x.Message));
                return JObject.FromObject(new { Error = errors }).ToString();
            }

            return _writer.Write(result);
        }
    }
}
