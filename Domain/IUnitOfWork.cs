using Bets.Domain.Interfaces;
using Bets.Domain.Models;

namespace Bets.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Team> Teams { get; }        

        int Complete();
    }
}
