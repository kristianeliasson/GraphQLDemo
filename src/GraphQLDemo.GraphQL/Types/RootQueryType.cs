using System;
using GraphQL;
using GraphQL.Types;
using GraphQLDemo.Model;

namespace GraphQLDemo.GraphQL
{
    public class RootQueryType : ObjectGraphType
    {
        public RootQueryType()
        {
            Name = "IMS_Product_Teams";

            Field<ListGraphType<ProductType>>(
                nameof(Product),
                resolve: context =>
            {
                var userContext = context.UserContext as GraphqlUserContext;
                return userContext.Repository.Products;
            });

            Field<ListGraphType<TeamMemberType>>(
                nameof(TeamMember),
                resolve: context =>
            {
                var userContext = context.UserContext as GraphqlUserContext;
                return userContext.Repository.TeamMembers;
            });

            Field<ListGraphType<ScrumTeamType>>(
                nameof(ScrumTeam),
                resolve: context =>
            {
                var userContext = context.UserContext as GraphqlUserContext;
                return userContext.Repository.ScrumTeams;
            });
        }
    }
}
