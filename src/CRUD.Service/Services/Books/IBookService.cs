 
using CRUD.Model.Books;

namespace CRUD.Service.Services.Books
{
    /// <summary>
    /// Represents an book service
    /// </summary>
    public interface IBookService
    {
        #region Get all

        /// <summary>
        /// This method is used to get all books
        /// </summary>
        /// <returns>Books</returns>
        IList<BookModel>? GetAll();

        #endregion

        #region Get by identifier

        /// <summary>
        /// This method is used to get book by identifier
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns></returns>
        BookModel? GetById(int id);

        #endregion

        #region Add

        /// <summary>
        /// This method is used to add book
        /// </summary>
        /// <param name="model">Model</param>
        /// <returns>Identifier</returns>
        int Add(BookModel model);

        #endregion

        #region Update

        /// <summary>
        /// This method is used to update book
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <param name="model">Model</param>
        void Update(int id, BookModel model);

        #endregion

        #region Delete

        /// <summary>
        /// This method is used to delete book
        /// </summary>
        /// <param name="id">Identifier</param>
        void Delete(int id);

        #endregion

    }
}
