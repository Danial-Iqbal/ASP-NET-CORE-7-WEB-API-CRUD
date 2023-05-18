using AutoMapper;
using CRUD.Domain.Entities;
using CRUD.Model.Books; 

namespace CRUD.Service.Services.Books
{
    /// <summary>
    /// Represents an book service
    /// </summary>
    public class BookService : IBookService
    {
        #region Properties

        private readonly IMapper _mapper;

        private static readonly IList<Book> Books = Book.GetAll();

        #endregion

        #region Ctor

        public BookService(IMapper mapper)
        {
            _mapper = mapper;
        }

        #endregion

        #region Methods

        #region Get all

        /// <summary>
        /// This method is used to get all books
        /// </summary>
        /// <returns>Books</returns>
        public IList<BookModel>? GetAll() => _mapper.Map<IList<BookModel>>(Books);

        #endregion

        #region Get by identifier 

        /// <summary>
        /// This method is used to get book by identifier
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns></returns>
        public BookModel? GetById(int id)
        {
            var book = Books.FirstOrDefault(x => x.Id == id);

            return _mapper.Map<BookModel>(book);
        }

        #endregion

        #region Add

        /// <summary>
        /// This method is used to add book
        /// </summary>
        /// <param name="model">Model</param>
        /// <returns>Identifier</returns>
        public int Add(BookModel model)
        {
            var entity = _mapper.Map<Book>(model);

            Books.Add(entity);

            return entity.Id;
        }

        #endregion

        #region Update

        /// <summary>
        /// This method is used to update book
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <param name="model">Model</param>
        public void Update(int id, BookModel model)
        {
            var book = Books.FirstOrDefault(x => x.Id == id);

            if (book != null)
            {
                var position = Books.IndexOf(book);

                Books.Insert(position, _mapper.Map<Book>(model));

                Books.Remove(book);
            }
        }

        #endregion

        #region Delete

        /// <summary>
        /// This method is used to delete book
        /// </summary>
        /// <param name="id">Identifier</param>
        public void Delete(int id)
        {
            var book = Books.FirstOrDefault(x => x.Id == id);

            if (book != null) Books.Remove(book);
        }

        #endregion

        #endregion

    }
}
