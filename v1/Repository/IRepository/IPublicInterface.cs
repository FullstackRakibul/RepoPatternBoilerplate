using v1.DbContexts.Models;

namespace v1.Repository.IRepository
{
    public interface IPublicInterface
    {
        Task <IEnumerable<PublicData>> GetPublicDataAsync();
    }
}
