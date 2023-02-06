using TarjetaPresentacion.API.Helpers;

namespace TarjetaPresentacion.API.Extensions
{
    public static  class UtilExtensions
    {
        public static void ConfigureUtils(this IServiceCollection services)
        {
            services.AddTransient<StatusCodeBuilder>();

        }

    }
}
