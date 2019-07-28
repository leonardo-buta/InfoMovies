using InfoMovies.Domain.Interfaces;
using InfoMovies.Infra.Data.Context;
using System.Threading.Tasks;

namespace InfoMovies.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly InfoMoviesContext _context;

        public UnitOfWork(InfoMoviesContext context)
        {
            _context = context;
        }

        public Task<int> CommitAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
