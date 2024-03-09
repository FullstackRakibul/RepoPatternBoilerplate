using v1.DbContexts.Models;

namespace v1.Repository.IRepository
{
    public interface IPublicInterface
    {
        Task<PublicData> GetPublicDataByIdAsync(int id);
        Task<IEnumerable<PublicData>> GetPublicDataAsync();
        Task<PublicData> AddPublicDataAsync(PublicData data);
    }
}
