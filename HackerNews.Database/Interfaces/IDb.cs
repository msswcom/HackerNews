
namespace HackerNews.Database.Interfaces
{
    public interface IDb
    {
        Task<T> InsertAsync<T>(T t) where T : class;
        Task<T> UpdateAsync<T>(T t) where T : class;
    }
}
