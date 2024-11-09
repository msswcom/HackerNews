
namespace HackerNews.Models.Validations
{
    public static partial class Validation
    {
        public static bool GreaterThanCount<T>(this int index, ICollection<T> collection)
        {
            return index > collection.Count;
        }
    }
}
