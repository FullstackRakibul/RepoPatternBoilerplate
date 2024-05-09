using v1.Repository;
using v1.Repository.IRepository;
using v1.Services;

namespace v1.DependencyInversion
{
    public class DependencyInversion
    {

        internal static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient <IPublicInterface ,PublicRepository>();
        }
    }
}
