
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using v1.Repository.IRepository;

namespace v1.Services
{
    public class PublicService
    {
        private readonly IPublicInterface _publicInterface;
        public PublicService(IPublicInterface publicInterface)
        {
            _publicInterface = publicInterface;
        }

        public async Task<string> PublicServiceData()
        {
            return "This is a public message from the service layer.";
        }
    }
}
