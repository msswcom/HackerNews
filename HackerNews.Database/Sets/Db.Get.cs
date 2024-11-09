
namespace HackerNews.Database.Sets
{
    public partial class Db
    {
        public async Task<T?> GetAsync<T>(object id) where T : class
        {
            var dbSet = context.Set<T>();

            return await dbSet.FindAsync(id);
        }
    }
}
