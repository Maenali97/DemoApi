using JetBrains.Annotations;
using System.Linq.Expressions;

namespace DemoApi
{
    public static class EnumerableExtensions
    {
        public static IQueryable<T> WhereIf<T>([NotNull] this IQueryable<T> query, bool condition, Expression<Func<T, bool>> predicate)
        {
            Check.NotNull(query, nameof(query));

            return condition
                ? query.Where(predicate)
                : query;
        }
    }

}
