using MSE.WebApp.MVC.Services;

namespace MSE.WebApp.MVC.Configuration
{
    public static class DependecyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddHttpClient<IAutenticacaoService, AutenticacaoService>();
        }
    }
}
