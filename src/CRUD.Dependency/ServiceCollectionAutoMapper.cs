using CRUD.Service.Services.Books;
using Microsoft.Extensions.DependencyInjection; 
using CRUD.Domain.Entities;

namespace CRUD.Dependency
{
    /// <summary>
    /// Represents an service collection auto mapper
    /// </summary>
    public static class ServiceCollectionAutoMapper
    {
        #region Methods

        #region Add auto mapper

        /// <summary>
        /// This method is used to add auto mapper
        /// </summary>
        /// <param name="services">Services</param>
        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(IBookService), typeof(Book));
        }

        #endregion

        #endregion

    }
}
