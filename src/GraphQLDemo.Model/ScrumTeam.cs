using System.Collections.Generic;
using System.Diagnostics;

namespace GraphQLDemo.Model
{
    [DebuggerDisplay("{Name,nq}")]
    public class ScrumTeam
    {
        public string Name { get; set; }

        public IList<TeamMember> Members { get; } = new List<TeamMember>();

    }
}
