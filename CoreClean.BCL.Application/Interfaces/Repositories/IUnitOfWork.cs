using BlazorHero.CleanArchitecture.Application.Interfaces.Repositories;

using CoreClean.BCL.Domaine.Models;

namespace CoreClean.BCL.Application.Interfaces.Repositories;

public interface IUnitOfWork<TId> : IDisposable
{
    IRepositoryAsync<T, TId> Repository<T>() where T : AuditableEntity<TId>;

    Task<int> Commit(CancellationToken cancellationToken);

    Task<int> CommitAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys);

    Task Rollback();
}