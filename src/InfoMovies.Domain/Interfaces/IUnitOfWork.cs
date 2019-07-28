using System;
using System.Threading.Tasks;

namespace InfoMovies.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> CommitAsync();
    }
}
