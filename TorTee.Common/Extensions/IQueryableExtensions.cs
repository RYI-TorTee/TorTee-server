using System.Linq.Expressions;
using System.Reflection;

namespace TorTee.Core.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> OrderByDynamic<T>(this IQueryable<T> source, string propertyName, bool descending)
        {
            if (string.IsNullOrEmpty(propertyName))
            {
                return source;
            }

            var parameter = Expression.Parameter(typeof(T), "p");
            var property = typeof(T).GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

            if (property == null)
            {
                throw new ArgumentException($"Property '{propertyName}' not found on type '{typeof(T)}'");
            }

            var propertyAccess = Expression.MakeMemberAccess(parameter, property);
            var orderByExp = Expression.Lambda(propertyAccess, parameter);
            var orderByMethod = descending ? "OrderByDescending" : "OrderBy";

            var resultExp = Expression.Call(typeof(Queryable), orderByMethod, new Type[] { typeof(T), property.PropertyType },
                                             source.Expression, Expression.Quote(orderByExp));
            return source.Provider.CreateQuery<T>(resultExp);
        }

        public static IQueryable<T> ApplyFilters<T>(this IQueryable<T> source, IDictionary<string, object> filters)
        {
            if (filters == null || !filters.Any())
            {
                return source;
            }

            foreach (var filter in filters)
            {
                source = source.ApplyFilter(filter.Key, filter.Value);
            }

            return source;
        }

        private static IQueryable<T> ApplyFilter<T>(this IQueryable<T> source, string propertyName, object value)
        {
            if (value == null)
            {
                return source;
            }

            var parameter = Expression.Parameter(typeof(T), "p");
            var property = typeof(T).GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

            if (property == null)
            {
                throw new ArgumentException($"Property '{propertyName}' not found on type '{typeof(T)}'");
            }

            var propertyAccess = Expression.MakeMemberAccess(parameter, property);
            var constant = Expression.Constant(value);
            var equality = Expression.Equal(propertyAccess, constant);
            var lambda = Expression.Lambda<Func<T, bool>>(equality, parameter);

            return source.Where(lambda);
        }
    }
}
