using System.Linq.Expressions;
using sample.Domain.Core;

namespace sample.Domain.Persistence;

public class BulkDeleteOptions<TEntity> where TEntity : class, IEntity<string>
{
    /// <summary>
    /// This option allows the usage of a custom key to verify the existence of entities.
    /// </summary>
    public Expression<Func<TEntity,object>>? ColumnPrimaryKeyExpression { get; set; }
}
