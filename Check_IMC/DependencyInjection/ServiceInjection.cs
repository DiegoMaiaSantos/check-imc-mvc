using Check_IMC.Interfaces;
using Check_IMC.Services;

namespace Check_IMC.DependencyInjection
{
    public  static class ServiceInjection
    {
        public static IServiceCollection Services(this IServiceCollection services)
        {
            services.AddScoped<IImcService, ImcService>();

            return services;
        }
    }
}
