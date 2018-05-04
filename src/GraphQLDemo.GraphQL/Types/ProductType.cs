using GraphQL.Types;
using GraphQLDemo.Model;

namespace GraphQLDemo.GraphQL
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(x => x.Name);
            Field<ListGraphType<ScrumTeamType>>(nameof(Product.Teams), resolve: x => x.Source.Teams);
        }
    }
}
