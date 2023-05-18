using AutoMapper;
using CRUD.Domain.Entities;
using CRUD.Model.Books;

namespace CRUD.Service.Mapping.Books
{
    /// <summary>
    /// Represents an book mapping profile
    /// </summary>
    public class BookMapping : Profile
    {
        #region Ctor

        public BookMapping()
        {
            CreateMap<Book, BookModel>();

            CreateMap<BookModel, Book>();
        }

        #endregion
    }
}
