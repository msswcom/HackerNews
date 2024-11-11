
namespace HackerNews.Database.Sets
{
    public partial class Db
    {
        public async Task<T> InsertAsync<T>(T t) where T : class
        {
            await context.AddAsync(t);

            try
            {
                await context.SaveChangesAsync();
            }
            catch
            {
                //log
            }

            return t;
        }
    }
}
