using CRUD.Service.Services.Books;
using Microsoft.Extensions.DependencyInjection;

namespace CRUD.Dependency
{
    /// <summary>
    /// Represents an service collection application services
    /// </summary>
    public static class ServiceCollectionApplicationServices
    {
        #region Methods

        #region Add application services

        /// <summary>
        /// This method is used to add application services
        /// </summary>
        /// <param name="services">Services</param>
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();
        }

        #endregion

        #endregion

    }
}
