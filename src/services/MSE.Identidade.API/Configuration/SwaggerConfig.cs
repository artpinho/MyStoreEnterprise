using Microsoft.OpenApi.Models;

namespace MSE.Identidade.API.Configuration
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "MSE.Identidade.API",
                    Description = "Esta API faz parte do curso ASP.NET Core Enterprise Applications.",
                    Version = "v1",
                    Contact = new OpenApiContact { Name = "Artenir Pinho", Email = "artpinho@live.com" },
                    License = new OpenApiLicense { Name = "MIT", Url = new Uri("https://opensource.org/licenses/MIT") }
                });
            });
            return services;
        }

        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(url: "/swagger/v1/swagger.json", name: "v1");
            });
            return app;
        }
    }
}
