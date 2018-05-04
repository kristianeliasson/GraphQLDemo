using GraphQL.Types;
using GraphQLDemo.Model;

namespace GraphQLDemo.GraphQL
{
    public class ScrumTeamType : ObjectGraphType<ScrumTeam>
    {
        public ScrumTeamType()
        {
            Field(x => x.Name);
            Field<ListGraphType<TeamMemberType>>(nameof(ScrumTeam.Members), resolve: x => x.Source.Members);
        }
    }
}
