using System.Collections.Generic;

namespace GraphQLDemo.Model
{
    public interface IRepository
    {
        List<Product> Products { get; }
        List<ScrumTeam> ScrumTeams { get; }
        List<TeamMember> TeamMembers { get; }
    }
}