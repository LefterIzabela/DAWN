using Tema1.Repositories;
using Tema1.Services;

namespace Tema1.Settings
{
    public static class Dependencies
    {
        public static void Inject(WebApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Services.AddControllers();
            applicationBuilder.Services.AddSwaggerGen();

            AddRepositories(applicationBuilder.Services);
            AddServices(applicationBuilder.Services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<ProductService>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<ProductRepository>();
        }
    }
}