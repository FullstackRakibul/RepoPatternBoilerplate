using v1.DbContexts.Models;
using v1.DTOs;
using v1.Repository.IRepository;

namespace v1.Repository
{
    public class PublicRepository : IPublicInterface
    {
        private readonly IPublicInterface _publicInterface;

        public  PublicRepository(IPublicInterface publicInterface) {
            _publicInterface = publicInterface;
        }

        public async Task<PublicData> GetPublicDataAsync(int id) {
            return await _context.PublicData.FindAsync(id);
        }

    }
}
