using GraphQL;
using GraphQL.Http;
using GraphQL.Types;
using GraphQLDemo.GraphQL;
using GraphQLDemo.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQLDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // TODO: Add GraphQL services here
            services.AddSingleton<IRepository, Repository>();
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<IDocumentWriter, DocumentWriter>();
            services.AddSingleton<IGraphqlService, GraphqlService>();
            services.AddSingleton<GraphqlUserContext>();
            services.AddSingleton<ISchema>(s => new Schema { Query = new RootQueryType() });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseGraphiQl();
            app.UseMvc();
        }
    }
}
