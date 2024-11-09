
namespace HackerNews.Database.Sets
{
    public partial class Db
    {
        public async Task<T> InsertAsync<T>(T t) where T : class
        {
            await context.AddAsync(t);

            await context.SaveChangesAsync();

            return t;
        }
    }
}
