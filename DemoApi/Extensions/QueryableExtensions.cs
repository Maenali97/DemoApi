using System.Diagnostics.CodeAnalysis;

namespace DemoApi
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> PageBy<T>([NotNull] this IQueryable<T> query, int skipCount, int maxResultCount)
        {
            Check.NotNull(query, nameof(query));

            return query.Skip(skipCount).Take(maxResultCount);
        }
    }
}
