using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Robit.AdventOfCode2023.Abstractions;

public interface IQuery { }

public interface IRepository<TModel>
{
    IEnumerable<TModel> Select(IQuery query, CancellationToken cancellationToken = default);
    void Insert(IEnumerable<TModel> list, CancellationToken cancellationToken = default);
    void Update(IEnumerable<TModel> list, CancellationToken cancellationToken = default);
    void Delete(IEnumerable<TModel> list, CancellationToken cancellationToken = default);
}

public abstract class BaseRepository<TModel>(ILogger<BaseRepository<TModel>> Logger) { }

public static class RepositoryExtensions
{

}