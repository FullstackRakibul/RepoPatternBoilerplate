using v1.Services;

namespace v1.DependencyInversion
{
    public class DependencyInversion
    {
        public static void RegisterServices(PublicService publicService)
        {
            //services.AddTransient<, BookRepo>();
        }

        internal static void RegisterServices(IServiceCollection services)
        {
            throw new NotImplementedException();
        }
    }
}
