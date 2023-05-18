
using System.Diagnostics;

namespace CRUD.Model.Books
{
    /// <summary>
    /// Represents an book model
    /// </summary>
    [DebuggerDisplay("Id: {" + nameof(Id) + "}, Title: {" + nameof(Title) + "}")]
    public class BookModel
    {
        #region Ctor

        public BookModel(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the author
        /// </summary>
        public string Author { get; set; }

        #endregion

    }
}
