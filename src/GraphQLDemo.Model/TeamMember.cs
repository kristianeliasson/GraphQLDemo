using System.Diagnostics;

namespace GraphQLDemo.Model
{
    [DebuggerDisplay("{FirstName,nq}")]
    public class TeamMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ScrumTeam Team { get; set; }
    }
}
