using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConverterLibrary.LanguageExtensions
{
    public static class ConvertExtensions
    {
        #region generic list converter

        public static IEnumerable<T> ConvertTo<T>(this IEnumerable items)
            => items.Cast<object>().Select(x => (T)Convert.ChangeType(x, typeof(T)));

        public static List<T> ConvertToList<T>(this IEnumerable items)
            => items.ConvertTo<T>().ToList();

        public static IList ConvertToList(this IEnumerable items, Type targetType)
        {
            var method = typeof(ConvertExtensions).GetMethod(
                nameof(ConvertToList),
                new[] { typeof(IEnumerable) });

            var generic = method.MakeGenericMethod(targetType);

            return (IList)generic.Invoke(null, new[] { items });

        }

        #endregion
        /// <summary>
        /// Split items into chunks by size.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="items"></param>
        /// <param name="size">The maximum size of each chunk.</param>
        /// <returns>IEnumerable&lt;TSource[]&gt;</returns>
        /// <remarks>
        /// Every chunk except the last will be of size size. The last chunk will contain the remaining elements and may be of a smaller size.
        /// This is built into .NET Core 6
        /// <see cref="Enumerable.Chunk"/>
        /// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.chunk?view=net-6.0
        /// </remarks>
        public static IEnumerable<IEnumerable<TSource>> Chunk<TSource>(this IEnumerable<TSource> items, int size)
        {
            HashSet<HashSet<TSource>> resultHashSet = new HashSet<HashSet<TSource>>();
            List<List<TSource>> chunks = items.SplitBy(size);

            for (int index = 0; index < chunks.Count; index++)
            {
                HashSet<TSource> item = chunks[index].ToHashSet();
                resultHashSet.Add(item);
            }

            return resultHashSet;
        }

        public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source, IEqualityComparer<T> comparer = null) 
            => new(source, comparer);

        public static List<List<T>> SplitBy<T>(this IEnumerable<T> collection, int size)
        {
            var chunkItems = new List<List<T>>();
            var count = 0;
            var tempList = new List<T>();

            foreach (var element in collection)
            {
                if (count++ == size)
                {
                    chunkItems.Add(tempList);
                    tempList = new List<T>();
                    count = 1;
                }
                tempList.Add(element);
            }

            chunkItems.Add(tempList);

            return chunkItems;
        }
    }
}