using GraphQL.Types;
using GraphQLDemo.Model;

namespace GraphQLDemo.GraphQL
{
    public class TeamMemberType : ObjectGraphType<TeamMember>
    {
        public TeamMemberType()
        {
            Field(x => x.FirstName);
            Field(x => x.LastName);
            Field<ScrumTeamType>(nameof(TeamMember.Team), resolve: x => x.Source.Team);
        }
    }
}
