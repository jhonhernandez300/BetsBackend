using Bets.Domain.Interfaces;
using Bets.Domain.Models;

namespace Bets.EF.Repositories
{
    public class TeamRepository : BaseRepository<Team>, ITeamRepository
    {
        private readonly ApplicationDbContext _context;

        public TeamRepository(ApplicationDbContext context) : base(context)
        {
        }

        //public IEnumerable<Team> SpecialMethod()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
