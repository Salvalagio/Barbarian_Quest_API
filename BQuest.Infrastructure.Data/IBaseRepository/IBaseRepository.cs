
namespace BQuest.Infrastructure.Data.IBaseRepository
{
    public interface IBaseRepository<T> where T: class
    {
        X QueryFirstOrDefault<X>(string sqlCommand, object parameters);
    }
}
