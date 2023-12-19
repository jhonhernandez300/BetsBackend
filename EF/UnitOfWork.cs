using Bets.Domain;
using Bets.Domain.Interfaces;
using Bets.Domain.Models;
using Bets.EF.Repositories;

namespace Bets.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IBaseRepository<Team> Teams { get; private set; }        

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            Teams = new BaseRepository<Team>(_context);            
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
