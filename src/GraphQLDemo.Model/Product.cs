using System.Collections.Generic;
using System.Diagnostics;

namespace GraphQLDemo.Model
{
    [DebuggerDisplay("{Name,nq}")]
    public class Product
    {
        public string Name { get; set; }
        public IList<ScrumTeam> Teams { get; } = new List<ScrumTeam>();
    }
}
