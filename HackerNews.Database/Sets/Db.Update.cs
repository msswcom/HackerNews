
namespace HackerNews.Database.Sets
{
    public partial class Db
    {
        public async Task<T> UpdateAsync<T>(T t) where T : class
        {
            context.Update(t);

            await context.SaveChangesAsync();

            return t;
        }
    }
}
