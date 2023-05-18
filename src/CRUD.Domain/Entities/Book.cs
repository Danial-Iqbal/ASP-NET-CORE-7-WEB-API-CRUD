 using System.Diagnostics;

 namespace CRUD.Domain.Entities
{
    /// <summary>
    /// Represents an book
    /// </summary>
    [DebuggerDisplay("Id: {" + nameof(Id) + "}, Title: {" + nameof(Title) + "}")]
    public class Book
    {
        #region Ctor

        public Book(int id, string title, string author)
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

        #region Factory methods

        /// <summary>
        /// This method is used to get all books
        /// </summary>
        /// <returns>Books</returns>
        public static IList<Book> GetAll() =>
            new List<Book>{
                new Book(1,"C# in Depth","Jon Skeet"),
                new Book(2,"Head First C#","Andrew Stellman"),
                new Book(3,"Professional C# and .Net","Christian Nagel")

            };

        #endregion

    }
}
