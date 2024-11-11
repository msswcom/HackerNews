
namespace HackerNews.Database.Sets
{
    public partial class Db
    {
        public async Task<T> UpdateAsync<T>(T t) where T : class
        {
            context.Update(t);

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
