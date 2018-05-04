using System.Collections.Generic;

namespace GraphQLDemo.Model
{
    public class Repository : IRepository
    {
        public Repository()
        {
            var chickens = new ScrumTeam { Name = "Chickens" };
            var tigers = new ScrumTeam { Name = "Tigers" };
            var mantis = new ScrumTeam { Name = "Mantis" };
            var panthers = new ScrumTeam { Name = "Panthers" };
            var f4 = new ScrumTeam { Name = "F4" };
            ScrumTeams = new List<ScrumTeam>(new[] { chickens, tigers, mantis, panthers, f4 });

            var mymarket = new Product { Name = "MyMarket" };
            mymarket.Teams.Add(chickens);
            mymarket.Teams.Add(tigers);
            var myscape = new Product { Name = "Myscape" };
            myscape.Teams.Add(mantis);
            myscape.Teams.Add(panthers);
            myscape.Teams.Add(f4);
            var southstar = new Product { Name = "Southstar" };
            southstar.Teams.Add(chickens);
            var productAccounts = new Product { Name = "Product Accounts" };
            productAccounts.Teams.Add(tigers);
            Products = new List<Product>(new[] { mymarket, myscape, southstar, productAccounts });

            var alfred = new TeamMember { FirstName = "Alfred", LastName = "Hitchcock", Team = chickens };
            chickens.Members.Add(alfred);
            var barry = new TeamMember { FirstName = "Barry", LastName = "Humphries", Team = chickens };
            chickens.Members.Add(barry);
            var charles = new TeamMember { FirstName = "Charles", LastName = "Darwin", Team = chickens };
            chickens.Members.Add(charles);
            var daniel = new TeamMember { FirstName = "Daniel", LastName = "Craig", Team = chickens };
            chickens.Members.Add(daniel);
            var eric = new TeamMember { FirstName = "Eric", LastName = "Bana", Team = tigers };
            tigers.Members.Add(eric);
            var fred = new TeamMember { FirstName = "Fred", LastName = "Flinstone", Team = chickens };
            chickens.Members.Add(fred);
            var gary = new TeamMember { FirstName = "Gary", LastName = "Oldman", Team = tigers };
            tigers.Members.Add(gary);

            var harry = new TeamMember { FirstName = "Harry", LastName = "Potter", Team = f4 };
            f4.Members.Add(harry);
            var ian = new TeamMember { FirstName = "Ian", LastName = "McKellen", Team = f4 };
            f4.Members.Add(ian);
            var jill = new TeamMember { FirstName = "Jill", LastName = "Valentine", Team = f4 };
            f4.Members.Add(jill);

            var kevin = new TeamMember { FirstName = "Kevin", LastName = "Bacon", Team = mantis };
            mantis.Members.Add(kevin);
            var lisa = new TeamMember { FirstName = "Lisa", LastName = "Simpson", Team = mantis };
            mantis.Members.Add(lisa);
            var matin = new TeamMember { FirstName = "Martin", LastName = "Freeman", Team = mantis };
            mantis.Members.Add(matin);

            var nicole = new TeamMember { FirstName = "Nicole", LastName = "Kidman", Team = panthers };
            panthers.Members.Add(nicole);
            var oscar = new TeamMember { FirstName = "Oscar", LastName = "Wilde", Team = panthers };
            panthers.Members.Add(oscar);
            var peter = new TeamMember { FirstName = "Peter", LastName = "Pan", Team = panthers };
            panthers.Members.Add(peter);

            TeamMembers = new List<TeamMember>(new[] { alfred, barry, charles, daniel, eric, fred, gary, lisa, kevin, harry, nicole, lisa, oscar, ian, matin, jill, harry, peter });
        }

        public List<Product> Products { get; private set; }

        public List<ScrumTeam> ScrumTeams { get; private set; }

        public List<TeamMember> TeamMembers { get; private set; }
    }
}
