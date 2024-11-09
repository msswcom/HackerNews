
namespace HackerNews.Models.Collections
{
    public partial class Collection
    {
        /// <summary>
        /// Gets first n items in orderedIds from unorderedDictionary
        /// </summary>
        /// <typeparam name="T">Type stored in dictionary</typeparam>
        /// <param name="n">Number of items to get</param>
        /// <param name="orderedIds">List of ordered ids</param>
        /// <param name="unorderedDictionary">Dictionary of unordered items</param>
        /// <returns>List of n ordered items</returns>
        public static List<T> GetFirstOrderedItems<T>(int n, List<long> orderedIds, Dictionary<long, T> unorderedDictionary)
        {
            var orderedList = new List<T>();

            for (int i = 0; i < n; ++i)
            {
                var id = orderedIds[i];

                orderedList.Add(unorderedDictionary[id]);
            }

            return orderedList;
        }
    }
}
